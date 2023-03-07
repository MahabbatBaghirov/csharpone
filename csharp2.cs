namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number : ");
            int num = int.Parse(Console.ReadLine());

            if (num >= 0 && num<=2)
            {
                Console.WriteLine("ne tek, ne cut");
            }
            for (int i = 2; i < num; i++)
            {
                if(num % i == 0)
                {
                    Console.WriteLine("murekkebdir");
                    break;
                }
                else
                {
                    Console.WriteLine("sadedir");
                    break;
                }
            }
        }
    }
}