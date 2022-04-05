namespace SentaParse.Core.Level.Chart
{
    public struct SignatureChange
    {
        public float Subdivisions;
        public float Time;
        public float BeatLength;
        public bool IsSpecifiedInSeconds;

        public SignatureChange(float subdivisions, float time, float beatLength, bool isSpecifiedInSeconds)
        {
            Subdivisions = subdivisions;
            Time = time;
            BeatLength = beatLength;
            IsSpecifiedInSeconds = isSpecifiedInSeconds;
        }
    }
}