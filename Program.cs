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
            addOp.Add(20, 30, 40); //addition of three numbers
        }
    }
}
