using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTestGit
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("hello world");
            Console.WriteLine("jengi e noob");
            Console.WriteLine("jengi e very noob");

            int[] arr = Enumerable.Range(0, 8).ToArray();
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write($"{arr[j]}\t");
                }
                Console.WriteLine();
            }

        }
    }
}
