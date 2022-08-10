namespace SentaParse.Core.Chart.Notes
{
    public class TouchNoteBase : NoteBase
    {
        public bool InvokesFirework;
        
        public readonly char GroupId;
        public readonly int SerialId;

        public TouchNoteBase(char groupId, int serialId)
        {
            GroupId = groupId;
            SerialId = serialId;
        }
    }
}