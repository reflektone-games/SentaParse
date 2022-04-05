using System;
using SentaParse.Core.Level.Chart.Collection;

namespace SentaParse.Core.Level.Chart.Notes
{
    [Serializable]
    public class Note
    {
        [NonSerialized] public NoteCollection ParentCollection = null!;
            
        public readonly string Notation;
            
        public bool IsHold;
        public float Length;

        public bool IsBreak;
        public bool IsEx;


        public Note(string notation) => this.Notation = notation;

        public virtual float GetVisibleDuration() => Length;

        public bool Is<T>() where T: Note => GetType() == typeof(T);
        public T? As<T>() where T: Note => this as T;
    }
}