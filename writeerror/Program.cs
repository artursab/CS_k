
namespace write
{


    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("HI");
            Console.WriteLine("HIy");
            WriteError("Not working");
            Console.WriteLine("HM");
            WriteError("Go pay");
        }

        static void WriteError(string text)
        {
            ConsoleColor consoleColor = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(text);
            Console.ForegroundColor = consoleColor;
        }

    }
}
