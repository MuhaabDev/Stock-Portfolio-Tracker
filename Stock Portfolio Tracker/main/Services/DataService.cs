using System.Text.Json;
using main.Models;
namespace main.Services;

public class DataService
{
    private const string FilePath =
        @"C:\Users\MOHAB\Desktop\Projects\Stock Portfolio Tracker\Stock Portfolio Tracker\main\Data\users.json";
    public void SaveUsers(List<User> users)
    {
        if (!Directory.Exists("Data"))
        {
            Directory.CreateDirectory("Data");
        }

        var options = new JsonSerializerOptions
        {
            WriteIndented = true
        };

        string json = JsonSerializer.Serialize(users, options);
        File.WriteAllText(FilePath, json);
        // Console.WriteLine($"Saved at: {Path.GetFullPath(FilePath)}");
    }


    public List<User> LoadUsers()
    {
        if (!File.Exists(FilePath))
        {
            return new List<User>();
        }
        string json = File.ReadAllText(FilePath);
        List<User> users = JsonSerializer.Deserialize<List<User>>(json);
        return users ?? new List<User>();
    }
}
