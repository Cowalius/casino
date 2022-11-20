// See https://aka.ms/new-console-template for more information
using casino;







int bet;
int x  = 0;
//Console.WriteLine("Press 3 if you want to quit");

        
            Console.WriteLine("BLACKJACK");
Console.WriteLine("  This is the Blackjack card game. It is played with a standard 52");
		Console.WriteLine("  The goal is to get closer to 21 than the");
		Console.WriteLine("  If u hit over 21 you lose ");
		Console.WriteLine("  you will place a bet, then the dealer will deal you two cards and");
		Console.WriteLine("  himself two cards (one face up and one face down). Then you will");
		Console.WriteLine("  choose if u either want to double your bet draw card or stay	");
Console.WriteLine("  You can draw 3 times max");
Console.WriteLine("  When your turn is down the dealer will reveal his second card");
		Console.WriteLine("  then he will try to get as close to 21 as possible");
		
		Console.WriteLine();
		
		
		Console.WriteLine("  The dealer must draw until he has a hand score of at least 17.");
		
		Console.WriteLine("  Card Values: Ace (1 or 11), Jack (10), Queen (10), King(10),");
		Console.WriteLine("  and all other cards use their number value ");
            Console.WriteLine("How many credits would you like to deposit, it must be a even value?");
            BlackJack jack = new BlackJack();
            jack.tokens = Convert.ToInt32(Console.ReadLine());
if(jack.tokens %2 != 0)
{
    jack.tokens--;
}

            Card card1 = new Card();
            Card card2 = new Card();


    while (x != 3) {
        Console.WriteLine("How many tokens would you like to bet?");
            bet= Convert.ToInt32(Console.ReadLine());
    if (bet > jack.tokens ) {
    Console.WriteLine("You don't have enought credits, reenter value");
        bet = Convert.ToInt32(Console.ReadLine());
    }else if(bet % 2 != 0)
    {
        Console.WriteLine("Value must be even");
        bet = Convert.ToInt32(Console.ReadLine());
    }

    Console.WriteLine("Your current tokens:" + jack.tokens);
        card1 = card1.draw();
        card2 = card2.draw();
    // Console.WriteLine(card1.ToString());
   
    
    string s = card1.cardicon(card1.name);
    
    Console.WriteLine(s);
    s = card2.cardicon(card2.name);

    Console.WriteLine(s);
    //Console.WriteLine(card2.ToString());
    Console.WriteLine("Do you want to double down your bet y / n?");
    char c = Console.ReadLine()[0];
    if (c == 'y')
        bet += bet; 
    jack.MYscore = jack.score(card1, card2);
        card1 = card1.draw();
        card2 = card2.draw();
        jack.enemyscore = jack.score(card1, card2);
        Console.WriteLine("Croupiers first card :");
    s = card1.cardicon(card1.name);
    Console.WriteLine(s);
    Console.WriteLine("_______\n" +
                "|      |\n" +
                "|      |\n" +
                "|      |\n" +
                "|      |\n" +
                "|      |\n" +
                "-------\n");
    //.WriteLine(card2.ToString());

    Console.WriteLine("Do u want to add Card ? click y = yes or n=no");
    c = Console.ReadLine()[0];
    int counter = 0;
    if (c == 'y')
    {
        while (c != 'n')
        {
            card1=card1.draw();
            if (c == 'y') {
                counter++;
                jack.MYscore = jack.MYscore + card1.value;
                
                //Console.WriteLine("Test:"+jack.MYscore);
            }
            s = card1.cardicon(card1.name);
            Console.WriteLine(s);
            Console.Write(jack.Myscore());
           
            if (jack.MYscore < 21) {
                Console.WriteLine("\n Do u want to add Card ? click y = yes or n=no");
                c = Console.ReadLine()[0];
            }
            
            if (jack.MYscore > 21) {
                jack.MYscore = 33;
                c = 'n';
            }
            if(counter > 2)
            {
                c = 'n';
            }
                
                
            
        }

    }
    //to 
    // if (jack.enemyscore < 17 && jack.MYscore < 22)
    // {
    Console.WriteLine("Croupier Shows his second card");
        s = card2.cardicon(card2.name);
        Console.WriteLine(s);
       // Card card = card2.draw();
       // if(jack.enemyscore > 21) {
        //     s = card.cardicon(card.name);
        //    Console.WriteLine(s);
       // }
        jack.enemyscore = jack.addCroupier();

  //  }


            

       
           
        
        Console.WriteLine(jack.ToString());
        jack.whowins();
        if (jack.playercredit())
        {
            if (jack.MYscore == 21)
            {
            jack.tokens +=(int)(jack.tokens + bet*1.5);
        }
        else
            jack.tokens += bet;
        }
        else
        {
            jack.tokens = jack.tokens - bet;
        }
        Console.WriteLine("Press 3 if you want to quit, press any other button to continue");
    try { x = Convert.ToInt32(Console.ReadLine()); } catch (Exception e) { Console.WriteLine("Wrong data, game still going on !");
    }
       
    if(jack.tokens <= 0)
    {
        x = 3;
        Console.WriteLine("No more tokens to play ");
    }
    Console.Clear();
    }

Console.WriteLine("Game Finished :>");






//    }






