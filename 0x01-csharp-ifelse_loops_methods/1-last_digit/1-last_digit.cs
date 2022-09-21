using System;

    class Program
    {
        static void Main(string[] args)
        {
            Random rndm = new Random();
            int number = rndm.Next(-10000, 10000);
            Console.WriteLine("The last digit of" + number + " is ");
            if(number > 5)
            {
                Console.WriteLine("greater than 5");    
            }
            else if(number % 10 <= 5 && number % 10 != 0)
            {
                Console.WriteLine("and is less than 6 and not 0");
            }
            else 
            {
                Console.WriteLine(" and is 0");
            }
        }
    }
