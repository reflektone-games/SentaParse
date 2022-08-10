using System;
using System.Collections.Generic;

namespace SentaParse.Core.Chart.Slides
{
	[Serializable]
	public class SlidePath
	{
		public SlideType SlideType;
		public SlideStyle SlideStyle;
		
		public List<int> TargetButtons;

		public float IntroDuration;
		public float Length;

		public SlidePath(SlideType slideType,
			List<int> targetButtons,
			float introDuration,
			float length)
		{
			SlideType = slideType;
			TargetButtons = targetButtons;
			IntroDuration = introDuration;
			Length = length;
		}
	}
}