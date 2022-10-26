namespace ежедневник
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int position = 1;
            Menu();
            while (true)
            {
                ConsoleKeyInfo key = Console.ReadKey();
                if (key .Key == ConsoleKey.UpArrow)
                {
                    position--;
                }
                else if (key.Key == ConsoleKey.DownArrow)
                {
                    position++;
                }
                Console.Clear();
                Menu();
                Console.SetCursorPosition(0, position);
                Console.WriteLine("->");
            }
            static void Menu()
            {
                Console.WriteLine("  Выберите дату:");
                Console.WriteLine("  01.02.2022");
                 Console.WriteLine("  02.02.2022");
                    Console.WriteLine("  03.03.2022");
                        Console.WriteLine("  04.03.2022");
                        Console.WriteLine("  05.03.2022");
            }
        }
    }
}