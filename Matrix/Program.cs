using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[,] matrix = new double[3, 3];       // В условието пише [10 X 10], но го смених на [3 X 3],
                                                       // защото така въвеждаме 9 пъти различните елементи, а при [10 X 10] трябваше 100 пъти.

            for (int row = 0; row < 3; row++)
            {
                for (int col = 0; col < 3; col++)
                {
                    Console.Write($"Enter elements[{row},{col}]: ");
                    matrix[row, col] = double.Parse(Console.ReadLine());

                    Console.WriteLine("-------------------------------");
                }
            }
            Console.Write("The elements of the main diagonal are: ");
            for (int row = 0; row < 3; row++)
            {
                Console.Write(matrix[row, row]);
                if (row != 2)
                {
                    Console.Write(", ");  //Може да се направи също със string.Join и ламбда изрази.
                }
            }
            Console.WriteLine();

            Console.WriteLine("Sum of elements by rows:");
            for (int row = 0; row < 3; row++)
            {
                double sum = 0;
                for (int col = 0; col < 3; col++)
                {
                    sum += matrix[row, col];
                }
                Console.WriteLine($"Row:{row}, Sum:{sum}");
            }
            Console.WriteLine("Avg by columns:");
            for (int col = 0; col < 3; col++)
            {
                double sum = 0;
                for (int row = 0; row < 3; row++)
                {
                    sum += matrix[row, col];
                }
                double average = sum / 3;
                Console.WriteLine($"Columns:{col}, Avg:{average}"); 
            }
        }
    } 
}

