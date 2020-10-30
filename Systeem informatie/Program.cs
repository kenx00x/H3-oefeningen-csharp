using System;
using System.IO;

namespace Systeem_informatie
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Dit gebruikt {Environment.WorkingSet / 1024 / 1024} MB ram");
            Console.WriteLine($"CPU = {Environment.ProcessorCount} cores");

            Console.WriteLine("welke schijfruimte wil je zien");
            int invoer = int.Parse(Console.ReadLine()) - 1;

            long cdriveinbytes = DriveInfo.GetDrives()[invoer].AvailableFreeSpace;
            long totalsize = DriveInfo.GetDrives()[invoer].TotalSize;

            Console.WriteLine(cdriveinbytes);
            Console.WriteLine(totalsize);

            Console.ReadLine();
        }
    }
}
