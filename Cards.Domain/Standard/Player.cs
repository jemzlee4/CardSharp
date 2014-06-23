using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Cards.Domain.Standard;

enum HandStatus
{
    OK,
    BUST,
    WIN,
    BLACKJACK,
    TWENTYONE

}


class Player{
    public String name;
    public Hand hand;
    public int bet = 0;
    public int money = 0;
    public HandStatus Status() { return hand.Evaluate();  }

    public Player(String _name)
    {
        name = _name;
        hand = new Hand();
    }

    public int AddMoney(int amount)
    {
        money += amount;
        return money;
    }

    public void NewRoundWithBet(int _bet)
    {
        bet = _bet;
        money -= bet;
        hand.Clear();
    }

    public HandStatus Hit(Card card)
    {
        HandStatus stat =  hand.AddCard(card);
        return stat;
    }



}

