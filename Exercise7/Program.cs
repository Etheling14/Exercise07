
int stratum;
int numberscredits;
decimal ValueCredits;
decimal ValueTuition;
decimal ValueSubsidy;
Console.BackgroundColor = ConsoleColor.DarkCyan;
Console.Clear();
do
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("-------------------------------------------------------------------------------");
    Console.ForegroundColor = ConsoleColor.White;
    stratum = RequestInt("Enter the stratum: ");
    numberscredits = RequestInt("Enter the numbers credits: ");
    ValueCredits = RequestDecimal("Enter the value credist: ");
    ValueTuition = CalculateTuition(stratum, numberscredits, ValueCredits);
    ValueSubsidy = CalculateSubsidy(stratum);
    ShowResults(ValueTuition, ValueSubsidy);
}while(true);   

static int RequestInt(string message)
{
    Console.Write(message);
    var inputString = Console.ReadLine();   
    try
    {
        return Convert.ToInt32(inputString);
    }
    catch (Exception)
    {
        throw new Exception("You must enter a valid integer number.");
    }
    
}

static decimal RequestDecimal(string message)
{
    Console.Write(message);
    var inputDecimal = Console.ReadLine();
    try
    {
        return Convert.ToDecimal(inputDecimal);
    }
    catch (Exception)
    {
        throw new Exception("You must enter a valid integer number.");
    }
}

static decimal CalculateTuition(int stratum, int numbersCredits, decimal valueCredits)
{
    decimal value;
    if (numbersCredits <= 20)
    {
        value = numbersCredits * valueCredits;
    }
    else
    { 
        value = 20 * valueCredits + (numbersCredits - 20);
    }

    if (stratum == 1) return value * 0.2M;
    if (stratum == 2) return value * 0.5M;
    if (stratum == 3) return value * 0.7M;
    return value;
}

static decimal CalculateSubsidy(int stratum)
{
    if (stratum == 1) return 200000;
    if (stratum == 2) return 100000;
    return 0; 
}

static void ShowResults(decimal ValueTuition, decimal ValueSubsidy)
{
    Console.WriteLine($"The value of the tuition is: {ValueTuition:C2}");
    Console.WriteLine($"The value of the Subsidy is: {ValueSubsidy:C2}");
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine($"----------------------------------------------");
    Console.ForegroundColor = ConsoleColor.White;
    Console.WriteLine($"Press enter to calculate another salary or Ctrl + C to finish.");
    Console.ReadKey();
}