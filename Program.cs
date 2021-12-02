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


        while (true)
            {
            Console.WriteLine($"Number of operatives in the rolodex: {rolodex.Count}");

            Console.Write($"Enter the Name of the New Crew Member: ");
            string newName = Console.ReadLine();
            
                if (newName == "")
                {
                    break;
                }

            Console.WriteLine(@$"1) Hacker (Diables alarms)
            2) Muscle (Disarms guards)
            3) Lock Specialist (cracks vault)");

            
            
            Console.WriteLine($"Choose you Operative's Class: ");
            int newClassChoice = int.Parse(Console.ReadLine());

            Console.Write($"Enter your operatives skill level (0-100): ");
            int newSkillLevel = int.Parse(Console.ReadLine());
            
            Console.Write($"Enter Operatives Percentage cut (0-100): ");
            int newPercentageCut = int.Parse(Console.ReadLine());
            
            rolodex = AddOperative(newClassChoice, newName, newSkillLevel, newPercentageCut, rolodex);
        }
            
            var newRandom = new Random();
            var newBank = new Bank
            {
                AlarmScore = newRandom.Next(0,101), 
                VaultScore = newRandom.Next(0,101),
                SecurityGaurdScore = newRandom.Next(0,101),  
                CashOnHand = newRandom.Next(50_000, 1_000_000)
                
            };

            
            Console.WriteLine($"Most secure system is: {newBank.MostSecureSystem}");
             
        }

       public static List<IRobber> AddOperative(int choice, string name, int skillLevel, int percentageCut, List<IRobber> rolodex)
        {

            if (choice == 1)
            {
                Hacker newOperative = new Hacker()
                {
                    Name = name,
                    SkillLevel = skillLevel,
                    PercentageCut = percentageCut,
                };

                rolodex.Add(newOperative);
            }
            else if (choice == 2)
            {
                Muscle newOperative = new Muscle()
                {
                    Name = name,
                    SkillLevel = skillLevel,
                    PercentageCut = percentageCut,
                };
                rolodex.Add(newOperative);
            }
            else if (choice == 3)
            {
                LockSpecialist newOperative = new LockSpecialist()
                {
                    Name = name,
                    SkillLevel = skillLevel,
                    PercentageCut = percentageCut,
                };
                rolodex.Add(newOperative);
            };
            return rolodex;
        }
    }
}