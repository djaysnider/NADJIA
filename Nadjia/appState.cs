using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nadjia
{
    public static class AppState
    {
        public static List<TrackInfo> MusicLibrary { get; set; } = new List<TrackInfo>();
    }
}
