namespace LeapYear
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the Year ");
            string year = Console.ReadLine();

            if (year.Length == 4)
            {
                Console.WriteLine(year.Length);
                int yearint = Convert.ToInt32(year);
                if (yearint % 4 == 0 && yearint % 100 != 0 || yearint % 400 == 0)
                {

                    Console.WriteLine(yearint + " is a Leap Year.");

                }
                else
                {
                    Console.WriteLine(yearint + " is not a Leap Year.");
                }
            }
            else 
            {
                Console.WriteLine("Please enter valid year.");
            }
        }
    }
}