using System.Collections.Generic;
using SentaParse.Core.Level.Chart.Notes;

namespace SentaParse.Core.Level.Chart.Collection
{
    public class NoteCollection : List<Note>
    {
        public readonly float BeatLength;
        public readonly string RawContent;
        public readonly float Subdivisions;
        public readonly float Tempo;
        public readonly float Time;
            
        public EachOverride EachOverride;

        public NoteCollection(string rawContent,
            float time,
            float tempo,
            float subdivisions)
        {
            RawContent = rawContent;
            Time = time;
            Tempo = tempo;
            Subdivisions = subdivisions;

            BeatLength = 60f / tempo / (subdivisions / 4);
        }

        public float GetDuration(float sign = 4,
            float repeatCount = 1)
        {
            if (repeatCount == 0 || sign == 0)
                return 0;

            //The duration of a beat
            var spb = 60f / Tempo;

            //4 * signature == 1 * beat
            //How long one signature is (in beats)
            var normalizedSignature = sign / 4;

            return spb / normalizedSignature * repeatCount;
        }

        public new void Add(Note n)
        {
            n.ParentCollection = this;
            base.Add(n);
        }
    }
}