// See https://aka.ms/new-console-template for more information

System.Console.WriteLine(CalculateSumOfNumbersBetween(1, 10));
return;
System.Console.WriteLine("Enter a word");
var userInput = Console.ReadLine();

while(userInput.Length < 15)
{
    userInput = userInput + 'a';
    System.Console.WriteLine(userInput);
}

System.Console.WriteLine("the loop is finished");


Console.WriteLine("Hello!");
Console.WriteLine("What do you want to do?");
Console.WriteLine("[S]ee all TODOs");
Console.WriteLine("[A]dd a TODO");
Console.WriteLine("[R]emove a TODO");
Console.WriteLine("[E]xit");

string userChoice = Console.ReadLine();


switch (userChoice)
{
    case "S":
        PrintSelectedOption("See All TODOs");
        break;

    case "A":
        PrintSelectedOption("Add a TODO");
        break;

    case "R":
        PrintSelectedOption("Remove a TODO");
        break;

    case "E":
        PrintSelectedOption("Exit");
        break;

    default:
        System.Console.WriteLine("Invalid choice");
        break;

}



char ConvertPointsToGrade(int points)
{

    return points switch
    {
        >= 90 => 'A',
        >= 80 => 'B',
        >= 70 => 'C',
    _ => 'D'
    };

    
}

bool IsLong(string input)
{
    return input.Length > 10;
}

void PrintSelectedOption(string selectedOption)
{
    System.Console.WriteLine("Selected Option: " + selectedOption);
}


#region Exercises

int CalculateSumOfNumbersBetween(int start, int end)
{
    int sum = 0;
    while (start <= end)
    {
        sum += start;
        start++;
    }

    return sum;
}


#endregion