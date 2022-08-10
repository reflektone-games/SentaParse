using System.Collections.Generic;
using SentaParse.Core.Chart.Collection;

namespace SentaParse.Core.Chart
{
    public class MaiChart
    {
        public float? EndTiming;
        
        public List<TempoChange> TempoChanges = new();
        public List<SignatureChange> SignatureChanges = new();

        public List<NoteCollection> NoteCollections = new();
    }
}