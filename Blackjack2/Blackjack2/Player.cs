using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack2
{
    class Player : Dealer
    {
        public decimal Balans { get; set; } = 100;
        public decimal Bet { get; set; }
        public decimal Change { get; set; }
        public bool HasStood { get; set; }
        public void Collect()
        {
            Balans += Change;
            Change = 0;
    
        }


    }
   


}
