


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

            //int[,] array3 = new int[4, 4];

            //Random random = new Random();

            ////Console.WriteLine(array4[1,1]);

            //for (int i = 0; i < array3.GetLength(0); i++)
            //{
            //    for (int j = 0; j < array3.GetLength(1); j++)
            //    {
            //        array3[i, j] = random.Next(0,9);
            //        Console.Write(array3[i, j] + " ");

            //    }
            //    Console.WriteLine();
            //}

            bool isOpen = true;

            string[,] books =
            {
                { "Alex, Slava, Michail" },
                { "Esenin, Shell, Teplakov" },
                { "King, Lavkraft, Stoker" }
            };

            while (isOpen)
            {
                Console.SetCursorPosition(0, 20);
                Console.WriteLine("\nAll list of authors:\n");
                for (int i = 0; i < books.GetLength(0); i++)
                {
                    for (int j = 0; j < books.GetLength(1); j++)
                    {
                        Console.Write(books[i, j] + " | ");
                    }
                    Console.WriteLine();
                }

                Console.SetCursorPosition(0, 0);
                Console.WriteLine("Library");
                Console.WriteLine("1 - find author by book index. " +
                    "2 - find book by author. " +
                    "3 - exit.");
                Console.Write("\nChoose point: ");

                switch (Convert.ToInt32(Console.ReadLine()))
                {
                    case 1:
                        break;

                    case 2:
                        break;

                    case 3:
                        isOpen = false;
                        break;

                    default:
                        Console.WriteLine("Wrong command!");
                        break;
                }

                if (isOpen)
                {
                    Console.WriteLine("\nPress eny key to continue...");
                }


                Console.ReadKey();
                Console.Clear();
            }


        }
    }

}
