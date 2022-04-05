namespace SentaParse.Core.Level.Chart.Notes
{
    public class TouchNote : Note
    {
        public readonly char GroupId;
        public readonly int SerialId;
            
        public bool Firework;

        public TouchNote(string notation,
            char groupId,
            int serialId)
            : base(notation)
        {
            this.GroupId = groupId;
            this.SerialId = serialId;
        }
    }
}