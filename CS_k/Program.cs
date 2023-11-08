

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
            bool isOpen = true;

            while (isOpen)
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
                        int userSector, userPlaceAmount;
                        Console.Write("In wich sector you wanna flight?");
                        userSector = Convert.ToInt32(Console.ReadLine()) - 1;
                        if (sectors.Length <= userSector || userSector < 0)
                        {
                            Console.WriteLine("This sector not exist!");
                            break;
                        }

                        Console.Write("How many seats you wanna book?");
                        userPlaceAmount = Convert.ToInt32(Console.ReadLine());
                        if (userPlaceAmount < 0)
                        {
                            Console.WriteLine("Wrong number of seats!");
                            break;
                        }

                        if (sectors[userSector] < userPlaceAmount)
                        {
                            Console.WriteLine($"In the sector {userSector} not enough seats. " +
                                $"Remains {sectors[userSector]}");
                            break;
                        }

                        sectors[userSector] -= userPlaceAmount;
                        Console.WriteLine("Book was succesfull!)");
                        break;
                    case 2: isOpen = false;
                        break;
                }

                Console.ReadKey();
                Console.Clear();
            }

        }
    }
}