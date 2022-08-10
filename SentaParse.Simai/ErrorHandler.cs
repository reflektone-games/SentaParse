namespace SentaParse.Simai
{
	public static class ErrorHandler
	{
		public static void Report(int line, string location, string message)
		{
			throw new SimaiException(line, location, message);
		}
	}
}