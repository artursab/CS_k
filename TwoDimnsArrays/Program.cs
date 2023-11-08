


namespace Two
{

    class Program
    {

        static void Main(string[] args)
        {
            //int[,] array;
            //int[,] array2 = new int[2,3];

            //int[,] array3 = {
            //    { 2 , 3, 5 },
            //    { 3 , 4, 5 },
            //    { 4 , 4, 5 },
            //    };

            //int[,] array4 = new int[2, 3]
            //{
            //    { 3 , 4, 5 },
            //    { 4 , 4, 5 },
            //};

            int[,] array3 = new int[4, 4];

            Random random = new Random();

            //Console.WriteLine(array4[1,1]);

            for (int i = 0; i < array3.GetLength(0); i++)
            {
                for (int j = 0; j < array3.GetLength(1); j++)
                {
                    array3[i, j] = random.Next(0,9);
                    Console.Write(array3[i, j] + " ");

                }
                Console.WriteLine();
            }

        }
    }

}
