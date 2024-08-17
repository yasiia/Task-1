namespace Task_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the year: ");
            string userYear = Console.ReadLine();
            int year = int.Parse(userYear);
            if (year % 4 == 0 || year % 400 == 0 && year % 100 != 0)
            {
                Console.WriteLine("Leap year");
            }
            else
            {
                Console.WriteLine("Not a leap year");
            }
        }
    }
}
