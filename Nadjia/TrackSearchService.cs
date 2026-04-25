using System;
using System.Collections.Generic;
using System.Linq;

namespace Nadjia
{
    // Defines which field we are searching against
    public enum TrackSearchField
    {
        All,
        Artist,
        Title,
        Album,
        Genre,
        Year   // ← NEW
    }

    public static class TrackSearchService
    {
        /// <summary>
        /// Main search entry point.
        /// Filters the library based on search text and selected field.
        /// </summary>
        public static List<TrackInfo> Search(
            IEnumerable<TrackInfo> library,
            string searchText,
            TrackSearchField searchField)
        {
            // Safety check
            if (library == null)
                return new List<TrackInfo>();

            // If no search text, return entire library
            if (string.IsNullOrWhiteSpace(searchText))
                return library.ToList();

            searchText = searchText.Trim();

            // Filter + sort results
            return library
                .Where(track => Matches(track, searchText, searchField))
                .OrderBy(track => track.Artist)
                .ThenBy(track => track.Album)
                .ThenBy(track => track.Title)
                .ToList();
        }

        /// <summary>
        /// Determines whether a track matches the search criteria
        /// </summary>
        private static bool Matches(
            TrackInfo track,
            string searchText,
            TrackSearchField searchField)
        {
            if (track == null)
                return false;

            switch (searchField)
            {
                case TrackSearchField.Artist:
                    return Contains(track.Artist, searchText);

                case TrackSearchField.Title:
                    return Contains(track.Title, searchText);

                case TrackSearchField.Album:
                    return Contains(track.Album, searchText);

                case TrackSearchField.Genre:
                    return Contains(track.Genre, searchText);

                case TrackSearchField.Year:
                    return Contains(track.Year, searchText);

                case TrackSearchField.All:
                default:
                    return Contains(track.Artist, searchText)
                        || Contains(track.Title, searchText)
                        || Contains(track.Album, searchText)
                        || Contains(track.Genre, searchText)
                        || Contains(track.Year, searchText);
            }
        }

        /// <summary>
        /// Case-insensitive string search helper
        /// </summary>
        private static bool Contains(string source, string searchText)
        {
            if (string.IsNullOrEmpty(source))
                return false;

            return source.IndexOf(searchText, StringComparison.OrdinalIgnoreCase) >= 0;
        }
    }
}