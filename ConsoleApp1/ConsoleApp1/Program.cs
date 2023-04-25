using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLib1 {
    
    public class calculation
{
    public double plus(double a, double b)
    {
        return a + b;
    }

    public double minus(double a, double b)
    {
        return a - b;
    }

    public double delit(double a, double b)
    {
        if (b == 0)
        {
            throw new DivideByZeroException("ошибка");
        }
        return a / b;
    }
    public double umnojit(double a, double b)
    {
        return a * b;
    }
}
}
