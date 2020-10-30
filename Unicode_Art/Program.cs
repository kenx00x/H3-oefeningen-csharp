using System;

namespace Unicode_Art
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(@".___                                           .__                  ._____.    
|   | ____   ____ _____    ____  ____     _____|  |__   ____   ____ |__\_ |__  
|   |/ ___\ /    \\__  \ _/ ___\/ __ \   /  ___/  |  \ /  _ \_/ __ \|  || __ \ 
|   / /_/  >   |  \/ __ \\  \__\  ___/   \___ \|   Y  (  <_> )  ___/|  || \_\ \
|___\___  /|___|  (____  /\___  >___  > /____  >___|  /\____/ \___  >__||___  /
   /_____/      \/     \/     \/    \/       \/     \/            \/        \/ ");
            Console.Write("Geef een euro bedrag in ");
            double euro = Convert.ToDouble(Console.ReadLine());

            double dollar = euro * 1.18;

            Console.WriteLine();
            Console.WriteLine("Dit bedrag is " + dollar + " dollar.");
            Console.ReadLine();
        }
    }
}
