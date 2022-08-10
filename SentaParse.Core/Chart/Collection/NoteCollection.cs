using System.Collections.Generic;
using SentaParse.Core.Chart.Notes;
using SentaParse.Core.Chart.Slides;

namespace SentaParse.Core.Chart.Collection
{
    public sealed class NoteCollection
    {
        public readonly List<NoteBase> Notes = new();
        public readonly List<SlidePath> Slides = new();

        public EachOverride EachOverride;
        
        public readonly float Subdivisions;
        public readonly float Tempo;
        public readonly float Time;

        public NoteCollection(float time,
            float tempo,
            float subdivisions)
        {
            Time = time;
            Tempo = tempo;
            Subdivisions = subdivisions;
        }
    }
}