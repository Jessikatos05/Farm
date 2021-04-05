using System;

namespace EX4A_Farm
{
    public class program
    {
      static void Main(string[] args)
        {
            Horse h = new Horse();
            Pig p = new Pig();
            Mouse m = new Mouse();
            Sheep s = new Sheep();

            Console.WriteLine($"Hello, My name is {h.getName()}. I like to eat {h.getFood()}. My color is {h.getColor()} and I make the sound {h.getSound()}. I am used for {h.getProduct()}. ");
            Console.WriteLine($"Hello, My name is {p.getName()}. I like to eat {p.getFood()}. My color is {p.getColor()} and I make the sound {p.getSound()}. I am used for {p.getProduct()}. ");
            Console.WriteLine($"Hello, My name is {m.getName()}. I like to eat {m.getFood()}. My color is {m.getColor()} and I make the sound {m.getSound()}. I {m.getProduct()}. ");
            Console.WriteLine($"Hello, My name is {s.getName()}. I like to eat {s.getFood()}. My color is {s.getColor()} and I make the sound {s.getSound()}. I am used for my {s.getProduct()}. ");
        }
    }
}
