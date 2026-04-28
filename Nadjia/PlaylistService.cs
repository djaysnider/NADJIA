using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nadjia
{
    public static class PlaylistService
    {
        public static LinkedList<PlaylistItem> CreateBasicPlaylist(List<TrackInfo> tracks)
        {
            var playlist = new LinkedList<PlaylistItem>();

            foreach (var track in tracks)
            {
                playlist.AddLast(new PlaylistItem
                {
                    ItemType = PlaylistItemType.Track,
                    Track = track,
                    Title = track.Artist + " - " + track.Title,
                    FilePath = track.FilePath
                });
            }

            return playlist;
        }
    }
}
