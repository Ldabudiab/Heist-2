using System;

namespace Heist_2
{
   public class LockSpecialist : IRobber
    {
        public string Name {get; set;}
        public int SkillLevel {get; set;}
        public int PercentageCut {get; set;}

        public void PerformSkill(Bank Bank)
        {
            Bank.VaultScore = Bank.VaultScore - SkillLevel; 
             Console.WriteLine($"{Name} is dealing with the Vault. Decreased Security by {SkillLevel}");

            if (Bank.SecurityGaurdScore <= 0)
            {
                Console.WriteLine($"{Name} The vault is open");
            }
            else Console.WriteLine("Still taking care of the Vault");
        }
    }
}
