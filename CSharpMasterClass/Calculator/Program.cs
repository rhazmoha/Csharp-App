// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello!");
System.Console.WriteLine("input the first number: ");
int firstNumber = int.Parse(Console.ReadLine());
System.Console.WriteLine("Input the second number:");
int secondNumber = int.Parse(Console.ReadLine());

System.Console.WriteLine("What do you want to do with those numbers?");
System.Console.WriteLine("[A]dd");
System.Console.WriteLine("[S]ubtract");
System.Console.WriteLine("[M]ultiply");

string operation = Console.ReadLine();
Calculate(firstNumber, secondNumber, operation);

System.Console.WriteLine("Press any key to close");
Console.ReadKey();


void Calculate(int firstNumber, int secondNumber, string operation)
{
    if (EqualsCaseInsensitive(operation, "A"))
    {
        PrintFinalEquation(firstNumber, secondNumber, firstNumber + secondNumber, "+");
    }
    else if (EqualsCaseInsensitive(operation, "S"))
    {
        PrintFinalEquation(firstNumber, secondNumber, firstNumber - secondNumber, "-");

    }
    else if (EqualsCaseInsensitive(operation, "M"))
    {
        PrintFinalEquation(firstNumber, secondNumber, firstNumber * secondNumber, "*");

    }
    else
    {
        System.Console.WriteLine("Invalid option");
    }

}

void PrintFinalEquation(int num1, int num2, int result,
string @operator)
{
    System.Console.WriteLine(num1 + " " + @operator + " " + num2 + " = " + result);
}

bool EqualsCaseInsensitive(string left, string right)
{
    return left.ToUpper() == right.ToUpper();
}