using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator_console
{
    internal interface Operations
    {
        double Add(double a, double b);
        double Substract(double a, double b);
        double Multiply(double a, double b);
        double Divide(double a, double b);
        double Percent(double a, double b);

        double Stepin(double a, double stepin);

    }
}
