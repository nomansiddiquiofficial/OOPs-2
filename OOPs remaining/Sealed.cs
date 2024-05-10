using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPs_remaining
{
    internal sealed class BaseClass
    {
        void show()
        {
            Console.WriteLine("this is sealed class ");
        }
    }
    internal class Child 
    {
        private int a;
        private int b;

       public Child(int A, int B)
        {
            this.a = A;
            this.b = B;
        }
        void sum(int firstNumber, int SecondNumber)
        {
            Console.WriteLine("this is child class that can't be inherit sealed classes");
            Console.WriteLine("the sum is: {0}", a + b);
        }
        public void showSum()
        {
            sum(a, b);
        }
    }

    class A
    {
       public virtual void display()
        {
            Console.WriteLine("this is class a method");
        }
    }
    class C : A
    {
        public sealed override void display()
        {
            Console.WriteLine("this is class c method");
        }
    }
    class B : C
    {
        public override void display()
        {
            Console.WriteLine("this is class B method & can't be ovveride more caused of sealed ");
        }
    }
    
}
}

}

