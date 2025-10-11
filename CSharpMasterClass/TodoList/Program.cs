// See https://aka.ms/new-console-template for more information




Console.WriteLine("Hello!");
Console.WriteLine("What do you want to do?");
Console.WriteLine("[S]ee all TODOs");
Console.WriteLine("[A]dd a TODO");
Console.WriteLine("[R]emove a TODO");
Console.WriteLine("[E]xit");

string userChoice = Console.ReadLine();
int number = int.Parse(userChoice);
System.Console.WriteLine($"number is {number}");


/* if (userChoice == "S")
{
    PrintSelectedOption("See All TODOs");
}
else if (userChoice == "A")
{
    PrintSelectedOption("Add a TODO");
}
else if (userChoice == "R")
{
    PrintSelectedOption("Remove a TODO");
}
else if (userChoice == "E")
{
    PrintSelectedOption("Exit");

} */

string FormatDate(int year, int month, int day)
{
    return $"{year}/{month}/{day}";
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



#endregion