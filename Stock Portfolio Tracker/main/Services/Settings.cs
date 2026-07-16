
using main.Models;

namespace main.Services
{
    public class Settings
    {
        public List<User> user;
        public Settings(List<User> users)
        {
            user = users;
        }

        private ConsoleColor currentColor = ConsoleColor.White;
        public void DisplaySettings()
        {
            Console.WriteLine("[1] Change Color \t \t [2] Return");
            string input = Console.ReadLine();
            if (input == "1")
            {
                changeColor(ChooseColor());
            }
        }

        public string  ChooseColor()
        {
            foreach(var color in Enum.GetNames(typeof(ConsoleColor)))
            {
                Console.WriteLine(color);
            }

            Console.Write("Please write Color Name: ");
            string colorName = Console.ReadLine();
            return colorName;
        }

        public void changeColor(string colorName) {
            try
            {
                ConsoleColor SelectedColor =(ConsoleColor) Enum.Parse(typeof(ConsoleColor), colorName, true);
                Console.ForegroundColor = SelectedColor;
                user[Accounts.currentAccount].SelectedColor = SelectedColor;
                
            }
            catch (Exception ex) {
                Console.WriteLine($"Wrong Input !!! : {ex.Message}");
            }
        }
    }
}
