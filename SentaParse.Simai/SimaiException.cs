using System;

namespace SentaParse.Simai
{
	[Serializable]
	internal class SimaiException : Exception
	{
		public SimaiException(int line, int character, string location, string message)
			: base($"Error: {message} at {location} ({line}, {character})")
		{ }
	}
}