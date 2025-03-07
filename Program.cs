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
            Console.WriteLine();
            Console.WriteLine($"There was {count} even numbes on in the list.");
        }
    }
}
