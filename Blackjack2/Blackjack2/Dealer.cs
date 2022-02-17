using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack2
{
    class Dealer 
    {
      
        protected int points;
         List<Card> hand = new List<Card>();
     
        public  Dealer()
        {
            hand = new List<Card>();
        }

  

        public int Points
        {
            set { points = value; }
            get { return points; }
        }
        public void Add_Card(Card card_to_add)
        {
            hand.Add(card_to_add);
        }




        public List<Card> Cards
        {
            get { return hand; }
        }

        public Card Get_Card(int index)
        {
            return hand[index];
        }

        public bool NaturalBlackJack;
        public bool Busted;


    }
}
