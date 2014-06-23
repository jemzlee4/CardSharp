using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cards.Domain
{
    public interface IDeck
    {
        ICard TakeCard();
        IEnumerable<ICard> TakeCards(int cards);
        void Reset();
        void Shuffle();
    }
}
