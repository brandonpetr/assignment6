using System;

namespace Assignment62
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[4];
            int sum = 0;
            try
            {
                for (int i = 0; i < 5; i++)
                {
                    array[i] = Convert.ToInt32(Console.ReadLine());
                    sum = sum + array[i];
                }
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine("Error! {0}", e);
            }
            finally
            {
                Console.Write(sum);
            }
        }
    }
}