using System.Collections.Generic;

namespace SentaParse.Simai
{
	public class Scanner
	{
		private readonly string _source;
		private readonly List<Token> _tokens = new();

		private int _start;
		private int _current;
		private int _line = 1;

		public Scanner(string source)
		{
			_source = source;
		}

		public List<Token> ScanTokens()
		{
			while (!IsAtEnd)
			{
				_start = _current;
				ScanToken();
			}

			_tokens.Add(new Token(TokenType.EndOfFile, ",", null, _line));
			return _tokens;
		}

		private void ScanToken()
		{
			var c = Advance();
			switch (c)
			{
				case '(':
					Tempo();
					break;
				case '{':
					Signature();
					break;

				case ',':
					AddToken(TokenType.Comma);
					break;

				case ' ':
				case '\r':
				case '\t':
					// Ignore whitespace.
					break;

				case '\n':
					_line++;
					break;

				case 'f':
					AddToken(TokenType.Firework);
					break;

				case 'b':
					AddToken(TokenType.Break);
					break;
				
				case 'x':
					AddToken(TokenType.Ex);
					break;

				case 'h':
					Hold();
					break;

				case var _ when IsAlpha(c):
					TouchPanel();
					break;
				case var _ when IsDigit(c):
					Button();
					break;

				default:
					ErrorHandler.Report(_line, c.ToString(), "Unexpected character.");
					break;
			}
		}

		private void Hold()
		{
			if (Peek() != '[')
			{
				AddToken(TokenType.Hold);
				return;
			}

			while (Peek() is not (':' or ']'))
			{
				if (IsAtEnd)
				{
					ErrorHandler.Report(_line, _source[(_start + 1)..(_current - 1)], "Unterminated hold duration.");
					return;
				}

				Advance();
			}

			// : or ]
			Advance();

			var text = _source[(_start + 2)..(_current - 1)];

			// No colon found
			if (PeekPrevious() is ']')
			{
				if (text[0] != '#')
				{
					ErrorHandler.Report(_line, text, "Unexpected hold duration syntax. (Did you intend to add a '#'?)");
					return;
				}

				text = text.Remove(0, 1);

				if (float.TryParse(text, out var value))
					AddToken(TokenType.Hold, new { UseSecondTiming = true, Value = value });
				else
					ErrorHandler.Report(_line, text, "Invalid hold duration syntax. (Expected a number)");

				return;
			}

			// Colon found
			var colonIndex = _current - 1;
			while (Peek() is not ']')
			{
				if (IsAtEnd)
				{
					ErrorHandler.Report(_line, _source[(_start + 1)..(_current - 1)], "Unterminated hold duration.");
					return;
				}

				Advance();
			}

			// The ]
			Advance();

			// Trim the surrounding quotes.
			var beatCountText = _source[(colonIndex + 1)..(_current - 1)];

			if (float.TryParse(text, out var timeSignature) && float.TryParse(beatCountText, out var beatCount))
			{
				AddToken(TokenType.Hold,
					new
					{
						UseSecondTiming = false, Value = new { TimeSignature = timeSignature, BeatCount = beatCount }
					});
			}
			else
			{
				ErrorHandler.Report(_line, _source[(_start + 1)..(_current - 1)], "Invalid hold duration syntax. (Expected [number:number])");
			}
		}

		private void TouchPanel()
		{
			if (PeekPrevious() is not (>= 'a' and <= 'e' or >= 'A' and <= 'E'))
			{
				ErrorHandler.Report(_line, PeekPrevious().ToString(),
					"Invalid touch panel group. (Expected a ~ e or A ~ E)");
				return;
			}

			if (IsDigit(Peek())) Advance();

			AddToken(TokenType.Touch, _source[_start.._current]);
		}

		private void Button()
		{
			// convert c to number
			var number = PeekPrevious() - '0';

			if (number is > 8 or < 1)
			{
				ErrorHandler.Report(_line, number.ToString(), "Invalid button number. (Expected 1 ~ 8)");
				return;
			}

			AddToken(TokenType.Button, number);
		}

		private void Tempo()
		{
			while (Peek() != ')')
			{
				if (IsAtEnd)
				{
					ErrorHandler.Report(_line, _source[(_start + 1)..(_current - 1)], "Unterminated tempo.");
					return;
				}

				Advance();
			}

			// The closing ).
			Advance();

			// Trim the surrounding quotes.
			var value = _source[(_start + 1)..(_current - 1)];
			AddToken(TokenType.Tempo, value);
		}

		private void Signature()
		{
			while (Peek() != '}')
			{
				if (IsAtEnd)
				{
					ErrorHandler.Report(_line, _source[(_start + 1)..(_current - 1)],
						"Unterminated time signature.");
					return;
				}

				Advance();
			}

			// The closing }.
			Advance();

			// Trim the surrounding quotes.
			var value = _source[(_start + 1)..(_current - 1)];
			AddToken(TokenType.Signature, value);
		}


		private void AddToken(TokenType type, object? literal = null)
		{
			var text = _source[_start.._current];
			_tokens.Add(new Token(type, text, literal, _line));
		}


		private char Advance() => _source[_current++];

		private char Peek() => IsAtEnd ? '\0' : _source[_current];

		private char PeekNext() => _current + 1 >= _source.Length ? '\0' : _source[_current + 1];

		private char PeekPrevious() => _current == 0 ? '\0' : _source[_current - 1];

		private static bool IsDigit(char c) => c is >= '0' and <= '9';
		private static bool IsAlpha(char c) => c is >= 'a' and <= 'z' or >= 'A' and <= 'Z';

		private bool IsAtEnd => _current >= _source.Length;
	}
}