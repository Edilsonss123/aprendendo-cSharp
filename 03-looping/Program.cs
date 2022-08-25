using System.Data;
using System;
namespace Looping
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 1;
            Console.WriteLine("While");
            while (a < 3)
            {
                Console.WriteLine(a);
                a++;
            }

            Console.WriteLine("DoWhile");
            do
            {
                Console.WriteLine(a);
                a++;
            } while (a < 3);

            Console.WriteLine("For");
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("ForEach");
            int[] collection = { 1, 2, 3};
            foreach (var item in collection)
            {
                Console.WriteLine(item);
            }

            for (int i = 0; i < collection.Length; i++)
            {
                Console.WriteLine($"{i} => {collection[i]}");
            }

            Console.WriteLine("Function Looping");
            looping(1);
        }
        
        public static void looping(int a)
        {
            Console.WriteLine(a);
            if (a < 3)
            {
                looping(a+1);
            }            
        }
    }
}