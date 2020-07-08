using System;
using System.Collections.Generic;

namespace FlatProgram
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Flat nested list");

            var list = new List<object>
            {
                5,
                new List<object>
                {
                    77,
                    14,
                    new List<object>
                    {
                        77, 14, 25
                    },
                    25
                },
                33,
                127
            };

            Console.WriteLine("Flat nested list with classique method");
            foreach (var item in FlatWithList.Flat(list))
            {
                Console.Write(item + " ");
            }

            Console.WriteLine();
            Console.WriteLine("Flat nested list using method returning IEnumerable");
            foreach (var item in FlatWithEnumerable.Flat(list))
            {
                Console.Write(item + " ");
            }
        }
    }
}
