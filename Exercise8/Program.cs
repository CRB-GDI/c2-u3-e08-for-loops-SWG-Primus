namespace Exercise8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter maximum number: ");
            int maxNum = Int32.Parse(Console.ReadLine());

            for (int i = 0; i < maxNum; i++)
            {
                //for loop body
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }

            }
            //print asterisk row
            Console.WriteLine("How many rows of Asterisks?: ");
            int astNum = Int32.Parse(Console.ReadLine());

            for (int a = 0; a < astNum; a++)
            {
                Console.Write("*");
            }

            //Console.WriteLine(number);
        }
    }
}