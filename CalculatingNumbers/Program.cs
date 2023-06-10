using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatingNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Първи начин, като тук въвеждаме точната бройка на числата.

            //    Console.Write("Въведи брой числа: ");
            //    int n = int.Parse(Console.ReadLine());
            //    int[] nums = new int[n]; 
            //    int maxPosition = 0;
            //    int positiveNumber = 0;
            //    int negativeNumber = 0;
            //    int threeDigitNumber = 0;

            //    for (int i = 0; i < n; i++)
            //    {
            //       nums[i] = int.Parse(Console.ReadLine());

            //        if (nums[i] > nums[maxPosition])
            //        {
            //           maxPosition = i;
            //        }

            //        if (nums[i] > 0)
            //        {
            //            positiveNumber++;
            //        }
            //        else if (nums[i] < 0)
            //        {
            //            negativeNumber++;
            //        }

            //        if (nums[i] >= 100 && nums[i] <= 999)
            //        {
            //            threeDigitNumber++;
            //        }
            //    }
            //     int max = nums[maxPosition];
            //     double avg = nums.Average();

            //    Console.WriteLine("------------------------");
            //    Console.WriteLine($"The largest number is {max}, entered at position {maxPosition + 1}.");
            //    Console.WriteLine($"Positive numbers: {positiveNumber}");
            //    Console.WriteLine($"Negative numbers: {negativeNumber}");
            //    Console.WriteLine($"Three digit numbers: {threeDigitNumber}");
            //    Console.WriteLine($"Average:{avg}");

            //Втори начин. Въвеждаме числа, докато не напишем 0.

            int maxNumber = 0;
            int maxPosition = 0;
            int positiveNumber = 0;
            int negativeNumber = 0;
            int threeDigitNumber = 0;
            int sum = 0;
            int counter = 0;

            Console.WriteLine("Enter numbers(to stop enter 0): ");

            while (true)
            {
                int number = int.Parse(Console.ReadLine());
                Console.WriteLine("-------------------------------");

                if (number == 0)
                {
                    break;
                }
                counter++;

                if (number > maxNumber)
                {
                    maxNumber = number;
                    maxPosition = counter;
                }
                if (number > 0)
                {
                    positiveNumber++;
                }
                else if (number < 0)
                {
                    negativeNumber++;

                }
                if (number >= 100 && number <= 999)
                {
                    threeDigitNumber++;
                }
                sum += number;
            }
            if (counter > 0)
            {
                double avg = (double)sum / counter;
                Console.WriteLine($"Average:{avg}");
            }
            Console.WriteLine($"The largest number is {maxNumber}, entered at position {maxPosition}.");
            Console.WriteLine($"Positive numbers: {positiveNumber}");
            Console.WriteLine($"Negative numbers: {negativeNumber}");
            Console.WriteLine($"Three digit numbers: {threeDigitNumber}");
        }
    }
}


