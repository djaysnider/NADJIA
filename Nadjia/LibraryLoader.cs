using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Linq;

namespace Nadjia
{
    

    public static class LibraryLoader
    {
        public static List<TrackInfo> LoadLibrary(string xmlPath)
        {
            var tracks = new List<TrackInfo>();

            if (!File.Exists(xmlPath))
                return tracks;

            XDocument doc = XDocument.Load(xmlPath);

            tracks = doc.Root
                .Elements("Track")
                .Select(x => new TrackInfo
                {
                    Index = SafeInt(x.Element("Index")),
                    Artist = SafeString(x.Element("Artist")),
                    Title = SafeString(x.Element("Title")),
                    Album = SafeString(x.Element("Album")),
                    Year = SafeString(x.Element("Year")),
                    Genre = SafeString(x.Element("Genre")),
                    FilePath = SafeString(x.Element("FilePath"))
                })
                .Where(t => !string.IsNullOrWhiteSpace(t.FilePath))
                .ToList();

            return tracks;
        }

        private static string SafeString(XElement element)
        {
            return element == null ? "" : element.Value;
        }

        private static int SafeInt(XElement element)
        {
            int value;

            if (element == null)
                return 0;

            return int.TryParse(element.Value, out value) ? value : 0;
        }
    }
}
