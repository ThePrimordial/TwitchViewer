using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using TwitchViewer_WPF.ViewModel;
using TwitchViewerLib;

namespace TwitchViewer_WPF
{
    /// <summary>
    /// Interaction logic for StreamWindow.xaml
    /// </summary>
    public partial class StreamWindow : Window
    {
        private StreamWindowViewModel _defaultVM;
        public StreamWindowViewModel DefaultVM
        {
            get
            {
                return _defaultVM;
            }
        }
        public StreamWindow(Stream stream = null)
        {
            InitializeComponent();

            _defaultVM = new StreamWindowViewModel(stream.channel.display_name, stream.viewers, "Source", stream.preview.large);
            this.DataContext = _defaultVM;

            this.Title = string.Format("Channel - {0}", _defaultVM.HeaderText);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ProcessStartInfo startInfo = new ProcessStartInfo("cmd", "/C livestreamer http://www.twitch.tv/" + _defaultVM.HeaderText + " " + _defaultVM.Quality);
            startInfo.WindowStyle = ProcessWindowStyle.Hidden;
            Process.Start(startInfo);
            this.Close();
        }
    }
}
