namespace SentaParse.Core.Level.Chart
{
    public struct TempoChange
    {
        public float Time;
        public float Tempo;

        public TempoChange(float time, float tempo)
        {
            Time = time;
            Tempo = tempo;
        }
    }
}