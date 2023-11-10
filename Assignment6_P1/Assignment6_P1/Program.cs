using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment6_P1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[][] matrix = new int[3][];
            int element;

            matrix[0] = new int[4] { 1, 2, 3, 4 };
            matrix[1] = new int[2] { 1, 2 };
            matrix[2] = new int[3] { 1, 2, 3 };

            Console.WriteLine("Stored values are:");

            for (int i = 0; i < matrix.Length; i++)
            {
                Console.WriteLine("Internal elements " + (i + 1));
                for (int j = 0; j < matrix[i].Length; j++)
                {
                    Console.WriteLine(matrix[i][j] + " ");
                }
                //element = matrix[0][1];


            }
            Console.WriteLine("\nSecond element of the first row: " + matrix[0][1]);
            // Add a new third element to the second row
            int newElement = 15;
            Array.Resize(ref matrix[1], matrix[1].Length + 1);
            matrix[1][2] = newElement;

            // Print the updated matrix
            Console.WriteLine("\nUpdated Matrix:");

            for (int i = 0; i < matrix.Length; i++)
            {
                Console.WriteLine("Internal elements " + (i + 1));
                for (int j = 0; j < matrix[i].Length; j++)
                {
                    Console.Write(matrix[i][j] + " ");
                }
                Console.WriteLine();
            }



            // Create a dynamic jagged array with predefined values
            //object[][] dynamicArray = new object[][]
            //{
            //     new object[] { 1, "Hello", 3.14 },
            //     new object[] { true, 'A', DateTime.Now },

            //};

            //// Access and print the elements of the array
            //for (int i = 0; i < dynamicArray.Length; i++)
            //{
            //    Console.WriteLine("Row " + (i + 1) + ":");
            //    for (int j = 0; j < dynamicArray[i].Length; j++)
            //    {
            //        Console.Write(dynamicArray[i][j] + " ");
            //    }
            //    Console.WriteLine();
            //}

            Console.ReadKey();
        }
    }
}
