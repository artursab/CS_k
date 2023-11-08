namespace Stack
{


    class Program
    {
        static void Main(string[] args)
        {

            Stack<int> numbers = new Stack<int>();

            numbers.Push(1);
            numbers.Push(2);
            numbers.Push(3);
            numbers.Push(4);
            numbers.Push(5);
            numbers.Push(6);

            //Console.WriteLine(numbers.Peek());

            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }


            while (numbers.Count > 0)
            {
                Console.WriteLine("Next number in stack: " + numbers.Pop());
            }

            

        }
    }
}
