namespace Assignment_4
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
            Console.Write("Input starting number of range: ");
            int start = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input ending number of range: ");
            int end = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"\nThe prime numbers between {start} and {end} are:");
            for (int i = start; i <= end; i++)
            {
                if (IsPrime(i))
                {
                    Console.Write($"{i} ");
                }
            }
            Console.WriteLine();
        }
        static bool IsPrime(int num)
        {
            if (num <= 1) 
                return false;
            for (int i = 2; i < num; i++)
            {
                if (num % i == 0) 
                    return false;
            }
            return true;
        #endregion
    }
    }
}
