using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using System.Web;

namespace TwitchViewer
{
    class TwitchImp
    {

        public static List<Stream> generateStreamsFromSearch(string name)
        {
            dynamic res = getResponseFromUrl("https://api.twitch.tv/kraken/search/streams?q=" + name);
            StreamsJSON streams = JsonConvert.DeserializeObject<StreamsJSON>(res);

            List<Stream> liveChannels = new List<Stream>();

            foreach (Stream stream in streams.streams)
            {
                liveChannels.Add(stream);
            }

            return liveChannels;
        }
        

        public static List<Stream> generateStreams(string gameName)
        {
            dynamic res = getResponseFromUrl("https://api.twitch.tv/kraken/streams?game=" + HttpUtility.UrlEncode(gameName) + "&limit=100");
            StreamsJSON streams = JsonConvert.DeserializeObject<StreamsJSON>(res);

            List<Stream> liveChannels = new List<Stream>();

            foreach (Stream stream in streams.streams)
            {
                liveChannels.Add(stream);
            }

            return liveChannels;
        }

        public static List<Top> generateTopGames()
        {
            //Todo enum
            dynamic res = getResponseFromUrl("https://api.twitch.tv/kraken/games/top?limit=100");
            TopGamesJSON topgames = JsonConvert.DeserializeObject<TopGamesJSON>(res);

            List<Top> topGameList = new List<Top>();
            foreach (Top top in topgames.top)
            {
                topGameList.Add(top);
            }

            return topGameList;

        }

        private static dynamic getResponseFromUrl(string url)
        {

            HttpWebRequest wRequest = (HttpWebRequest)HttpWebRequest.Create(url);
            wRequest.ContentType = "application/json";
            wRequest.Accept = "application/vnd.twitchtv.v3+json";
            wRequest.Method = "GET";

            dynamic wResponse = wRequest.GetResponse().GetResponseStream();
            StreamReader reader = new StreamReader(wResponse);
            dynamic res = reader.ReadToEnd();
            reader.Close();
            wResponse.Close();
            return res;
        }
    }
}
