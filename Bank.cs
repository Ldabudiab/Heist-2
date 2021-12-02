using System;
using System.Linq;
using System.Collections.Generic;

namespace Heist_2
{
   public class Bank
    {
        public int CashOnHand {get; set;}

        public int AlarmScore {get; set;}

        public int VaultScore {get; set;}
        
        public int SecurityGaurdScore {get; set;}

        public string MostSecureSystem
        {
            get 
            {
               return securityScores.OrderByDescending(score => score.Value).First().Key;
            }
        }

        public string LeastSecureSystem
        {
            get 
            {
               return securityScores.OrderBy(score => score.Value).First().Key;
            }
        }



        private Dictionary<string, int> securityScores
        {
            get 
            {
               return new Dictionary<string, int>
               {
                   {"Alarm Score", AlarmScore },
                   {"Vault Score", VaultScore},
                   {"Security Gaurd score", SecurityGaurdScore}
               };
            }
            
        } 

        public bool IsSecure 
        {
            get 
            {
                if (CashOnHand <= 0 && AlarmScore <= 0 && VaultScore <= 0 && SecurityGaurdScore <= 0) 
                {
                    return false;
                }
                 else return true;
              
            }
        }

    }
}
