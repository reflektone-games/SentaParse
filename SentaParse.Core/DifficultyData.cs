namespace SentaParse.Core
{
    public class DifficultyData
    {
        public readonly int Id;
        public string RawChart;
            
        public string Alias;
        public string Level;

        /// <summary>
        ///     first
        /// </summary>
        public float Offset;

        public DifficultyData(int id, string rawChart, string level)
        {
            Id = id;
            RawChart = rawChart;
            Level = level;

            Alias = Id switch
            {
                1 => "Easy",
                2 => "Basic",
                3 => "Advanced",
                4 => "Expert",
                5 => "Master",
                6 => "Re:Master",
                7 => "宴",
                _ => "Unnamed"
            };
        }
    }
}