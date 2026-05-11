using System;

namespace Nadjia
{
    public enum PlaylistItemType
    {
        Track,
        StationId,
        Bumper,
        SoundEffect
    }

    public class PlaylistItem
    {
        public PlaylistItemType ItemType { get; set; }

        // For music tracks
        public TrackInfo Track { get; set; }

        // Display-friendly title
        public string Title { get; set; }

        // File path (used for playback)
        public string FilePath { get; set; }

        // Optional sequence number
        public int Sequence { get; set; }

        public string DisplayText
        {
            get
            {
                if (Track != null)
                {
                    string artist = string.IsNullOrWhiteSpace(Track.Artist) ? "Unknown Artist" : Track.Artist;
                    string album = string.IsNullOrWhiteSpace(Track.Album) ? "Unknown Album" : Track.Album;

                    return $"{Title} ({artist} / {album})";
                }

                return Title;
            }
        }
    }
}