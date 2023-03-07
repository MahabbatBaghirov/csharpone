namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int en, uzunluq;
            Console.WriteLine("Eni daxil edin: ");
            en = int.Parse(Console.ReadLine());
            Console.WriteLine("Uzunluq daxil edin: ");
            uzunluq = int.Parse(Console.ReadLine());

            for (int i = 1; i <= uzunluq; i++)
            {
                Console.WriteLine();
                for (int j = 1; j <= uzunluq; j++)
                {
                    Console.Write(" sm");
                }
            }
        }
    }
}