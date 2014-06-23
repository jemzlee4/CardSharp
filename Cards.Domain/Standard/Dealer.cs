using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Threading.Tasks;
using Cards.Domain.Standard;
class Dealer : Player {
    public Deck deck;
    
    public Dealer() : base("Dealer")
    {
        deck = new Deck();
    }


    public Card hit()
    {
        Card card = deck.TakeCard();
        return card;
    }

    

 
}
