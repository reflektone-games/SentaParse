using System;
using System.Collections.Generic;
using SentaParse.Core.Chart.Slides;

namespace SentaParse.Core.Chart.Notes
{
    [Serializable]
    public class TapNoteBase : NoteBase
    {
        public byte Button;
        
        public List<SlidePath> SlidePaths = new();
        public NoteStyle NoteStyle;

        public TapNoteBase(byte button) => Button = button;
    }
}