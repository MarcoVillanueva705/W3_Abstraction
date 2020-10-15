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

        //derived class (from Animal)
        class Pig : Animal
        {
            public override void animalSound()
            {
              // The body of animalSound() is provided here
                Console.WriteLine("The pig goes pweeh!");
            }
        }

        static void Main(string[] args)
        {
            Pig myPig = new Pig();//create a Pig object
    
            myPig.sleep();//call the regular method
            myPig.animalSound();//call the abstract method

        }
        //Why And When To Use Abstract Classes and Methods?
        //To achieve security - hide certain details and only 
        //show the important details of an object.


    }
}      


