﻿string[] myStrings = new string[2] { "I like pizza. I like roast chicken. I like salad", "I like all three of the menu choices" };
int periodLocation = 0;

for(int i = 0; i < myStrings.Length; i++)
{
    periodLocation = myStrings[i].IndexOf(".");

    while(periodLocation != -1)
    {
        myStrings[i] = myStrings[i].Remove(periodLocation, 1); // ピリオドを削除
        Console.WriteLine(myStrings[i]);
        periodLocation = myStrings[i].IndexOf("."); // 次のピリオドの位置を再取得

    }




    // periodLocation = myStrings[i].IndexOf(".");

    // if (periodLocation != -1)
    // {
    //     Console.WriteLine(myStrings[i].Remove(periodLocation));
    // }
    // else
    // {
    //     Console.WriteLine(myStrings[i]); // ピリオドが見つからない場合、元の文字列を表示
    // }

    // periodLocation = myString.IndexOf(".");
    // while (periodLocation != -1)
    // {
    //     Console.WriteLine(myString.Remove(periodLocation));
    //     string test = myString.Remove(periodLocation);

    // }
    // Console.WriteLine(myString.IndexOf("."));
}







// string? readResult;
// string answer;
// string[] role = { "Administrator", "Manager", "User" };
// bool roleMatch;

// Console.WriteLine("Enter your role name (Administrator, Manager, or User)");
// do
// {
//     readResult = Console.ReadLine();
//     roleMatch = false;

//     if (readResult != null)
//     {
//         answer = readResult.Trim().ToLower();

//         foreach (string str in role)
//         {
//             if (answer.Equals(str.ToLower()))
//             {
//                 roleMatch = true;
//                 break;
//             }
//         }
//     }

//     if (!roleMatch)
//         Console.WriteLine($"The role name that you entered, \"{readResult}\" is not valid. Enter your role name (Administrator, Manager, or User)");

// } while (!roleMatch);

// Console.WriteLine($"Your input value ({readResult}) has been accepted.");



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