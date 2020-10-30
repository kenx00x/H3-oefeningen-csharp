using System;

namespace Weerstandberekenaar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Geef ring 1 waarde: ");
            int ring1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Geef ring 2 waarde: ");
            int ring2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Geef ring 3 waarde: ");
            int ring3 = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            int ring3pow = Convert.ToInt32(Math.Pow(10, ring3));
            int weerstand = (ring1*10 + ring2)*ring3pow;
            Console.Write($@"
╔═══════════════╦═══════════════╦═══════════════╦═══════════════╗
║ ring1         ║ ring2         ║ ring3         ║ Totaal(Omh)   ║
╟───────────────╫───────────────╫───────────────╫───────────────╢
║ ");
            switch (ring1)
            {
                default:
                    Console.ResetColor();
                    break;
                case 0:
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    break;
                case 1:
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    break;
                case 2:
                    Console.ForegroundColor = ConsoleColor.Red;
                    break;
                case 3:
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    break;
                case 4:
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    break;
                case 5:
                    Console.ForegroundColor = ConsoleColor.Green;
                    break;
                case 6:
                    Console.ForegroundColor = ConsoleColor.Blue;
                    break;
                case 7:
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    break;
                case 8:
                    Console.ForegroundColor = ConsoleColor.Gray;
                    break;
                case 9:
                    Console.ForegroundColor = ConsoleColor.White;
                    break;
            }
            Console.Write($@"{ring1}             ");
            Console.ResetColor();
            Console.Write($@"║ ");
            switch (ring2)
            {
                default:
                    Console.ResetColor();
                    break;
                case 0:
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    break;
                case 1:
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    break;
                case 2:
                    Console.ForegroundColor = ConsoleColor.Red;
                    break;
                case 3:
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    break;
                case 4:
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    break;
                case 5:
                    Console.ForegroundColor = ConsoleColor.Green;
                    break;
                case 6:
                    Console.ForegroundColor = ConsoleColor.Blue;
                    break;
                case 7:
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    break;
                case 8:
                    Console.ForegroundColor = ConsoleColor.Gray;
                    break;
                case 9:
                    Console.ForegroundColor = ConsoleColor.White;
                    break;
            }
            Console.Write($@"{ring2}             ");
            Console.ResetColor();
            Console.Write($@"║ ");
            switch (ring3)
            {
                default:
                    Console.ResetColor();
                    break;
                case 0:
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    break;
                case 1:
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    break;
                case 2:
                    Console.ForegroundColor = ConsoleColor.Red;
                    break;
                case 3:
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    break;
                case 4:
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    break;
                case 5:
                    Console.ForegroundColor = ConsoleColor.Green;
                    break;
                case 6:
                    Console.ForegroundColor = ConsoleColor.Blue;
                    break;
                case 7:
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    break;
                case 8:
                    Console.ForegroundColor = ConsoleColor.Gray;
                    break;
                case 9:
                    Console.ForegroundColor = ConsoleColor.White;
                    break;
            }
            Console.Write($@"{ring3}             ");
            Console.ResetColor();
            Console.Write($@"║ {weerstand} Ohm
╚═══════════════╩═══════════════╩═══════════════╩═══════════════╝");
        }
    }
}
