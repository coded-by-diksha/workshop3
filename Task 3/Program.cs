namespace Task_3
{
     class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your age: ");
            int age = Convert.ToInt32(Console.ReadLine());

            if (age < 13)
            {
                Console.WriteLine("Child.");
            }
            else if (age >= 13 && age < 20)
            {
                Console.WriteLine("Teenager.");
            }
            else if (age >= 20 && age < 60)
            {
                Console.WriteLine("Adult.");
            }
            else
            {
                Console.WriteLine("You are a senior citizen.");
            }
        }

     
    }
}
