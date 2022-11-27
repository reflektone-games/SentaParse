namespace SentaParse.Simai
{
	public enum TokenType
	{
		/// <summary>
		/// Progresses time
		/// </summary>
		StepTime,
		
		/// <summary>
		/// Separates notes
		/// </summary>
		Separator,

		// Modifiers
		Hold,
		Break,
		Ex,
		Firework,

		// Literals.
		Tempo,
		Signature,
		Button,
		Touch,
		SlidePath,

		EndOfFile
	}
}