
namespace main.Services
{
    public static class Settings
    {
        public static void DisplaySettings()
        {
            Console.WriteLine("[1] Change Color \t \t [2] Return");
            string input = Console.ReadLine();
            if (input == "1")
            {
                changeColor(ChooseColor());
            }
        }

        public static string  ChooseColor()
        {
            foreach(var color in Enum.GetNames(typeof(ConsoleColor)))
            {
                Console.WriteLine(color);
            }

            Console.Write("Please write Color Name: ");
            string colorName = Console.ReadLine();
            return colorName;
        }

        public static void changeColor(string colorName) {
            try
            {
                ConsoleColor SelectedColor =(ConsoleColor) Enum.Parse(typeof(ConsoleColor), colorName, true);
                Console.ForegroundColor = SelectedColor;
            }
            catch (Exception ex) {
                Console.WriteLine($"Wrong Input !!! : {ex.Message}");
            }
        }
    }
}
