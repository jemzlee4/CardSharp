using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


enum BlackJackAction
{
    HIT,
    DOUBLEDOWN,
    SPLIT
}


namespace Cards.Domain.Standard
{
    class CountingController
    {
        public CountingMethod method;
        public Dealer dealer;
        public CountingController(CountingMethod _method, Dealer _dealer){
            dealer = _dealer;
            method = _method;
        }


    }
}
