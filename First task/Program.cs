namespace First_task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int X = 25;
            int Y = 35;
            double tax;
            double cost;
            double totalCost;

            Console.WriteLine("Welcome to Islam's Carpet Cleaning Service ");
            Console.WriteLine("We are here to help you with your carpet cleaning needs.");

            Console.WriteLine("Price per small carpets: 25");
            Console.WriteLine("Price per large carpets: 35");

            Console.WriteLine("For one month only the taxs will be : 6 %");
            Console.WriteLine("***********************************");
            Console.WriteLine("Please enter the Number of your Small carpets:");
            int smallCarpets = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter the Number of your Large carpets:");
            int largeCarpets = Convert.ToInt32(Console.ReadLine());

            smallCarpets = smallCarpets * X;
            largeCarpets = largeCarpets * Y;
            cost= smallCarpets + largeCarpets;
            tax = cost*6/100;
            totalCost = cost + tax;


            Console.WriteLine($"The cost of cleaning small carpets is: {smallCarpets:C}");
            Console.WriteLine($"The cost of cleaning large carpets is: {largeCarpets:C}");
            Console.WriteLine("***********************************");
            Console.WriteLine($"The tax on your total cost is: {tax}%");

            Console.WriteLine($"The total cost of cleaning your carpet is: {totalCost:C}");


        }
    }
}
