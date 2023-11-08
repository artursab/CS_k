

namespace CS_k
{

    class Program
    {
        static void Main(string[] args)
        {
            //int[] array = { 2, 3, 4, 5, 6, 7, 8, -2 };

            ////sum array
            //int sum = 0;
            //for (int i = 0; i < array.Length; i++)
            //{
            //    sum += array[i];
            //}
            //Console.WriteLine(sum);

            ////max element
            //int MaxElement = int.MinValue;
            //for (int i = 0; i < array.Length; i++)
            //{
            //    if (MaxElement < array[i])
            //    {
            //        MaxElement = array[i];
            //    }
            //}
            //Console.WriteLine(MaxElement);
            //Console.WriteLine();


            //passanger registration for airplane
            int[] sectors = { 6, 15, 7, 30, 10 };

            while (true)
            {
                Console.SetCursorPosition(0, 18);
                for (int i = 0; i < sectors.Length; i++)
                {
                    Console.WriteLine($"in sector {i + 1} are free {sectors[i]} seats");
                }

                Console.SetCursorPosition(0, 0);
                Console.WriteLine("Registration to fly!");


                Console.WriteLine("\n\n1 - book a seat \n2 - exit from program.\n\n");
                Console.Write("Enter program number: ");
                switch (Convert.ToInt32(Console.ReadLine()))
                {
                    case 1:  
                        break;
                }

                Console.ReadKey();
                Console.Clear();
            }

        }
    }
}