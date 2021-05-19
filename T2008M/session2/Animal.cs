using System;

namespace T2008M.session2
{
    public abstract class Animal
    {
        public string kind;
        public void Eat()
        {
            Console.WriteLine("Eat something..");
        }

        public virtual void DoSomeThing()
        {
            Console.WriteLine("Do something..");
        }

        public abstract void Running(); // abstract method
    }
}