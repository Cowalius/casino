using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace casino
{
    public class Card
    {
        public int value { get; set; }
        public string name { get; set; }
        public int id { get; set; }
        Random random = new Random();

        //tworzenie kart po dobraniu
        public Card draw()
        {
            Card carddraw = new Card();
            carddraw.id = random.Next(0, 13);
            carddraw.name = carddraw.thename(carddraw.id);

            carddraw.value = carddraw.realvalue(carddraw.id);
            return carddraw;
        }
        public Card()
        {
        }
        public Card(int value,string name)
        {
            this.value = value;     
            this.name = name;
        }


        //bedzie przypisywac wartosc do kart
        public int realvalue(int id)
        {
            if (id >= 9 && id < 12)
                return 10;
            else if (id == 12)
            {
               
              return 11;
            }else
                return id+2;


        }

    //zwraca nazwe o okreslonej wartosci
        public string thename(int id)
        {
            string[] names = new string[] { "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A" };
            string cardname = names[id];
            
               
                
            return cardname;
        }
        public string cardicon(string cardname)
        {

            String s = " ┌──┐\n" +
" │..│ \n" +
" │--│ \n" +
" └┬─┘\n" +
   "  │    ┌┐\n" +
   "  ├────┴┘\n" +
  "  │\n" +
  "  │     ┌─────┐\n" +
  "  │     │     │\n" +
" ┌┴┐    │     │\n" +
" │ │    │     │\n" +
" │ │    │     │\n" + " │ │    │     │\n" + " │ │    │     │\n" + " │ │    │     │\n";
            Console.WriteLine(s);
            
            /*
             string s = {
            $"┌───────┐",
			$"│{cardname}    │",
			$"│       │",
			$"│       │",
			$"│       │",
			$"│    {cardname}│",
			$"└───────┘",
		};
             */


            if (cardname.Equals("10"))
                return "_______\n" + "| " +
                 cardname + "   |" + "\n" +
                "|      |\n" +
                "|      |\n" +
                "|      |\n" +
                "|      |\n" +
                "|   "+cardname +" |\n" +
                "-------\n";

            return "_______\n" +"| "+
                 cardname + "    |" + "\n"+
                "|      |\n" +
                "|      |\n" +
                "|      |\n" +
                "|      |\n" +
                "|    " + cardname + " |\n" +
                "-------\n";
        }

        //to string
        public override string ToString()
        {
            return "name: " + name + "\nvalue: " + value;
        }
    }
}
