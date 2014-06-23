using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cards.Domain.Standard
{
    public class Hand
    {
        List<Card> cards = new List<Card>();
        int value = 0;
        int alternateValue = 0;
        public int Size() { return cards.Count(); }
        public void Clear()
        {
            cards.Clear();
            value = 0;
            alternateValue = 0;
        }
        public HandStatus AddCard(Card card)
        {
            if (card.CardNumber == CardNumber.Ace)
            {
                if (value < 11)
                {
                    alternateValue = value + 1;
                    value += 11;
                }
            }
            if (alternateValue != 0 && alternateValue == value)
            {
                if (value + (int)card.CardNumber > 21)
                {
                    value = alternateValue;
                    value += (int)card.CardNumber;
                    alternateValue = 0;
                }
                else
                {
                    value += (int)card.CardNumber;
                    alternateValue += (int)card.CardNumber;
                }
            }
            cards.Add(card);
            return Evaluate();
        } 

       public HandStatus Evaluate()
        {
            if (value == 21 && Size() == 2)
            {
                return HandStatus.BLACKJACK;
            }
            else if (value == 21 || alternateValue == 21) return HandStatus.TWENTYONE;
            else if (value > 21) return HandStatus.BUST;
            return HandStatus.OK;

        }
    }
}
