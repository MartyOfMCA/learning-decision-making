internal class Program
{
    private static void Main(string[] args)
    {
        string[] countries = new string[] { "Ghana", "Togo", "Mali", "Nigeria", "Rwanda" };
        int randomNumber;

        randomNumber = new Random().Next(5);
        string generatedCountry = countries[randomNumber];

        Console.WriteLine("Ghana - Togo - Mali - Nigeria - Rwanda");
        Console.Write("Guess a country: ");
        string userOption = Console.ReadLine();
        if(userOption == generatedCountry)
        {
            Console.WriteLine("Yay! You got it!");
        }
        else
        {
            Console.Write("Bummer! You had it wrong. ");
            Console.Write("The correct option was ");
            Console.WriteLine(generatedCountry);
        }
    }
}