using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassExample
{
    class Program
    {
        class Parent
        {
            public Parent() { Console.WriteLine("부모 생성자"); }
            public Parent(string name) { Console.WriteLine("Parent(string name)"); }
            public Parent(int param) { Console.WriteLine("Parent(int param)"); }
        }

        private class Child: Parent
        {
            public Child(): base("child")
            {
                Console.WriteLine("자식 생성자");
            }
            public Child(string name): base(name)
            {
                Console.WriteLine("Child(string name)");
            }
            public Child(int param) : base(param)
            {
                Console.WriteLine("Child(int param)");
            }
        }

        static void Main(string[] args)
        {
            Child child1 = new Child("abc");
            Child child2 = new Child();
        }
    }
}
