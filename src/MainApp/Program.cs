using BusinessLogic;

var processor = new DataProcessor();

Console.Write("Enter Username: ");
string name = Console.ReadLine() ?? "Developer";

string message = processor.GetGreeting(name);
Console.WriteLine(message);
