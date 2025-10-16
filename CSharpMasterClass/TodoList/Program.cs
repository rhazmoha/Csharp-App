string userChoice;
var listTodo = new List<string>()
{
    "make a cake",
"watch TV"
};


do
{
    Console.WriteLine("Hello!");
    Console.WriteLine("What do you want to do?");
    Console.WriteLine("[S]ee all TODOs");
    Console.WriteLine("[A]dd a TODO");
    Console.WriteLine("[R]emove a TODO");
    Console.WriteLine("[E]xit");

    userChoice = Console.ReadLine().ToUpper();

    switch (userChoice)
    {
        case "S":

            if (listTodo.Count == 0)
            {
                System.Console.WriteLine("No TODOs have been added yet.");

            }
            else
            {
                for (int i = 0; i < listTodo.Count; i++)
                {
                    System.Console.WriteLine($"{i + 1}. {listTodo[i]}");
                }

            }

            System.Console.WriteLine();

            break;

        case "A":
            break;

        case "R":
            break;

        case "E":
            break;
        default:
            System.Console.WriteLine("Incorrect input");
            break;
    }


} while (userChoice != "E");












#region Exercises



#endregion