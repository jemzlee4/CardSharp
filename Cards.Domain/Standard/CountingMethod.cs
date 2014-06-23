using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cards.Domain.Standard
{
public class CountingMethod 
{
    public int[] points;

    public int getPointValue(Card card)
    {
        return points[(int)card.CardNumber - 1];
    }

    public int addCardToCount(Card card)
    {
        count += points[getPointValue(card)];
        return count;
    }

    public void setCardValues(int[] _points)
    {
        this.points = _points;
    }

    public CountingMethod()
    {

    }

    public int count = 0;

}

public class ZenCount : CountingMethod
{
    public ZenCount() 
    {
        int [] points = {+1,	+1,	+2,	+2,	+2,	+1,	0,	0,	-2,	-1};
        setCardValues(points);
    }
}

public class HiLo : CountingMethod
{
    public HiLo()
    {
        int[] points = { +1, +1, +1, +1, +1, +0, 0, 0, -1, -1 };
        setCardValues(points);
    }
}
