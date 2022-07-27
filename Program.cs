namespace PowerOfTwo
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the power value: ");
            int num = Convert.ToInt32(Console.ReadLine());

            if (num > 0 && num <= 31)
            {
                for (int i = 0; i <= num; i++)
                {
                    double result = Math.Pow(2, i);
                    Console.WriteLine("2 to the power of"+i+ "is "+result);
                }
            }
        }
    }
}