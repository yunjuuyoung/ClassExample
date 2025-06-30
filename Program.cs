using System;
using System.Collections.Generic;

namespace ClassExample
{
    class Program
    {
        class Parent
        {
            public static int counter = 0;
            public int variable = 273;
            public void Method()
            {
                Console.WriteLine("부모의 메서드");
            }
            public virtual void Method0()
            {
                Console.WriteLine("부모의 메서드");
            }
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
            public new string variable = "hiding";

            public new void Method()
            {
                Console.WriteLine("자식의 메서드");
            }
            public override void Method0()
            {
                Console.WriteLine("자식의 메서드");
            }
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

            // 하이딩
            Child child3 = new Child();
            Console.WriteLine(child3.variable);  // 문자열 
            Console.WriteLine(((Parent)child3).variable);

            // 메서드 하이딩
            child3.Method();  // 자식의 메서드 호출 
            ((Parent)child).Method();  // 부모의 메서드 호출

            // 메서드 오버라이딩
            child3.Method0();  
            ((Parent)child).Method0();

            // 강아지와 고양이로 알아보는 하이딩, 오버라이딩
            // 메서드 하이딩, 오버라이딩 비교
            List<Animal> Animals = new List<Animal>()
            {
                new Dog(), new Cat(), new Cat(), new Dog(),
                new Dog(), new Cat(), new Dog(), new Cat()
            };
            foreach(var item in Animals)
            {
                item.Eat();
            }

        }
    }
}
