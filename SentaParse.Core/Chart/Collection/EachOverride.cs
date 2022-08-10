namespace SentaParse.Core.Chart.Collection
{
    /// <summary>
    /// Overrides the default each-determination behaviour
    /// </summary>
    public enum EachOverride
    {
        /// <summary>
        /// Uses the default behaviour on this note collection.
        /// </summary>
        None = 0,
        
        /// <summary>
        /// Labelled all notes in this collection as normal.
        /// </summary>
        Discrete,
        
        /// <summary>
        /// Labels all notes in this collection as each.
        /// </summary>
        ForceEach
    }
}