using System.Collections.Generic;

namespace SentaParse.Core
{
    public class TrackData
    {
        public string? Title;
        public string? Artist;
        
        // wholebpm in 3simai
        public string? DisplayTempo;

        /// <summary>
        ///     This field will be the fallback offset
        /// </summary>
        public float Offset;

        public List<DifficultyData> Difficulties = new();
    }
}