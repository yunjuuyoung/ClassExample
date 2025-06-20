﻿using System;

namespace ClassExample
{
    class Program
    {
        class Parent
        {
            public static int counter = 0;
            public void CountParent()
            {
                Parent.counter++;
            }
            public Parent() { Console.WriteLine("부모 생성자"); }
            public Parent(string name) { Console.WriteLine("Parent(string name)"); }
            public Parent(int param) { Console.WriteLine("Parent(int param)"); }
        }

        private class Child: Parent
        {
            public void CountChild()
            {
                Parent.counter++;
            }
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

        public static int number = 10;
        static void Main(string[] args)
        {
            // 섀도잉
            int number = 20;
            Console.WriteLine(number);
            Console.WriteLine(Program.number);

            Child child1 = new Child("abc");
            Child child2 = new Child();

            Parent parent = new Parent();
            Child child = new Child();

            parent.CountParent();
            child.CountChild();

            Console.WriteLine(Parent.counter);
            Console.WriteLine(Child.counter);
        }
    }
}
