using SentaParse.Simai;

var chart = Interpreter.Read(await File.ReadAllTextAsync("./maidata.txt"));
Console.ReadKey();
