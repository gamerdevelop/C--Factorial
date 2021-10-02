using System;

namespace FactorialC_
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Enter a number between  1 and 18 (1 and 18 included) : ");
            start:
            int num = Convert.ToInt32(Console.ReadLine());
            long sum = num, num2=sum-1;
            if (num<=18 && num>=1){
                for (int i = 1; i < num-1; i++)
                {
                    sum=sum*num2;
                    num2--;
                }
                Console.Write(num + "!" + "= " + sum);
                
            }
            else
            {
                Console.Write("Please enter a number between 1 and 18 (1 and 18 included) : ");
                goto start;
            }
        Console.ReadKey();  
        }
        
    }
}
