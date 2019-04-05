using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Area_of_triangle
{
    class Program
    {
        static void Main(string[] args)
        {   //this is the varbels that are going to be use for the math
            double per;
            double area;

			Console.WriteLine("To get the area of your triangle");

			//int A is side 1 of the triangel
			Console.Write("input A----->");
            double A = double.Parse(Console.ReadLine());

			//int B is side 2 of the triangel
			Console.Write("input B----->");
			double B = double.Parse(Console.ReadLine());

			//int C is side 3 of the triangel
			Console.Write("input C----->");
			double C = double.Parse(Console.ReadLine());

			//the math fulmas
             per = (A + B + C) / 2;
             area = Math.Sqrt(( per * (per-A) * (per-B) * (per-C)));

			//the finel answer
            Console.WriteLine("area is----->" + area );

            Console.ReadKey();
        }
    }
}
