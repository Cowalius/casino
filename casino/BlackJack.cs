using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace casino
{
    public class BlackJack
    {
        Card card1 = new Card();
        Card card2 = new Card();
        Card card3 = new Card();
        Card card4 = new Card();
        Card card5 = new Card();
        public bool tokenadd = false;
        public int MYscore = 0;
        public int enemyscore = 0;
        public int tokens = 0;
        public bool finish=false;

        public int score(Card card1, Card card2)
        {
            if (card1.id == 12 && card2.id == 12)
            {
                return card1.value + 1;
            }
            return card1.value + card2.value;
        }
        public int add(Card card)
        {
            if (MYscore <= 10 && card.id == 12) { MYscore = MYscore + 11; }else if (MYscore > 10 && card.id == 12)
            {
                MYscore = MYscore + 1;
            }
            else      
           MYscore= MYscore + card.value;
            if (MYscore > 21)
                whowins();
            return MYscore;
        }
        public int addCroupier()
        {
            if (MYscore > 21)
                return enemyscore;
            
            // enemyscore = enemyscore + card.value;
            while (enemyscore <= 16)
            {
                Card card = new Card();
                card = card.draw();
                if (card.id == 12)
                    card.value = 1;
                enemyscore = enemyscore + card.value;
                Console.WriteLine("Croupier drawn card value:");
                string s = card.cardicon(card.name);
                Console.WriteLine(s);

            }

                
            if (enemyscore > 21) {
                
                whowins();
            
            }
                
                return enemyscore;
            
        }
        //Who wins
        public void whowins()
        {
            finish = true;
            if (enemyscore >= MYscore && enemyscore <= 21)
                Console.WriteLine("Croupier won !!!");
            else if (MYscore > enemyscore && MYscore <= 21) {
                Console.WriteLine("U won !!!");
               // tokens = tokensafter(tokens);
            }
                
            else if (enemyscore > 21) { Console.WriteLine("U won !!! *croupier busted");
               // tokens = tokensafter(tokens);
            }
                
            else if ( MYscore > 21)
                Console.WriteLine("Croupier won !!! **u busted*");
            else
                Console.WriteLine("Croupier won...sadly");
                    
        }
        public Boolean playercredit()
        {if (MYscore > 21)
            {
                return false;
            }
            else if (enemyscore > 21)
            {
                return true;
            }
            else if (MYscore > enemyscore)
            {
                return true;
            }
            else
                return false;
            
        }

        public string Myscore()
        {
            return "Ur score:  " + MYscore;
        }

        //tostring
        public override string ToString()
        {
            if (MYscore > 21)
                return "Croupier won";
            return "MYscore: " + MYscore + "\n Croupierscore: " + enemyscore;
        }
        public int tokensafter(int token){
            if (MYscore == 21)
            {//jak blackjack to wqtedy 1,5 raza bet jeszcze sie wyplaca 2 x 1,5 to 3
                return token * 3;
            }

            return token * 2;
        }


    }
}
