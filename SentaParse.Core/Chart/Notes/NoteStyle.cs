namespace SentaParse.Core.Chart.Notes
{
	/// <summary>
	/// The display style of this note. (Normal / Star)
	/// </summary>
	public enum NoteStyle
	{
		/// <summary>
		/// Determines the style for this note based on the slide paths.
		/// </summary>
		Auto = 0,
        
		/// <summary>
		/// Labelled all notes in this collection as normal.
		/// </summary>
		ForceNormal,
        
		/// <summary>
		/// Labels all notes in this collection as each.
		/// </summary>
		ForceStar
	}
}