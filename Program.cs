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

        static void AddBonusPagesByRef(ref int pages)
        {
            pages = pages + 50;
        }
        int nwe_pages = 400;

        AddBonusPagesByRef(ref pages);

        Console.WriteLine(pages);

        // output : 450 -> because (ref) make the metod deal with same original variable

        Console.WriteLine("----------------------------------");

        static void ReplaceArray(ref double[] prices)
        {
            prices = new double[] { 10.0 , 12.5 , 15.0 };
        }
        double[] Prices = { 25.5 , 40.0 };

        ReplaceArray(ref Prices);

        Console.WriteLine(prices.Length);

        // here we change in the original array not copy 

        Console.WriteLine("----------------------------------");

        static bool TryGetPrice(string title, out double price)
        {
            if (title == "Clean Code")
            {
                price = 25.5;
                return true;
            }
            else
            {
                price = 0;
                return false;
            }
        }
        double price;

        if ( TryGetPrice("Clean Code", out price) )
        {
            Console.WriteLine(price);
        }

        Console.WriteLine("----------------------------------");

        static void PrintBookInfo(string title, int pages = 300)
        {
            Console.WriteLine("Book title: " + title);
            Console.WriteLine("Pages: " + pages);
        }
        // function with no pages -> use the default value = 300
        PrintBookInfo("Clean Code");
        Console.WriteLine("");
        PrintBookInfo("Clean Code", 464);

        Console.WriteLine("----------------------------------");

        // named parameter -> Despite the difference in order,each value go in the true path
        PrintBookInfo(pages: 464, title: "Clean Code");

        Console.WriteLine("----------------------------------");





































    }
}
