using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCalc
{
    public class MyCalcul
    {
        public double MyCalc(string s)
        {
            if (s.Contains('+'))
            {
                return Add(double.Parse(s.Split('+')[0]), double.Parse(s.Split('+')[1]));
            }
            else if (s.Contains('-'))
            {
                return Subtract(double.Parse(s.Split('-')[0]), double.Parse(s.Split('-')[1]));
            }
            else if (s.Contains('/'))
            {
                return Subtract(double.Parse(s.Split('/')[0]), double.Parse(s.Split('/')[1]));
            }
            else if (s.Contains('*'))
            {
                return Subtract(double.Parse(s.Split('*')[0]), double.Parse(s.Split('*')[1]));
            }
            else 
                return 0;
        }
        public double Add(double x, double y)
        {
            return x + y;
        }
        public double Subtract(double x, double y)
        {
            return x - y;
        }
        public double Multiply(double x, double y)
        {
            return x * y;
        }
        public double Divide(double x, double y)
        {
            return x / y;
        }
    }
}
