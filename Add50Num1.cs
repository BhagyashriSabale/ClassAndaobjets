using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAndObject
{
    internal class Add50Num1
    {
        public void Addition50Num()
        {
            int sum = 0;
            for (int i = 0; i <=50; i++) 
            {
                sum += i;
            }
            Console.WriteLine("The sum of the first 50 numbers is: " + sum);
        }
    }
}
