using System.Collections.Generic;
using SentaParse.Core.Chart;

namespace SentaParse.Simai
{
	public class Parser
	{
		private List<Token> _tokens;
		
		public Parser(List<Token> tokens)
		{
			_tokens = tokens;
		}

		public MaiChart Parse()
		{
			return new MaiChart();
		}
	}
}