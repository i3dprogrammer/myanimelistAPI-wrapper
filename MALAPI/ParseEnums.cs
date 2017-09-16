using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MALAPI
{
    public class ParseEnums //TODO: Actually use the god damn enums.
    {
        public enum RetrieveType
        {
            Anime,
            Manga,
        }

        public enum MyAnimeStatus
        {
            Watching = 1,
            Completed,
            Onhold,
            Dropped,
            PlatToWatch = 6,
        }
        
        public enum AnimeStatus
        {
            Unknown,
            FinishedAiring,
            CurrentlyAiring,
            NotYetAired,
            Cancelled,
        }

        public enum AnimeType
        {
            TV,
            OVA,
            ONA,
            Movie,
            Music,
        }
    }
}
