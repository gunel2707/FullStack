namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please,enter first number");
            int var1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Please,enter second number");
            int var2 = int.Parse(Console.ReadLine());
            var result = Sum(var1, var2);
            Console.WriteLine("result:" + result.ToString());

        }
        private static int Sum(int x, int y)
        {
            return x + y;
                }
    }
}
