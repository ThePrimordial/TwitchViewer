using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwitchViewerLib
{
    public static class TwichViewerExtensions
    {
        /// <summary>
        /// Copy constructor
        /// </summary>
        /// <param name="top"></param>
        /// <returns></returns>
        public static Top Copy(this Top top)
        {
            return new Top
            {
                channels = top.channels,
                game = top.game,
                viewers = top.viewers
            };
        }
    }
}
