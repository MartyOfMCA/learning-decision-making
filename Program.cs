internal class Program
{
    private static void Main(string[] args)
    {
        string username;
        Console.Write("What's your name: ");
        username = Console.ReadLine();
        string userOption;
        Console.Write("Do you wish to play fruit (f) or country (c)? Press f or c: ");
        userOption = Console.ReadLine();

        Console.WriteLine();
        Console.Write("Welcome ");
        Console.WriteLine(username);
        Console.WriteLine();

        int randomNumber;
        randomNumber = new Random().Next(5);
        string generatedItem = "nothing";

        if (userOption == "c")
        {
            string[] countries = new string[] { "Ghana", "Togo", "Mali", "Nigeria", "Rwanda" };
            generatedItem = countries[randomNumber];

            Console.WriteLine("Ghana - Togo - Mali - Nigeria - Rwanda");
            Console.Write("Guess a country: ");
        }
        else if(userOption == "f")
        {
            string[] fruits = new string[] { "Pawpaw", "Orange", "Mango", "Cashew", "Pineapple" };
            generatedItem = fruits[randomNumber];

            Console.WriteLine("Pawpaw - Orange - Mango - Cashew - Pineapple");
            Console.Write("Guess a fruit: ");
        }
        userOption = Console.ReadLine();
        if (userOption == generatedItem)
        {
            Console.WriteLine("Yay! You got it!");
        }
        else
        {
            Console.Write("Bummer! You had it wrong. ");
            Console.Write("The correct option was ");
            Console.WriteLine(generatedItem);
        }
    }
}