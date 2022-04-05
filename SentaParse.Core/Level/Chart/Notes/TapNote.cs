using System;
using System.Collections.Generic;
using System.Linq;

namespace SentaParse.Core.Level.Chart.Notes
{
    [Serializable]
    public class TapNote : Note
    {
        public int ButtonId;
            
        public bool IsStar;
        public bool ForceInvalidate;
        public List<MaiChart.SlidePath> SlidePaths = new();

        public TapNote(string notation, int buttonId)
            : base(notation)
        {
            this.ButtonId = buttonId;
        }

        public override float GetVisibleDuration()
        {
            var baseValue = Length;

            if (SlidePaths.Count > 0)
                baseValue += SlidePaths.Max(s => s.Length);

            return baseValue;
        }
    }
}