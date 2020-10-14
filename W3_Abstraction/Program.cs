using System;

namespace W3_Abstraction
{
    //Data abstraction is the process of hiding certain details and showing only essential information to the user.

    class Program
    {
        //Abstract class: is a restricted class that cannot be used to create objects 
        //(to access it, it must be inherited from another class)

        //Abstract method: can only be used in an abstract class, and it does not have a body. 
        //The body is provided by the derived class (inherited from)

        //An abstract class can have both abstract and regular methods:
        // Abstract class

        abstract class Animal
        {
            // Abstract method (does not have a body)
            public abstract void animalSound();
            // Regular method
            public void sleep()
            {
                Console.WriteLine("Zzz");
            }
        }
        static void Main(string[] args)
        {


        }
    }
}      


