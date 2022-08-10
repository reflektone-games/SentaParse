using System;

namespace SentaParse.Simai
{
	[Serializable]
	internal class SimaiException : Exception
	{
		public SimaiException(int line, string location, string message)
			: base($"[Line {line}] Error: {message}\n{location}")
		{ }
	}
}