using System;
using System.Collections;


namespace stack
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack first = new Stack();
            first.Push(50);
            first.Push(45);
            first.Push(11);
            first.Push(7);

            Stack second = new Stack();
            second.Push(67);
            second.Push(65);
            second.Push(32);
            second.Push(12);

            ProcessInOrder(first, second);

            Console.WriteLine(
                "press any key to continue...");
            Console.ReadKey();
        }
        static void ProcessInOrder(Stack first, Stack second)
        {
            while (first.Count > 0 || second.Count > 0)
                
            {
              
                if (first.Count == 0)
                {
                    Console.WriteLine(second.Pop());
                    continue;
                }
                if (second.Count == 0)
                {
                    Console.WriteLine(first.Pop());
                    continue;
                }
               
                if ((int)first.Peek()
                    >= (int)second.Peek())
                {
                    Console.WriteLine(
                        second.Pop());
                }
                else
                {
                    Console.WriteLine(first.Pop());
                }
            }
        }
    }
}
