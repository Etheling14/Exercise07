
int stratum;
int numberscredits;
decimal ValueCredits;
decimal ValueTuition;
decimal ValueSubsidy;

do
{
    Console.ForegroundColor = ConsoleColor.Magenta;
    Console.WriteLine("-------------------------------------------------------------------------------");
    Console.ForegroundColor = ConsoleColor.White;
    RequestData(out stratum, out numberscredits, out ValueCredits);
    ValueTuition = CalculateTuition(stratum, numberscredits, ValueCredits);
    ValueSubsidy = CalculateSubsidy(stratum);
    ShowResults(ValueTuition, ValueSubsidy);
}while(true);   

static void RequestData(out int stratum, out int numbersCredits, out decimal valueCredits)
{
    Console.WriteLine($"Enter the stratum..............");
    stratum = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine($"Enter the number credits.......");
    numbersCredits = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine($"Enter the value credits.........");
    valueCredits = Convert.ToDecimal(Console.ReadLine());
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
    Console.WriteLine("Press enter to calculate another salary or Ctrl + C to finish.");
    Console.ReadKey();
}