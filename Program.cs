using System;

namespace NumberPrediction
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Number Prediction";
            Console.BackgroundColor = ConsoleColor.Green;
            Console.WriteLine(" WELCOME TO THE GAME\a");
            Console.BackgroundColor = ConsoleColor.Black;
            int prediction = 0;
            int memory ;
            int counter = 0;
            Random number = new Random();
            memory = number.Next(1,100);
            Console.Write("  Guess the number:  ");
            while (prediction != memory)
            {
                counter++;
                
                prediction = Convert.ToInt32(Console.ReadLine());


                if (prediction > memory)
                {
                    Console.Write("  Enter a smaller number: ");
                }
                else if (prediction < memory)
                {
                    Console.Write("  Enter a bigger number: ");
                }

            }
            Console.BackgroundColor = ConsoleColor.Magenta;
            Console.WriteLine("  CONGRATULATIONS.....\a");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine("  {0}.You found it on try.", counter);
            Console.Read();
        }
    }
}
