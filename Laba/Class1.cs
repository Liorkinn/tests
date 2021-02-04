using System;

namespace Liora
{
    public class Liora
    {
        public double Calc(double a, double b, double c, double x)
        {
          
            if ((c < 0) && (b != 0))
            {
                return (a * Math.Pow(x, 2)) + (Math.Pow(b, 2) * x);

            }
            else if ((c > 0) && (b == 0))
            {
                return (x + a) / (x + c);
            }
            else
            {
                return (a * x) / (c * Math.Pow(b, 2));
            }
        }     
               
    }
    public class Animal
    {
        public bool Boolean(bool akk)
        {
            int a = 6;
            if(a > 5)
            {
                akk = true;
            }else
            {
                akk = false;
            }
            return akk;
        }
        public bool Booleann(bool akk)
        {
            int a = 4;
            if (a > 5)
            {
                akk = true;
            }
            else
            {
                akk = false;
            }
            return akk;
        }

        public int Boolnull(int akkk)
        {
            return akkk;
        }

        public string Same(string a, string b)
        {
            return a + b;
        }

        public string IsNullean(string a, string b)
        {
            return a + b;
        }

        public string kekw(string rofl, string owo)
        {
            return rofl + owo;
        }

        public T Rui<T>(T ggg)
        {
            T Rui = ggg;
            return Rui;
        }

    }

}