namespace Part_7A___Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random generator = new Random();
            int[] arrayTest = new int[30];
            for (int i = 0; i < arrayTest.Length; i++)
            {
                arrayTest[i] = generator.Next(1, 101);
                Console.Write(arrayTest[i] + " ");
            }
        }
    }
}
