using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LinqForCSharpDevelopers;
//custom comparer video 14 part 3
namespace LearnLINQ;
public class CarComparer : IComparer<Car>
{
    public int Compare(Car? x, Car? y)
    {
        var result = 0;

        if(x is not null && y is not null)
        {
            if (x.MaxSpeed > y.MaxSpeed)
            {
                result = 1;
            }
            else if (x.MaxSpeed < y.MaxSpeed)
            {
                result = -1;
            }
        }

        return result;
    }
}