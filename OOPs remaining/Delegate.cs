using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPs_remaining
{
    public delegate void Calculation(int a, int b);
    internal class CustomMath
    {
        public void Additon(int a, int b)
        {
            int result = a + b;  
            Console.WriteLine(result);
        }
    }
}
