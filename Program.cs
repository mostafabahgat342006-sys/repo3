namespace c__ass3;

internal class Program
{
    static void Main(string[] args)
    {
        // array start from index 0 
        double [] prices = { 25.5, 40.0 , 33.75 };
        Console.WriteLine(prices[1]);

        Console.WriteLine("----------------------------------");

        int[,] shelfCopies = 
        {
            { 3 , 5 },
            { 1 , 4 } 
        };
        Console.WriteLine(shelfCopies[1, 0]);

        Console.WriteLine("----------------------------------");

        static void PrintWelcomeMessage()
        {
            Console.WriteLine("Welcome to the Library!");
        }
        PrintWelcomeMessage();

        Console.WriteLine("----------------------------------");

        static void PrintBookTitle(string title)
        {
            Console.WriteLine("Book title: " + title);
        }
        PrintBookTitle("Clean Code ");

        Console.WriteLine("----------------------------------");

        static void AddBonusPages(int pages)
        {
            pages = pages + 50;
        }
        int pages = 400;

        AddBonusPages(pages);

        Console.WriteLine(pages);

        // output : 400 -> because (int) is a value type,a copy of a value (pages) sent to method

        Console.WriteLine("----------------------------------");

        static void ApplyDiscount(double[] prices)
        {
            prices[0] = prices[0] - 5;
        }

        ApplyDiscount(prices);

        Console.WriteLine(prices[0]);

        // output : 20.5 -> because array is a reference type and the metod 
        //                  will handle it in the same location in the memory.  
        Console.WriteLine("----------------------------------");
































    }
}
