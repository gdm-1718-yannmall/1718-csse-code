using System;

namespace week4
{
    class Program
    {
        static void Main(string[] args)
        {
           //Ask user for number and convert it to Int32
            Console.Write("Getal kleiner dan 100: ");
            int getal = Convert.ToInt32(Console.ReadLine());

            Numbers(getal);
            printFib(getal);

            
        }

        public static String IsPrime(int number)
        {
            if (number == 1) return "is not a prime number";
            if (number == 2) return "is a prime number";
            if (number % 2 == 0)  return "is not a prime number";

            var boundary = (int)Math.Floor(Math.Sqrt(number));

            for (int i = 3; i <= boundary; i+=2)
            {
                if (number % i == 0)  return "is not a prime number";
            }

            return "is a prime number";        
        }

        public static int Fibonacci(int n)
        {
            int a = 0;
            int b = 1;
            // In N steps compute Fibonacci sequence iteratively.
            for (int i = 0; i < n; i++)
            {
                int temp = a;
                a = b;
                b = temp + b;
            }
            return a;
        }

        private static void Numbers(int getal){
            Console.WriteLine("\n=================== PRIME NUMBERS ===================\n");
            for (int i=0; i <= getal; i++){
                Console.WriteLine(i + " " + IsPrime(i));
            }
        }

        private static void printFib(int getal){
            Console.WriteLine("\n=================== FIBONACCI ===================\n");
            for (int i=0; i < getal; i++){
                Console.WriteLine(Fibonacci(i));
            }
        }

    }
}
