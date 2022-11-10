using System;

namespace BrakingDistance
{
    class Program
    {
        static void Main(string[] args)
        {
            const double BRAKEFACTOR =1.5;
            const double WETFACTOR = 2;
            double speed;
            string wet;
            double brakingDistance = 0;
            Console.WriteLine("Speed");
            speed = Convert.ToDouble(Console.ReadLine());
            brakingDistance = speed / BRAKEFACTOR;
            Console.WriteLine("Is it wet? Y/N");
            wet = Console.ReadLine().Trim().ToLower().Substring(0,1);
            if (wet == "y")
            {
                brakingDistance *= WETFACTOR;
            }
            Console.WriteLine("At {0}, Braking distance is {1} given that wet is {3}", speed, brakingDistance, wet);
        }
    }
}
