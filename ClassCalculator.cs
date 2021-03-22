using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class ClassCalculator
    {

        public double plusNums(string a, string b)
        {
            double resault = Convert.ToDouble(a) + Convert.ToDouble(b);
            return resault;
        }

        public double ModulusNums(string a, string b)
        {
            double resault = Convert.ToDouble(a) % Convert.ToDouble(b);
            return resault;
        }

        public double minusNums(string a, string b)
        {
            double resault = Convert.ToDouble(a) - Convert.ToDouble(b);
            return resault;
        }

        public double multiplyNums(string a, string b)
        {
            double resault = Convert.ToDouble(a) * Convert.ToDouble(b);
            return resault;
        }

        public double devideNumes(string a, string b)
        {
            double resault = Convert.ToDouble(a) / Convert.ToDouble(b); 
            return resault;
        }

        public double powerNums(string a, string b)
        {
            double resault = 1;
            for (int i = 0; i < Convert.ToDouble(b); i++)
            {
                resault *= Convert.ToDouble(a);
            }
                return resault;
        }


    }
}
