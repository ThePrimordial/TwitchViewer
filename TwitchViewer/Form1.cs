using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace TwitchViewer
{
    public partial class Form1 : Form
    {

        private List<Stream> liveChannels;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<Top> games = TwitchImp.generateTopGames();
            foreach (Top top in games)
            {
                lb_gameList.Items.Add(top.game.name + "- " + top.viewers + " viewers");
            }
        }

        private void lb_gameList_SelectedIndexChanged(object sender, EventArgs e)
        {
            cleanlistbox(lb_channelList);
            string toSplit = ((string)lb_gameList.SelectedItem);
            string url = toSplit.Substring(0, toSplit.LastIndexOf("-"));
            liveChannels = TwitchImp.generateStreams(url);
            foreach (Stream game in liveChannels)
            {
                lb_channelList.Items.Add(game.channel.name + " - " + game.viewers + " viewers");
            }
        }

        private void lb_channelList_SelectedIndexChanged(object sender, EventArgs e)
        {
            Stream stream = liveChannels[lb_channelList.SelectedIndex];

            string status = "";
            if (stream.channel.status.Length > 40)
            {
                status = (stream.channel.status).Substring(0, 40) + "...";
            }
            else
            {
                status = stream.channel.status;
            }

            label_info.Text = "Name: " + stream.channel.display_name +
                "\n" + "Description: " + status +
                "\n" + "Viewers: " + stream.viewers +
                "\n" + "Average FPS: " + stream.average_fps + " fps" +
                "\n" + "Language: " + stream.channel.language +
                "\n" + 
                "\n" + "Followers: " + stream.channel.followers +
                "\n" + "Total Views: " + stream.channel.views;

        }



        private void button1_Click(object sender, EventArgs e)
        {
            string toFormat = ((string)lb_channelList.SelectedItem);
            string url = toFormat.Substring(0, toFormat.LastIndexOf("-"));
            RadioButton checkedButton = qualityPanel.Controls.OfType<RadioButton>()
                                      .FirstOrDefault(r => r.Checked);
            startStream(url, checkedButton.Name);
        }

        private static void cleanlistbox(ListBox lb)
        {
            lb.Items.Clear();
        }

        private static void startStream(string name, string quality)
        {

            Process process = new Process();
            ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
            startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
            startInfo.FileName = "cmd.exe";
            startInfo.Arguments = "/C livestreamer http://www.twitch.tv/" + name + quality;

            process.StartInfo = startInfo;

            process.Start();
            process.WaitForExit();
        }
    }
}
