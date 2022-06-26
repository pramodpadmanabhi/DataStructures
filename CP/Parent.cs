using System;
using System.Collections.Generic;
using System.Text;

namespace CP
{
    public class Parent
    {
         static Parent()
        {
            Console.WriteLine("Parent Static Cons");
        }
        public Parent()
        {
            Console.WriteLine("Parent Instance Cons");
        }
    }
    public class Child : Parent
    {
        static Child()
        {
            Console.WriteLine("Child Static Cons");
        }
        public Child()
        {
            Console.WriteLine("Child Instance Cons");
        }
    }
}
