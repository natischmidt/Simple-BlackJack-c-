using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack2
{
    class Card
    {
        public Card(type card_type, value card_value)
        {
            this.card_type = card_type;
            this.card_value = card_value;
        }
            
        public enum type
        {
            hearts,
            spades,
            diamonds,
            clubs
        }

        public enum value
        {
            ace = 1,
            two = 2,
            three = 3,
            four = 4,
            five = 5,
            six = 6,
            seven = 7,
            eight = 8,
            nine = 9,
            ten = 10,
            jack = 11,
            queen = 12,
            king = 13,
        }



       /* public override 
        {
            char suite = '?';

            switch (this.suits)
            {
                case Suits.clubs:
                    suite = '♣';
                    break;
                case Suits.diamonds:
                    suite = '♦';
                    break;
                case Suits.hearts:
                    suite = '♥';
                    break;
                case Suits.spades:
                    suite = '♠';
                    break;
            }
        }*/
        public type card_type;
        public value card_value;

        public type Get_Type()
        {
            return card_type;
        }

        public value Value
        {
            get { return card_value; }
        }

}
     
     
    }

