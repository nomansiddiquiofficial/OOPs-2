using OOPs_remaining;
using System;

interface I1
{
    void I1Method();
}

interface I2 : I1
{
    void I2Method();
}

interface I3 : I2, I1
{
    void I3Method();
}

class Program : I3
{
    public void I1Method()
    {
        Console.WriteLine("This is I1 method");
    }

    public void I2Method()
    {
        Console.WriteLine("This is I2 method");
    }

    public void I3Method()
    {
        Console.WriteLine("This is I3 method");
    }

    static void Main()
    {

        //Implicit interface

        //I3 i3 = new Program();    //parent interface ka reference variable (i3) child class obviously (abstract or interface) ka object bana sakti he
        //i3.I3Method();


     //----------------------------------------------------------------------------------------------------------
        //1st method
        
        //Explicit Interface file
        Myclass myclass = new Myclass();  //have I1Explicit method and I2Explicit method
        //konsi Interface ke method ka object banana h uske type caste krna parhega
        //((I1Explicit)myclass).show();
        //((I2Explicit)myclass).show();
   

        //second method 

        I1Explicit i1 = new Myclass();
        i1.show();
        I2Explicit i2 = new Myclass();
        i2.show();
        

        //sealed class implementation
         
        Child child = new Child(3,6);
        child.showSum();




    }
}
