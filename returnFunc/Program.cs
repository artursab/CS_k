
namespace write
{


    class Program
    {
        static void Main(string[] args)
        {
            int j = 3, y = 4, sum;

            sum = Sum(j,y);
            Console.WriteLine(sum);
        }

        static int Sum(int x, int y)
        {
            int sum;
            sum = x + y;

            return sum;
        }

    }
}
