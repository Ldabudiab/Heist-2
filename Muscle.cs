using System;

namespace Heist_2
{
   public class Muscle : IRobber
    {
        public string Name {get; set;}
        public int SkillLevel {get; set;}
        public int PercentageCut {get; set;}

         public void PerformSkill(Bank Bank)
        {
            Bank.SecurityGaurdScore = Bank.SecurityGaurdScore - SkillLevel; 
            Console.WriteLine($"{Name} is dealing with the security gaurd. Decreased Security by {SkillLevel}");

            if (Bank.SecurityGaurdScore <= 0)
            {
                Console.WriteLine($"{Name} has Kill this man");
            }
            else Console.WriteLine("Still taking care of the guard");
        }
    }
}
