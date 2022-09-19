class labOne
{
    static void Main(string[] args)
    {
        // Declare variables
        string myNameIs = "Adam.";
        int numberTwo = 2;
        float numberPointFive = 5.5f;
        bool thisIsFalse = false;
        char anyCharacter = '$';

        //Print variables to console
        Console.WriteLine(myNameIs);
        Console.WriteLine(numberTwo);
        Console.WriteLine(numberPointFive);
        Console.WriteLine(anyCharacter);
        Console.WriteLine("Is it true or false? The answer is, " + thisIsFalse);

        //Ask for some input and save answers for later use
        Console.WriteLine("What is your favorite season?");
        string faveSeason = Console.ReadLine();
        Console.WriteLine("What is your favorite car?");
        string faveCar = Console.ReadLine();
        Console.WriteLine("What is your favorite Tv show?");
        string faveTvShow = Console.ReadLine();
        Console.WriteLine("How much money have you spent on streaming services this year?");
        decimal moneySpent = decimal.Parse(Console.ReadLine());

        //Repeat back the info 
        Console.WriteLine("Your favorite season is " + faveSeason);
        Console.WriteLine("Your favorite car is the " + faveCar);
        Console.WriteLine("Your favorite TV show is " + faveTvShow);
        Console.WriteLine("The ammount you've spent on streaming is " + moneySpent.ToString("C2"));

        //create a madlib
        Console.WriteLine("You will now be creating a madlib, please provide the following words.");
        Console.WriteLine("Please provide an Adjective.");
        string madLibAdjective = Console.ReadLine();
        Console.WriteLine("Please provide a Noun.");
        string madLibNoun = Console.ReadLine();
        Console.WriteLine("Please provide a Verb.");
        string madLibVerb = Console.ReadLine();
        Console.WriteLine("You would not believe it if you saw a {0} {1} that could {2}.", madLibAdjective, madLibNoun, madLibVerb);

        //casting section
        byte puddle = 100;
        short pond = 29456;
        int lake = 100000; //one-hundred thousand
        long ocean = 5;
    }

}
