using Separator;
using System;
using System.Collections.Generic;

namespace Stack_Generic
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleSeparator consoleSeparator = new ConsoleSeparator('-', 50);
            SeparateEvent separateEvent = new SeparateEvent();
            separateEvent.OnSeparate += consoleSeparator.Separator;

            Stack<int> numbers = new Stack<int>();
            numbers.Push(3);
            numbers.Push(5);
            numbers.Push(8);
            foreach(int p in numbers)
            {
                Console.WriteLine(p);
            }
            separateEvent.Display();
            var stackElement = numbers.Pop();
            Console.WriteLine(stackElement);
            separateEvent.Display();

            Stack<Person> people = new Stack<Person>();
            people.Push(new Person() {Name = "Tom" });
            people.Push(new Person() { Name = "Bill" });
            people.Push(new Person() { Name = "John" });
            foreach (Person p in people)
            {
                Console.WriteLine(p.Name);
            }
            separateEvent.Display();
            var person = people.Pop();
            foreach (Person p in people)
            {
                Console.WriteLine(p.Name);
            }
            Console.ReadKey();
        }
    }
}
