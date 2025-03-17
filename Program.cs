namespace Part_7A___Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random generator = new Random();
            int[] arrayTest = new int[30];
            int count = 0;
            for (int i = 0; i < arrayTest.Length; i++)
            {
                arrayTest[i] = generator.Next(1, 101);
                Console.Write(arrayTest[i] + " ");
            }
            Console.WriteLine();
            for (int f = 0; f < arrayTest.Length; f++)
            {
                if (arrayTest[f] % 2 == 0)
                {
                    count++;
                }
                if (arrayTest[f] % 5 == 0)
                {
                    Console.WriteLine();
                    Console.WriteLine(arrayTest[f]);
                }
            }
            Console.WriteLine();
            for (int i = 1; i < arrayTest.Length; i += 2)
            {
                arrayTest[i] *= 2;
            }
            for (int i = 0; i < arrayTest.Length; i++)
            {
                Console.Write(arrayTest[i] + " ");
            }
            Array.Sort(arrayTest);
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine($"There was {count} even numbes on in the list.");
            Console.WriteLine($"Min - {arrayTest[0]}, Max - {arrayTest[arrayTest.Length - 1]}");

            //Questions:
            //
            //I think the array would only be filled with blank spaces in the newer spaces
            //It wouldn't work, it would probably try to pull from an array that doesn't exist
            //It might just be zero
            //I don't think so
            //

        }
    }
}
