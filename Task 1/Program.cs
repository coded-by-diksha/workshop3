using static Task_1.@operator;

namespace Task_1
{
    class Program
    {

        static void Main(string[] args)
    {
        Operators op = new Operators();

        op.Add(10, 5);
        op.Subtract(15, 5);
        op.Multiply(99, 5);
        op.Divide(555, 5);
        op.OddEvenFinder(956);

        Console.ReadLine(); // Keeps console open
    }
}


}
