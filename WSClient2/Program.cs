using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WSClient2
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, result;
            Console.Write("Nhap a:");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap b:");
            b = Convert.ToInt32(Console.ReadLine());
            Calculator obj = new Calculator();
            result = obj.Add(a, b);
            Console.WriteLine("Add({0},{1})={2}", a, b, result);
            Console.ReadLine();
        }
    }
}
