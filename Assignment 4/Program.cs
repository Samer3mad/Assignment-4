﻿namespace Assignment_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Question 01
            //int num = Convert.ToInt32(Console.ReadLine());
            //for (int i = 1; i <= num; i++)
            //{
            //    Console.Write(i+ ", ");
            //}
            #endregion

            #region Question 02
            //int num = Convert.ToInt32(Console.ReadLine());
            //for (int i = 1*num; i <= 12*num; i+=5)
            //{
            //    Console.Write(i + ", ");
            //}
            #endregion

            #region Question 03
            //int num = Convert.ToInt32(Console.ReadLine());
            //for (int i = 2; i <= num; i+=2)
            //{
            //    Console.Write(i + ", ");
            //}
            #endregion

            #region Question 04
            //int num1 = Convert.ToInt32(Console.ReadLine());
            //int num2 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine(Math.Pow(num1, num2));
            #endregion

            #region Question 05
            //    Console.Write("Input starting number of range: ");
            //    int start = Convert.ToInt32(Console.ReadLine());
            //    Console.Write("Input ending number of range: ");
            //    int end = Convert.ToInt32(Console.ReadLine());
            //    Console.WriteLine($"\nThe prime numbers between {start} and {end} are:");
            //    for (int i = start; i <= end; i++)
            //    {
            //        if (IsPrime(i))
            //        {
            //            Console.Write($"{i} ");
            //        }
            //    }
            //    Console.WriteLine();
            //}
            //static bool IsPrime(int num)
            //{
            //    if (num <= 1) 
            //        return false;
            //    for (int i = 2; i < num; i++)
            //    {
            //        if (num % i == 0) 
            //            return false;
            //    }
            //    return true;
            #endregion

            #region Question 06
            //Console.Write("Enter the size of the identity matrix (n): ");
            //int n = Convert.ToInt32 (Console.ReadLine());

            //Console.WriteLine($"\nIdentity Matrix of size {n}x{n}:\n");
            //for (int i = 0; i < n; i++)
            //{
            //    for (int j = 0; j < n; j++)
            //    {
            //        if (i == j)
            //            Console.Write("1 ");
            //        else
            //            Console.Write("0 ");
            //    }
            //    Console.WriteLine();
            #endregion

            #region Question 07
            //string name1 = Console.ReadLine();
            //string name2 = Console.ReadLine();
            //Console.WriteLine(name1+" "+name2);
            #endregion

            #region Question 08
            //int n = Convert.ToInt32(Console.ReadLine());
            //int[] array = new int[n];
            //for (int i = 0; i < n; i++)
            //{
            //    array[i] = Convert.ToInt32(Console.ReadLine());
            //}
            //int sum = 0;
            //for (int i = 0; i < n; i++)
            //{
            //    sum += array[i];
            //}

            //Console.WriteLine($"\nThe sum of all elements in the array is: {sum}");
            #endregion

            #region Question 09
            int size = Convert.ToInt32(Console.ReadLine());

            int[] array = new int[size];
            for (int i = 0; i < size; i++)
            {
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
            int max = array[0];
            int min = array[0];      
            for (int i = 1; i < size; i++)
            {
                if (array[i] > max)
                    max = array[i];
                if (array[i] < min)
                    min = array[i];
            }
            Console.WriteLine($"\nMaximum element in the array: {max}");
            Console.WriteLine($"Minimum element in the array: {min}");
            #endregion

        }
    }
}
