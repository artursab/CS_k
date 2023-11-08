

namespace CS_k
{

    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 2, 3, 4, 5, 6, 7, 8, -2 };
            int sum = 0;

            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }

            Console.WriteLine(sum);

        }
    }
}