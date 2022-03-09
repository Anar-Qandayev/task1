using System;

namespace saheler
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("a ededini daxil edin");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(" b ededini daxil edin");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("c ededini daxil edin");
            int c = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("r edini daxil edin");
            int r = Convert.ToInt32(Console.ReadLine()); 
            Console.WriteLine("circle :" + Sahe(r));
            Console.WriteLine("rectangular :" + Sahe(a,b));
            Console.WriteLine("parallelepiped :" + Sahe(a,b,c));
            Console.WriteLine("The area of ​​a circle drawn inside a triangle :" + Sahe(a,b,c,r));
        }
        static int Sahe(int r)
        {
            int p = 3;
            int S = p * r*r;
            return S;
        }
        static int Sahe(int a, int b)
        {
            int S = a * b;
            return S;
        }
        static int Sahe(int a, int b, int c)
        {

            int S = 2*(a * b + a * c + b * c);
            return S;
        }
        static int Sahe(int a, int b, int c,int r)
        {
            int p = (a + b + c) / 2;
            int S = p * r;
            return S;
        }

    }
}
