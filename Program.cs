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



































    }
}
