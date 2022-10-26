using System;
using System.Collections.Generic;
using System.Threading;
using System.Drawing;
Console.WriteLine("Переключение по октавам с помощью f3,f4,f5,f6");
while (true)
{
    ConsoleKeyInfo clav = Console.ReadKey();
    if (clav.Key == ConsoleKey.F3)
    {
        while (clav.Key != ConsoleKey.F4 && clav.Key != ConsoleKey.F5 && clav.Key != ConsoleKey.F6)
        {
            Console.WriteLine("Третья октава");
            ConsoleKeyInfo polz = Console.ReadKey();
            if (polz.Key == ConsoleKey.Q)
            {
                Console.Beep(130, 1000);
            }
            
        }
    }
}