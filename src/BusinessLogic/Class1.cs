namespace BusinessLogic;

public class DataProcessor
{
    // Simple logic to format a message
    public string GetGreeting(string user) => 
        $"[.NET 10 System] Hello {user}, your environment is ready.";
}
