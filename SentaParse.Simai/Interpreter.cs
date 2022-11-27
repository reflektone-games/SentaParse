using System.Collections.Generic;
using SentaParse.Core.Chart;

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
		public static MaiChart Read(string simaiChart)
		{
			var scanner = new Scanner(simaiChart);
			var tokens =  scanner.ScanTokens();
			
			var parser = new Parser(tokens);
			return parser.Parse();
		}
	}
}