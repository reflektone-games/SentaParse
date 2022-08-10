using SentaParse.Simai;

var tokens = Interpreter.Read(Console.ReadLine() ?? string.Empty);

foreach (var token in tokens)
{
	Console.WriteLine(token);
}