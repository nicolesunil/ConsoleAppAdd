namespace ConsoleAddition
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, Everyone!");
            Console.WriteLine("Welcome to Addition");

            AddOp addOp = new AddOp();
            addOp.Add(10, 20);
        }
    }
}
