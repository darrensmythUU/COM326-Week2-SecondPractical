class Program
{
    public static void Main(string[] args)
    {
        int option = 0;
        PrintMenu();
        option = InputOption(option);
    }

    private static void PrintMenu()
    {
        // Prints a menu which allows the user to see the below options
        Console.WriteLine("Please enter a valid option from below: ");
        Console.WriteLine("1. Hello in French?");
        Console.WriteLine("2. Hello in Spanish?");
        Console.WriteLine("3. Hello in German?");
        Console.WriteLine("4. Hello in Italian?");
        Console.WriteLine("0. Exit Application.");
    }

    private static int InputOption(int methodOption)
    {
        // Stores the users choice as an integer variable and returns the integer value
        methodOption = Convert.ToInt32(Console.ReadLine());
        return methodOption;
    }
}