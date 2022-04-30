using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("Hello World!2");
            Console.WriteLine("introduceti lungimea");
            int lungime = int.Parse(Console.ReadLine());
            int latime = 2;
            int arie = lungime * latime;
            Console.WriteLine(arie);
        }

    }
}
