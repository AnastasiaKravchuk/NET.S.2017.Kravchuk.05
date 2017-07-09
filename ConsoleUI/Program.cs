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
            Polynomial obj = new Polynomial(arr);
            obj.toString();
        }
    }
}
