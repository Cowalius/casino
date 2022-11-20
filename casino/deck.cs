using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace casino
{
    public class deck
    {
        List<Card> cards = new List<Card>();
        
        public void deckzapelnij()
        {
            int i;
            for (i = 0; i < 52; i++)
            {
                Card card = new Card();
                card=card.draw();
            }
        }

    } 
}
