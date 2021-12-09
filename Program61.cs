using System;

namespace Assignment6
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2;
            double result = 0.0;
            try
            {
                Console.WriteLine("Enter numbers to divide by ");
                num1 = Convert.ToInt32(Console.ReadLine());
                
                num2 = Convert.ToInt32(Console.ReadLine());
                result = Convert.ToDouble(num1 / (double)num2);

            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("{0}", e);
            }
            catch (FormatException e1)
            {
                Console.WriteLine("Exception caught, you can't do that!!! {0}", e1);
            }
            finally
            {
                Console.Write(result);
            }
        }
    }
}