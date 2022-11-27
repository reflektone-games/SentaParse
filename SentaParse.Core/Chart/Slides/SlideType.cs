namespace SentaParse.Core.Chart.Slides
{
    /// <summary>
    /// Describes the path of a slide
    /// </summary>
    public enum SlideType
    {
        /// <summary>
        /// Goes from point A to point B linearly.
        /// </summary>
        Line,
        
        /// <summary>
        /// Goes from point A to the center to point B
        /// </summary>
        Fold,
        
        /// <summary>
        /// Goes from point A to point B to point C
        /// </summary>
        EdgeFold,
        
        ZigZagS,
        ZigZagZ,
        
        /// <summary>
        /// Curves on the ring clockwise from point A to point B.
        /// </summary>
        RingClockwise,
        
        /// <summary>
        /// Curves on the ring counter-clockwise from point A to point B.
        /// </summary>
        RingCounterClockwise,

        /// <summary>
        /// Goes from point A to the inner ring, wraps clockwise, and tangents into point B.
        /// </summary>
        CurveClockwise,
        
        /// <summary>
        /// Goes from point A to the inner ring, wraps counter-clockwise, and tangents into point B.
        /// </summary>
        CurveCounterClockwise,
        
        EdgeCurveClockwise,
        EdgeCurveCounterClockwise,

        Wifi,
        AutoRing
    }
}