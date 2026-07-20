using main.Models;
using main.Services;

namespace main.UI;
public class App
{
    public void Run()
    {
        DataService dataService = new DataService();
        List<User> users = dataService.LoadUsers();
        MainMenu MainMenu = new MainMenu();
        MainMenu.StartProgram(users , dataService);
    }
}
