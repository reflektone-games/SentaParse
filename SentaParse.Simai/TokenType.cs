namespace SentaParse.Simai
{
	public enum TokenType
	{
		// Single-character tokens.
		Comma,
		
		// Modifiers
		Hold,
		Break,
		Firework,
		Ex,

		// Literals.
		Tempo,
		Signature,
		Button,
		Touch,
		SlidePath,

		EndOfFile
	}
}