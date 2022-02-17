using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Blackjack2
{
    public partial class Table : Form
    {
        List<Card> deck = new List<Card>();
        Player player = new Player();
        Dealer dealer = new Dealer();
     


        public Table()
        {
            InitializeComponent();
            Balance.Text = "100";
            event_text.Text = "Welcome to Blackjack! Place a bet, look at your cards and chose to Hit or Stay. Try to get as close to 21 as you can. Good Luck!";
           
        }

        void Deal_Card()
        {
            Card temp = new Card(deck[deck.Count() - 1].card_type, deck[deck.Count() - 1].card_value);
            player.Add_Card(temp);
            player_card_display.Text += player.Cards[player.Cards.Count() - 1].card_value + " of " + player.Cards[player.Cards.Count() - 1].card_type + "\n";
            deck.RemoveAt(deck.Count() - 1);
        }

        void Deal_Dealer_Card() 
        {
            Card temp = new Card(deck[deck.Count() - 1].card_type, deck[deck.Count() - 1].card_value);
            dealer.Add_Card(temp);
            dealer_card_display.Text += dealer.Cards[dealer.Cards.Count() - 1].card_value + " of " + dealer.Cards[dealer.Cards.Count() - 1].card_type+ "\n";
            deck.RemoveAt(deck.Count() - 1);
 
        }

        void Update_Points()
        {
            int amount_of_aces = 0;

            for (int current_card = 0; current_card < player.Cards.Count(); current_card++)
            {
                player.Points += (int)player.Cards[current_card].card_value;

                switch ((int)player.Cards[current_card].card_value)
                {
                    case 11:
                        player.Points -= 1;
                        break;
                    case 12:
                        player.Points -= 2;
                        break;
                    case 13:
                        player.Points -= 3;
                        break;
                }

                if ((int)player.Cards[current_card].card_value == 1)
                {
                    amount_of_aces += 1;
                }
            }

            for (int current_ace = 0; current_ace < amount_of_aces; current_ace++)
            {
                if ((int)player.Points + 10 < 22)
                {
                    player.Points += 10;
                }
            }

            player_points_display.Text = player.Points.ToString();

   
            for (int current_card = 0; current_card < dealer.Cards.Count(); current_card++)
            {
                dealer.Points += (int)dealer.Cards[current_card].card_value;

                switch ((int)dealer.Cards[current_card].card_value)
                {
                    case 11:
                        dealer.Points -= 1;
                        break;
                    case 12:
                        dealer.Points -= 2;
                        break;
                    case 13:
                        dealer.Points -= 3;
                        break;
                }

                if ((int)dealer.Cards[current_card].card_value == 1)
                {
                    amount_of_aces += 1;
                }
            }

            for (int current_ace = 0; current_ace < amount_of_aces; current_ace++)
            {
                if ((int)dealer.Points + 10 < 22)
                {
                    dealer.Points += 10;
                }
            }

            dealer_points_display.Text = dealer.Points.ToString();
        }
        



        void Create_And_Shuffle_Deck()
        {
            // Create the cards and give them their suit and type
            for (int current_suit = 0; current_suit < 4; current_suit++)
            {
                for (int current_type = 1; current_type < 14; current_type++)
                {
                    Card temp = new Card((Card.type)current_suit, (Card.value)current_type);
                    deck.Add(temp);
                }
            }
            // Shuffle the deck
            Random temp_random = new Random();
            deck = deck.OrderBy(whatever => temp_random.Next()).ToList();
        }

        private void button_hit_Click(object sender, EventArgs e)
        {
            Update_Points();
            CheckforWinner();
            Deal_Card();
            Deal_Dealer_Card();

        }

     

        void CheckforWinner()
        {
            if (dealer.Points == 21 )
            {
                event_text.Text = "Dealer won!";
            }

            if (player.Points == 21)
            {
                event_text.Text = "You won!";
            }
            if (dealer.Points > 21)
            {
                event_text.Text = "Dealer busted!";
            }

            if (player.Points > 21)
            {
                event_text.Text = "You got a Bust! Better luck next Round";
            }
        }

       
        
        void Blackjack()
        {
            
        }

        void NaturalBlackJack()
        {

        }

        void WonBet ()
        {
            
        }

        void LostBet()
        {

        }

        private void button_start_Click(object sender, EventArgs e)
        {
            Create_And_Shuffle_Deck();
            Deal_Card();
            Deal_Card();
            Deal_Dealer_Card();
            Deal_Dealer_Card();
            Update_Points();
            CheckforWinner();
        }

        private void button_stay_Click(object sender, EventArgs e)
        {
            CheckforWinner();
         
        }
    }
}
