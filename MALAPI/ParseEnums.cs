using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MALAPI
{
    public class ParseEnums
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
