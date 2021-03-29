using System;

namespace helloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Hello there,who am i speaking to?");
            string Alexandra = Console.ReadLine();
            Console.WriteLine(Alexandra  + ("Is that your name?"));
            string answer = Console.ReadLine();
            if (answer == "yes")
            {
                Console.WriteLine("Great!");
            }
            
           else
            {
                Console.WriteLine("Ok, then I will call you anonymous...");
            }

            Console.WriteLine(Alexandra + "What is your age?");
            int age;
            age = Convert.ToInt32(Console.ReadLine());

            
            if (age > 27)
            {
                Console.WriteLine("You are" + age + "years old");
            }
            else if (age == 27)
            {
                Console.WriteLine("ok, noice");
            }
            else
            {
                Console.WriteLine("I hope you are at least above 18...");
            }

            Console.WriteLine("Today is" + DateTime.Now.ToString());

            
        }
    }
}
