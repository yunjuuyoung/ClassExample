using System;

namespace ClassExample
{
    public class Cat : Animal
    {
        public sealed override void Eat()
        {
            Console.WriteLine("고양이 사료 냠냠");
        }
    }
}