using System.Collections.Generic;

namespace SentaParse.Simai
{
	public static class Interpreter
	{
		/// <summary>
		/// Compiles serialized data into a 3simai file.
		/// </summary>
		public static void Compile()
		{
			
		}
		
		/// <summary>
		/// Interprets a 3simai file as serialized data.
		/// </summary>
		public static List<Token> Read(string simaiChart)
		{
			var scanner = new Scanner(simaiChart);
			return scanner.ScanTokens();
		}
	}
}