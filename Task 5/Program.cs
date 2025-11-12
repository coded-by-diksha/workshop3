using System.Diagnostics.CodeAnalysis;

namespace Task_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("input the value of N:");
            int n = Convert.ToInt32(Console.ReadLine());
            int sum=0;
            for (int i = 1; i <= n; i++)
            {
                sum += i;


            }
            Console.WriteLine(sum);
            int j = 1;
            while ( j<20){
              
                 if(j%4==0) {
                    continue;
                }
                else if (j == 15)
                {
                    break;
                }
                 Console.WriteLine(j);
            }

            int[] arr = { 2, 4, 6, 8, 10 };
            int total = 0;
            foreach (int item in arr)
            {
                total += item;
            }
            Console.WriteLine($"Sum of all elements in the array is: {total}");
        }
    }

}

   
