using System;
using System.Collections.Generic;

namespace Heist_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            

            var Locko = new LockSpecialist();
            var Muso = new Muscle();
            var Hacko = new Hacker();
            var Locket = new LockSpecialist();
            var Muset = new Muscle();
            var Hacket = new Hacker();


            var rolodex = new List<IRobber>()
            {
               Locko, 
               Muso, 
               Hacko,
               Locket,
               Muset,
               Hacket 
            };

            Console.WriteLine($"Number of operatives in the rolodex: {rolodex.Count}");

            Console.Write($"Enter the Name of the New Crew Member: ");
            string newName = Console.ReadLine();
            
            Console.WriteLine(@$"1) Hacker (Diables alarms)
            2) Muscle (Disarms guards)
            3) Lock Specialist (cracks vault)");
            
            Console.WriteLine($"Choose you Operative's Class: ");
            int newclassChoice = int.Parse(Console.ReadLine());

            Console.Write($"Enter your operatives skill level (0-100): ");
            int newSkillLevel = int.Parse(Console.ReadLine());
            
            Console.Write($"Enter Operatives Percentage cut (0-100): ");
            int newPercentageCut = int.Parse(Console.ReadLine());
            
            if ( newClassChoice == 1)
            {
                var newOperative = new Hacker() 
                {
                    Name = newName,
                    SkillLevel = newSkillLevel, 
                    PercentageCut = newPercentageCut
                };
                rolodex.Add(newOperative);
            }

            
        }
    }
}
