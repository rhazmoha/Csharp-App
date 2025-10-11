
// See https://aka.ms/new-console-template for more information


using System.Runtime.CompilerServices;

Console.WriteLine("Hello!");
Console.WriteLine("What do you want to do?");
Console.WriteLine("[S]ee all TODOs");
Console.WriteLine("[A]dd a TODO");
Console.WriteLine("[R]emove a TODO");
Console.WriteLine("[E]xit");

var userChoice = Console.ReadLine();
bool isLong = IsLong(userChoice);

bool IsLong(string input)
{
    if(input.Length > 10)
    {
        return true;
    }else
    {
        return false;
    }
}

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




void PrintSelectedOption(string selectedOption)
{
    System.Console.WriteLine("Selected Option: " + selectedOption);
}
