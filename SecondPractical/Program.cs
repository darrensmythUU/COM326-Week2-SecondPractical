class Program
{
    public static void Main(string[] args)
    {
        int option = 0;
        PrintMenu();
        option = InputOption(option);
        GetMessage(option);
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
        try
        {
            // Stores the users choice as an integer variable and returns the integer value
            methodOption = Convert.ToInt32(Console.ReadLine());
        }
        catch (FormatException ex)
        {
            // Handle the case where the input is not valid
            Console.WriteLine("Please enter a valid number.");
        }
        return methodOption;
    }

    private static void GetMessage(int methodOption)
    {
        // Determines which language is required and
        // then returns the correct "Hello" phrase
        switch (methodOption)
        {
            case 0:
                Console.WriteLine("Goodbye");
                break;
            case 1:
                Console.WriteLine("Bonjour");
                break;
            case 2:
                Console.WriteLine("Ola");
                break;
            case 3:
                Console.WriteLine("Hallo");
                break;
            case 4:
                Console.WriteLine("Ciao");
                break;
            default:
                Console.WriteLine("Please enter a valid option");
                break;

        }
    }
}