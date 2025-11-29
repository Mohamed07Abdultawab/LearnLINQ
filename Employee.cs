using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnLINQ
{
    public record Employee(
        string Name,
        string Department,
        double Salary
        );
}
