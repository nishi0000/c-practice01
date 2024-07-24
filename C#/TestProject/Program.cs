


string? readResult;
string[] role = ["Administrator", "Manager", "User"];
bool roleMatch = false;
Console.WriteLine("Enter your role name (Administrator, Manager, or User)");
do
{
    readResult = Console.ReadLine();
    readResult = readResult.Trim().ToLower();

    foreach (string str in role)
    {
        if (readResult.Equals(str))
            roleMatch = true;
    }

    if (roleMatch)
        Console.WriteLine('The role name that you entered, "{}" is not valid. Enter your role name (Administrator, Manager, or User)');

} while (!roleMatch);

Console.WriteLine($"Your input value ({readResult}) has been accepted.");



// string? readResult;
// int numericValue = 0;
// bool validNumber = false;
// Console.WriteLine("Enter an integer value between 5 and 10");
// do
// {
//     readResult = Console.ReadLine();
//     validNumber = int.TryParse(readResult, out numericValue);

//     if (!validNumber)
//         Console.WriteLine("Sorry, you entered an invalid number, please try again");
//     else if (numericValue <= 5 || numericValue >= 10)
//         Console.WriteLine("You entered 2. Please enter a number between 5 and 10.");


// } while (!validNumber || numericValue <= 5 || numericValue >= 10);

// Console.WriteLine($"Your input value ({numericValue}) has been accepted.");