string userChoice;
var listTodo = new List<string>();

Console.WriteLine("Hello!");

do
{
    
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
            string toDoDescription;
            bool isTodoExists = true;

            do
            {
                System.Console.WriteLine("Enter the TODO description");
                toDoDescription = Console.ReadLine();

                if (toDoDescription == "")
                {
                    System.Console.WriteLine("The description cannot be empty.");

                }
                else
                {
                    isTodoExists = listTodo.Contains(toDoDescription);

                    if (isTodoExists)
                    {
                        System.Console.WriteLine("The description must be unique.");

                    }
                }

            } while (toDoDescription == "" || isTodoExists);

            listTodo.Add(toDoDescription);
            System.Console.WriteLine($"TODO successfully added: {toDoDescription}");
            System.Console.WriteLine();
            break;

        case "R":

            if (listTodo.Count == 0)
            {
                System.Console.WriteLine("No TODOs have been added yet.");
            }
            else
            {
                string userInput;
                int index;

                do
                {
                    System.Console.WriteLine("Select the index of the TODO you want to remove:");
                    for (int i = 0; i < listTodo.Count; i++)
                    {
                        System.Console.WriteLine($"{i + 1}. {listTodo[i]}");
                    }

                    userInput = Console.ReadLine();

                    if (userInput == "")
                    {
                        System.Console.WriteLine("Selected index cannot be empty.");
                    }
                    else if (!int.TryParse(userInput, out index))
                    {
                        System.Console.WriteLine("The given index is not valid.");

                    }

                } while (userInput == "" || !int.TryParse(userInput, out index));


                listTodo.RemoveAt(index - 1);

            }

            System.Console.WriteLine();
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