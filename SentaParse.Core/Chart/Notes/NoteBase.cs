using System;

namespace SentaParse.Core.Chart.Notes
{
    [Serializable]
    public abstract class NoteBase
    {
        public float? Length;
        public bool IsBreak;
        public bool IsEx;
    }
}