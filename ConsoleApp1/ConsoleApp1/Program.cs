using System;
using System.Collections.Generic;
using System.Threading;
using System.Drawing;
using System.ComponentModel.Design;

namespace piano
{
    internal class Program
    {


        static void Main(string[] args)
        {
            Console.WriteLine("Переключение по октавам с помощью f3,f4,f5(нажмите Escape)");
            while (true)
            {
                int[] firstOctave = new int[] { 130, 138, 146, 155, 164, 174, 185, 196, 207, 220, 233, 246 };
                ConsoleKeyInfo clav = Console.ReadKey();
                if (clav.Key == ConsoleKey.F3)
                {
                    Console.WriteLine("Третья октава");
                    firstOct(firstOctave);
                }
                int[] secondOctave = new int[] { 261, 293, 311, 329, 349, 370, 392, 415, 440, 466, 493, 493 };
                if (clav.Key == ConsoleKey.F4)
                {
                    Console.WriteLine("Четвертая октава");
                    SecondOct(secondOctave);
                }
                int[] ThOctave = new int[] { 523, 554, 587, 622, 659, 698, 740, 784, 830, 880, 932, 987 };
                if (clav.Key == ConsoleKey.F5)
                {
                    Console.WriteLine("Пятая октава");
                    ThOct(ThOctave);
                }
            }





            static void firstOct(int[] myMassive)
            {
                while (true)
                {
                    ConsoleKeyInfo polz = Console.ReadKey();
                    if (polz.Key == ConsoleKey.Q)
                    {
                        Console.Beep(myMassive[0], 500);
                    }

                    if (polz.Key == ConsoleKey.A)
                    {
                        Console.Beep(myMassive[1], 500);
                    }

                    if (polz.Key == ConsoleKey.W)
                    {
                        Console.Beep(myMassive[2], 500);
                    }
                    if (polz.Key == ConsoleKey.S)
                    {
                        Console.Beep(myMassive[3], 500);
                    }
                    if (polz.Key == ConsoleKey.E)
                    {
                        Console.Beep(myMassive[4], 500);
                    }
                    if (polz.Key == ConsoleKey.R)
                    {
                        Console.Beep(myMassive[5], 500);
                    }
                    if (polz.Key == ConsoleKey.D)
                    {
                        Console.Beep(myMassive[6], 500);
                    }
                    if (polz.Key == ConsoleKey.T)
                    {
                        Console.Beep(myMassive[7], 500);
                    }
                    if (polz.Key == ConsoleKey.G)
                    {
                        Console.Beep(myMassive[8], 500);
                    }
                    if (polz.Key == ConsoleKey.Y)
                    {
                        Console.Beep(myMassive[9], 500);
                    }
                    if (polz.Key == ConsoleKey.H)
                    {
                        Console.Beep(myMassive[10], 500);
                    }
                    if (polz.Key == ConsoleKey.U)
                    {
                        Console.Beep(myMassive[11], 500);
                    }
                    if(polz.Key == ConsoleKey.Escape)
                    {
                        break;
                    }
                }
            }

            static void SecondOct(int[] myMassive2)
            {
                while (true)
                {
                    ConsoleKeyInfo polz = Console.ReadKey();
                    if (polz.Key == ConsoleKey.Q)
                    {
                        Console.Beep(myMassive2[0], 500);
                    }

                    if (polz.Key == ConsoleKey.A)
                    {
                        Console.Beep(myMassive2[1], 500);
                    }

                    if (polz.Key == ConsoleKey.W)
                    {
                        Console.Beep(myMassive2[2], 500);
                    }
                    if (polz.Key == ConsoleKey.S)
                    {
                        Console.Beep(myMassive2[3],  500);
                    }
                    if (polz.Key == ConsoleKey.E)
                    {
                        Console.Beep(myMassive2[4], 500);
                    }
                    if (polz.Key == ConsoleKey.R)
                    {
                        Console.Beep(myMassive2[5], 500);
                    }
                    if (polz.Key == ConsoleKey.D)
                    {
                        Console.Beep(myMassive2[6], 500);
                    }
                    if (polz.Key == ConsoleKey.T)
                    {
                        Console.Beep(myMassive2[7], 500);
                    }
                    if (polz.Key == ConsoleKey.G)
                    {
                        Console.Beep(myMassive2[8], 500);
                    }
                    if (polz.Key == ConsoleKey.Y)
                    {
                        Console.Beep(myMassive2[9], 500);
                    }
                    if (polz.Key == ConsoleKey.H)
                    {
                        Console.Beep(myMassive2[10], 500);
                    }
                    if (polz.Key == ConsoleKey.U)
                    {
                        Console.Beep(myMassive2[11], 500);
                    }

                    if (polz.Key == ConsoleKey.Escape)
                    {
                        break;
                    }
                }
                Console.WriteLine();
            }

            static void ThOct(int[] myMassive3)
            {
                while (true)
                {
                    ConsoleKeyInfo polz = Console.ReadKey();
                    if (polz.Key == ConsoleKey.Q)
                    {
                        Console.Beep(myMassive3[0], 500);
                    }

                    if (polz.Key == ConsoleKey.A)
                    {
                        Console.Beep(myMassive3[1], 500);
                    }

                    if (polz.Key == ConsoleKey.W)
                    {
                        Console.Beep(myMassive3[2], 500);
                    }
                    if (polz.Key == ConsoleKey.S)
                    {
                        Console.Beep(myMassive3[3], 500);
                    }
                    if (polz.Key == ConsoleKey.E)
                    {
                        Console.Beep(myMassive3[4], 500);
                    }
                    if (polz.Key == ConsoleKey.R)
                    {
                        Console.Beep(myMassive3[5], 500);
                    }
                    if (polz.Key == ConsoleKey.D)
                    {
                        Console.Beep(myMassive3[6], 500);
                    }
                    if (polz.Key == ConsoleKey.T)
                    {
                        Console.Beep(myMassive3[7], 500);
                    }
                    if (polz.Key == ConsoleKey.G)
                    {
                        Console.Beep(myMassive3[8], 500);
                    }
                    if (polz.Key == ConsoleKey.Y)
                    {
                        Console.Beep(myMassive3[9], 500);
                    }
                    if (polz.Key == ConsoleKey.H)
                    {
                        Console.Beep(myMassive3[10], 500);
                    }
                    if (polz.Key == ConsoleKey.U)
                    {
                        Console.Beep(myMassive3[11], 500);
                    }

                    if (polz.Key == ConsoleKey.Escape)
                    {
                        break;
                    }
                }
            }
        }
    }
}
