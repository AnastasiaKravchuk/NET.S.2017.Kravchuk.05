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
            double[] arr3 = { 9, -1, 0, -7, 4 };
            double[] arr4 = { 0.9, -4, -0.0001, 0.00001, -0.4, 0.002, -0.007 };

            Polynomial obj = new Polynomial(arr);
            Polynomial obj1 = new Polynomial(arr1);
            Polynomial obj2 = new Polynomial(arr2);
            Polynomial obj3 = new Polynomial(arr3, 0.001);
            Polynomial obj4 = new Polynomial(arr4, 0.000003);

            double[] arr01 = { 0.9, -4, -0.0001, 0.00001, -0.4, 0.002, -0.007 };
            Polynomial obj01 = new Polynomial(arr01, 0.001);
            Console.WriteLine(obj01.toString());

            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine("Полиномы:");
            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine("obj3 : ");
            Console.WriteLine(obj3.toString());
            Console.WriteLine("obj4 : ");
            Console.WriteLine(obj4.toString());

            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine("Умножение:");
            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine("obj3 * obj4 : ");
            Console.WriteLine((obj3*obj4).toString());
            Console.WriteLine(Polynomial.Multiply(obj3,obj4).toString());
            Console.WriteLine("obj3 * 7 : ");
            Console.WriteLine(Polynomial.MultiplyConst(obj3, 7).toString());

            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine("Сложение:");
            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine((obj3 + obj4).toString());
            Console.WriteLine();
            Console.WriteLine(Polynomial.Add(obj3, obj4).toString());

            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine("Разность:");
            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine((obj3 - obj4).toString());
            Console.WriteLine();
            Console.WriteLine(Polynomial.Subtract(obj3, obj4).toString());

            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine("Равны ли:");
            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine(obj3.Equals(obj4));
        }
    }
}
