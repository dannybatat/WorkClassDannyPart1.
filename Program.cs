using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace part_a
{
    class Program
    {
        // part 1 - 1
        static void Main(string[] args)
        {

            Console.WriteLine("Enter a number:");
            double x = Convert.ToInt32(Console.ReadLine());
            double i = Power2(x);            
            Console.WriteLine($"power 2 of your number is {i}");
            Console.ReadLine();


        }       
        private static double Power2(double x)
        {
            return Math.Pow(x, 2);
        }

        // part 1 - 2
        // yes!

        static void Main(string[] args)
        {
            int[] a = { 5, 4, -5 };
            Update(a);
            Console.WriteLine(a[0]);
        }

        private static void Update(int[] a)
        {
            a[0] = 1;
        }

        // part 1 - 3
        // no! the function no connect to main
        static void Main(string[] args)
        {
            int[] a = { 5, 4, -5 };
        }

        private static void Update(int[] a)
        {
            a = new int[3];
            a[0] = 1;
        }
        //part 1 - 4
        static void Main(string[] args)
        {
            int[] a, b;

            InitializeArray(out a, out b);

            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine(a[i]);
            }
            for (int i = 0; i < b.Length; i++)
            {
                Console.WriteLine(b[i]);
            }
        }

        private static void InitializeArray(out int[] a, out int[] b)
        {
            Random r = new Random();
            a = new int[10];
            b = new int[10];
            for (int i = 0; i < 10; i++)
            {
                a[i] = r.Next(101);
                b[i] = r.Next(101);
            }
        }
        // part 1 - 5
        // to use params u need creat the list u want on array and u can call it from "list" if u dont give parameter it will be 0.
        // it nice to use whn u have 2+ tyep of parameter int, string ....
        static void Main(string[] args)
        {
            object[] NumbersAndStrings = { 1, 2, 3, "lets", "use", "params" };
            DogmaSellParams(NumbersAndStrings);
        }

        private static void DogmaSellParams(params object[] list)
        {
            for (int i = 0; i < list.Length; i++)
            {
                Console.Write(list[i] + " ");
            }
            Console.WriteLine();
        }


    }

}
