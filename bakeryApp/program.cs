using System;

namespace bakeryApp
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("Welcome To Pierre's Bakery");
            
            Console.WriteLine("Enter the number of loaves you would like to buy.");
            int numberOfLoaves = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the number of pastries you would like to buy.");
            int numberOfPastries = int.Parse(Console.ReadLine());
        }
    }
}