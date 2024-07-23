string? readResult;
int numericValue = 0;
bool validNumber = false;
Console.WriteLine("Enter an integer value between 5 and 10");
do
{
    readResult = Console.ReadLine();
    validNumber = int.TryParse(readResult, out numericValue);

    if (!validNumber)
        Console.WriteLine("Sorry, you entered an invalid number, please try again");
    else if (numericValue <= 5 || numericValue >= 10)
        Console.WriteLine("You entered 2. Please enter a number between 5 and 10.");


} while (!validNumber || numericValue <= 5 || numericValue >= 10);

Console.WriteLine($"Your input value ({numericValue}) has been accepted.");