namespace Harmonic
{
    class Program
    {
        public static void Main(string[] args)
        {
            double H = 1;
            Console.WriteLine("Enter the number to print harmonic series ");
            int N = Convert.ToInt32(Console.ReadLine());

            if (N != 0)
            {
                for (int i = 2; i <= N; i++)
                {
                    H += 1 / (double)i;

                }
            }
            else
            {
                Console.WriteLine("give value other than 0 ."); 
            }
            Console.WriteLine("Harmonic value  "+H);
        }
    }
}