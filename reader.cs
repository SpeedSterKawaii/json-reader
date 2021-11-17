class Program
{
    static void Main()
    {
        Item item = JsonFileReader.Read<Item>(@"C:\myFile.json");
    }
}

public static class JsonFileReader
{
    public static T Read<T>(string filePath)
    {
        string text = File.ReadAllText(filePath);
        return JsonSerializer.Deserialize<T>(text);
    }
}
// NEEDS JSON FILE/LIBRARY!
