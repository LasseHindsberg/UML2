namespace UML2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Store store = new Store();
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.Yellow;
            store.Run();
        }
    }
}