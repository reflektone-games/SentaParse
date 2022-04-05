using System;
using System.Collections.Generic;
using SentaParse.Core.Level.Chart.Collection;
using SentaParse.Core.Level.Chart.Slides;

namespace SentaParse.Core.Level.Chart
{
    public class MaiChart
    {
        public float? FinishTiming;
        
        public List<TempoChange> TempoChanges = new();
        public List<SignatureChange> SignatureChanges = new();

        public List<NoteCollection> NoteCollections = new();

        [Serializable]
        public class SlidePath
        {
            public SlideType SlideType;
            public List<int> TargetButtons;

            public float IntroDuration;
            public float Length;

            public SlideMorph SlideMorph;

            public SlidePath(SlideType slideType,
                List<int> targetButtons,
                float introDuration,
                float length)
            {
                this.SlideType = slideType;
                this.TargetButtons = targetButtons;
                this.IntroDuration = introDuration;
                this.Length = length;
            }
        }
    }
}