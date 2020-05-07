using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;


namespace Algorithms
{//#1 Print 1-255
    public delegate void PrintIntsFrom1_225();
    class Program
    {
        static void Main(string[] args)
        {  /*
            PrintIntsFrom1_225 printIntsFrom1_225 = () =>
            {
                for(int i = 1; i <= 225; i++)
                {
                    Console.WriteLine(i);
                }
            };
            printIntsFrom1_225();
            Func<int> printIntsFrom1_225andSum = () =>
            {
                int sum = 0;
                for (int i = 1; i <= 225; i++)
                {
                    Console.WriteLine(i);
                    sum += i;
                }
                return sum;
            };
           int sumOfall = printIntsFrom1_225andSum();
            Console.WriteLine($"The total sum of numbers 0-225 is:{sumOfall}");
            
            Func<int[], int> PrintMaxofArray = (arry) =>
             {
                 int maxNumber = arry[0];
                 for(int i = 1; i < arry.Length; i++)
                 {
                     if(arry[i] > maxNumber)
                     {
                         maxNumber = arry[i];
                     }

                 }
                 return maxNumber;
             };
            int[] allArray = { 23, 45, 167, 89 };
            int maxNumber = PrintMaxofArray(allArray);
            Console.WriteLine(maxNumber);
             
            PrintIntsFrom1_225 ReturnOddsArray = () =>
            {
                List<int> oddArray = new List<int>();
                for(int i = 1; i <=255; i++)
                {
                    if(i % 2 != 0)
                    {
                        oddArray.Add(i);
                    }
                }

                foreach( var item in oddArray)
                {
                    Console.WriteLine(item);
                }

            };
            ReturnOddsArray();
           

            Action<int[], int> ReturnArrayCountGreaterthanY = (arry,y) =>
             {
                 int count = 0;
                 for (int i = 0; i < arry.Length;i++)
                 {
                     if (arry[i] > y)
                     {
                         Console.WriteLine($"{arry[i]}\t is greater than {y}");
                         count++;
                     }
                 }
                 Console.WriteLine($"Only {count} numbers are greater than {y}");
             };
            int [] myArry = { 2, 30, 4, 56, 19 }; int num = 12;
            ReturnArrayCountGreaterthanY(myArry,num);
            
            Action<int[]> PrintMaxMinAverageArrayValues = (arry) =>
            {
                int maxNum = arry.Max();
                int minNum = arry.Min();
                double avgNum = Queryable.Average(arry.AsQueryable());
                Console.Write($"The Max Number in the Array is {maxNum}\n The Min Number in the array is {minNum}\n The Averag of the Array is {avgNum}");
            };
            int[] myArry = { 2, 30, 4, 56, 19 };
            PrintMaxMinAverageArrayValues(myArry);
           
            Action<string[]> SwapStringforArrayNegativeValues = (arry) =>
            {
                for(int i = 0; i < arry.Length; i++)
                {
                    if(Convert.ToInt32(arry[i]) < 0)
                    {
                        arry[i] = "Codebits";
                    }
                }
                foreach(var item in arry)
                {
                    Console.WriteLine(item);
                }

            };
            string[] myArry = { "2", "-30", "-4", "56", "-19","67" };
            SwapStringforArrayNegativeValues(myArry);
             
            PrintIntsFrom1_225 PrintOddsfrom1_255 = () =>
            {
                for (int i = 0; i <= 255; i++)
                {
                    if(i % 2 != 0)
                    {
                        Console.WriteLine(i);
                    }
                }
            };
            PrintOddsfrom1_255();
            
            Action<int[]> PrintArrayValues = (arry) =>
            { 
                for(int i= 0; i < arry.Length; i++)
                {
                    Console.WriteLine(arry[i]);
                }

            };
            int [] myArry = { 2, -30, -4, 56, -19,67 };
            PrintArrayValues(myArry);
          
            Action<int[]> PrintAverageofArray = (arry) =>
            {
                double avgNum = Queryable.Average(arry.AsQueryable());
                Console.WriteLine($"The average of the array is {avgNum}");
            };
            int[] myArry = { 2, -30, -4, 56, -19, 67 };
            PrintAverageofArray(myArry);
              
            Action<int[]> SquareArrayValues = (arry) =>
            {
                for (int i = 0; i < arry.Length; i++)
                {
                    arry[i] *= 2;
                    Console.WriteLine(arry[i]);
                };

            };
            int[] myArry = { 2, 10, 4, 6, 4, 2 };
            SquareArrayValues(myArry);
            

            Action<int[]> ZeroOutArrayNegativeNumbers = (arry) =>
            {
                for (int i = 0; i < arry.Length; i++)
                {
                    if (arry[i] < 0)
                    {
                        arry[i] = 0;
                    }
                }
                foreach (var item in arry)
                {
                    Console.WriteLine(item);
                }

            };
            int[] myArry = { 2, 10, 4, -6, -4, -2 };
            ZeroOutArrayNegativeNumbers(myArry);
            
            Action<int[]> ShiftArrayValuesLeft = (arry) =>
            {
                var myArray = new List<int>(arry);
                myArray.RemoveAt(0);
                myArray.Add(0);
                int [] newArray = myArray.ToArray();
             
               foreach(var item in newArray)
                {
                    Console.WriteLine(item);
                }

            };
            int[] myArry = { 2, 10, 4, -6, -4, -2 };
            ShiftArrayValuesLeft(myArry);
            */
           

        }
    }
}
