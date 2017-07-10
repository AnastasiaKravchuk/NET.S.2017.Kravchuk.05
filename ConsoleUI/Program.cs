using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Logic;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] arr = { 1, 0, -2, -3, 5, 0, 7 };
            double[] arr1 = { 4, 0, 3, 2, 2};
            double[] arr2 = { 4, 0, 3, 2, 2 };
            double[] arr3 = { 1, 2 , 0.000001};
            double[] arr4 = { 0, 1 , 0.002};
            Polynomial obj = new Polynomial(arr);
            Polynomial obj1 = new Polynomial(arr1);
            Polynomial obj2 = new Polynomial(arr2);
            Polynomial obj3 = new Polynomial(arr3, 0.001);
            Polynomial obj4 = new Polynomial(arr4, 0.000003);
            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine("Полиномы:");
            Console.WriteLine("----------------------------------------------------");
            obj3.toString();
            obj4.toString();
            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine("Умножение:");
            Console.WriteLine("----------------------------------------------------");
            (obj3*obj4).toString();
            Console.WriteLine();
            obj.toString();
            Console.WriteLine();
            Console.WriteLine("Cумма:");
            (obj + obj1).toString();
            obj1.toString();
            Console.WriteLine("Are arr and arr1 equal? " + obj.Equals(obj1));

            obj1.toString();
            Console.WriteLine();

            obj2.toString();
            Console.WriteLine("Are arr and arr1 equal? " + obj1.Equals(obj2));

        }
    }
}
