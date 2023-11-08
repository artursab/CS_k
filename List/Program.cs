namespace List
{

    class Program
    {
        static void Main(string[] args)
        { 

            List<int> numbers = new List<int>();

            numbers.Add(1);
            numbers.Add(2);
            numbers.Add(3);
            numbers.Add(4);
            numbers.Add(52);

            numbers.AddRange(new int[] {3, 4, 5, 6});

            numbers.RemoveAt(0);

            numbers.Remove(3);

            for (int i = 0; i < numbers.Count; i++)
            {
                Console.WriteLine(numbers[i]);
            }



            Queue<string> patience = new Queue<string>();

            patience.Enqueue("Artis");
            patience.Enqueue("Nekils");
            patience.Enqueue("Jasda");
            patience.Enqueue("Lsaed");

            Console.WriteLine("Now: " + patience.Dequeue());
            Console.WriteLine("Next is: " + patience.Peek());

            foreach (var patient in patience)
            {
                Console.WriteLine(patient);
            }




        }
    }
}