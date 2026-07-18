
using main.Models;
using System.Collections.Specialized;

namespace main.Services
{
    public class Settings
    {
        User user = new User();
        public Settings(User users)
        {
            user = users;
        }

        private ConsoleColor currentColor = ConsoleColor.White;
        public void DisplaySettings()
        {
            Console.WriteLine("[1] Change Color \t \t [2] Return");
            string input = Console.ReadLine() ?? string.Empty;
            if (input == "1")
            {
                changeColor(ChooseColor());
            }
        }

        public string  ChooseColor()
        {
            foreach(var color in Enum.GetNames(typeof(ConsoleColor)))
            {
                ConsoleColor currentColor = (ConsoleColor)Enum.Parse(typeof(ConsoleColor), color , true);
                Console.ForegroundColor = currentColor;
                Console.WriteLine(color);
            }
            Console.Write("Please write Color Name: ");
            while (true)
            {
                string colorName = Console.ReadLine() ?? string.Empty;
                if (colorName == string.Empty)
                {
                    Console.Write("Wrong Input Try Again : ");
                }
                else
                {
                    return colorName;
                }
            }
        }

        public void changeColor(string colorName) {
            try
            {
                ConsoleColor SelectedColor =(ConsoleColor) Enum.Parse(typeof(ConsoleColor), colorName, true);
                Console.ForegroundColor = SelectedColor;
                user.SelectedColor = SelectedColor;    
            }
            catch (Exception ex) {
                Console.WriteLine($"Wrong Input !!! : {ex.Message}");
            }
        }
    }
}
