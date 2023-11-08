namespace Stack
{
    class Program
    {
        static void Main(string[] args)
        {

            Dictionary<string, string> countriesCapital = new Dictionary<string, string>();

            countriesCapital.Add("Australia", "Kanberra");
            countriesCapital.Add("Turkish", "Ankara");
            countriesCapital.Add("Switz", "Bern");

            //if (countriesCapital.ContainsKey("Australia"))
            //    Console.WriteLine(countriesCapital["Australia"]);


            //foreach (var item in countriesCapital)
            //{
            //    Console.WriteLine($"Country - {item.Key} city {item.Value}");
            //}

            foreach (var key in countriesCapital.Keys)
            {
                Console.WriteLine($"Country - {key}");
            }

        }
    }
}
