using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPs_remaining
{
    interface I1Explicit
    {
        void show();
    }


    interface I2Explicit
    {
        void show();
    }
    

    internal class Myclass : I1Explicit, I2Explicit
    {
        //Explicitly implmenting of interface method because of same method names 
         void I1Explicit.show() {
            Console.WriteLine("This is interface i1 method");
        }
        void I2Explicit.show()
        {
            Console.WriteLine("This is interface i2 method ");
        }
    }

   
}
