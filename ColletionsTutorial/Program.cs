using System;
using System.Collections.Generic;

namespace ColletionsTutorial
{
    class Program
    {
        static void Main(string[] args)
        {
            //var listOfNumbers = new List<int>();
            //listOfNumbers.Add(98);
            //listOfNumbers.Add(7);
            //listOfNumbers.Add(56);
            //listOfNumbers.Add(13);
            //listOfNumbers.Add(72);
            //listOfNumbers.Add(42);
            //listOfNumbers.Add(44);

            //var sum = 0;
            //foreach (var nbr in listOfNumbers)
            //    sum += nbr;
            //Console.WriteLine(sum);

            var rand = new Random();
            var totalScore = new List<int>();
            var number = rand.Next(0, 31);

            for(int i = 1; i <= 30; i++)
            {
                totalScore.Add(number);
                number = rand.Next(0, 31);
                Console.WriteLine(number);
            }
            var total = 0;
            foreach (var score in totalScore)
                total += score;
            Console.WriteLine($"Total is: {total}");
            

            
        }
    }
}
