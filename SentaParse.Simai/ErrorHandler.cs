namespace SentaParse.Simai
{
	public static class ErrorHandler
	{
		public static void Report(int line, int character, string location, string message)
		{
			throw new SimaiException(line, character, location, message);
		}
	}
}