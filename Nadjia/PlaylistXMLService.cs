using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml.Linq;

namespace Nadjia
{
    public static class PlaylistXmlService
    {
        public static void SavePlaylist(
            string outputPath,
            string playlistName,
            List<TrackInfo> tracks)
        {
            if (tracks == null)
                tracks = new List<TrackInfo>();

            XDocument document = new XDocument(
                new XDeclaration("1.0", "utf-8", "yes"),
                new XElement("Playlist",
                    new XAttribute("Name", playlistName),
                    new XAttribute("Created", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")),
                    new XElement("Tracks",
                        tracks.Select((track, index) =>
                            new XElement("Track",
                                new XElement("Sequence", index + 1),
                                new XElement("Artist", CleanXmlText(track.Artist)),
                                new XElement("Title", CleanXmlText(track.Title)),
                                new XElement("Album", CleanXmlText(track.Album)),
                                new XElement("Year", CleanXmlText(track.Year)),
                                new XElement("Genre", CleanXmlText(track.Genre)),
                                new XElement("FilePath", CleanXmlText(track.FilePath))
                            )
                        )
                    )
                )
            );

            document.Save(outputPath);
        }

        private static string CleanXmlText(string value)
        {
            if (string.IsNullOrEmpty(value))
                return "";

            return new string(value
                .Where(ch =>
                    ch == 0x9 ||
                    ch == 0xA ||
                    ch == 0xD ||
                    (ch >= 0x20 && ch <= 0xD7FF) ||
                    (ch >= 0xE000 && ch <= 0xFFFD))
                .ToArray());
        }
    }
}