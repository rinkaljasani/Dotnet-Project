using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace practical_2
{
    class Program
    {
        static void Rectangle()
        {
            for (int i = 0; i < 5; i++)
            {
                Console.Write(" * ");
                for (int j = 0; j < 5; j++)
                {
                    Console.Write(" * ");
                }
                Console.WriteLine();
            }
          
        }
        static void Tringle_left()
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(" ");
                for (int j = 0; j <= i; j++)
                {
                    Console.Write(" * ");
                }
            }
            
        }
        static void Tringle_right()
        {

            for (int i = 5; i > 0; i++)
            {
                Console.WriteLine(" ");
                for (int j = i; j < 5; j++)
                {
                    Console.Write(" * ");
                }
            }
        }
        static void Main(string[] args)
        {
            Rectangle();
            Console.WriteLine();
            Tringle_left();
            Console.WriteLine();
            Tringle_right();
            Console.Read();
        }
    }
}
