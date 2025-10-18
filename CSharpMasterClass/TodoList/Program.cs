/* 
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
                bool isValidIndex = false;
                

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
                    else
                    {
                        isValidIndex = int.TryParse(userInput, out index);

                        if (!isValidIndex)
                        {
                            System.Console.WriteLine("The given index is not valid.");
                        }else
                        {
                            var deletedTodoList = listTodo[index - 1];
                            System.Console.WriteLine($"TODO removed: {deletedTodoList}");
                            listTodo.RemoveAt(index - 1);
                            
                        }
                        

                    }

                } while (userInput == "" || !isValidIndex);

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


#endregion

 */

var todos = new List<string>();

Console.WriteLine("Hello!");

bool shallExit = false;
while (!shallExit)
{
    Console.WriteLine("What do you want to do?");
    Console.WriteLine("[S]ee all TODOs");
    Console.WriteLine("[A]dd a TODO");
    Console.WriteLine("[R]emove a TODO");
    Console.WriteLine("[E]xit");

    var userChoice = Console.ReadLine().ToUpper();

    switch (userChoice)
    {
        case "E":
            shallExit = true;
            break;
        case "S":
            System.Console.WriteLine("See all TODOs");
            break;
        case "A":
            System.Console.WriteLine("Add a TODO");
            break;
        case "R":
            System.Console.WriteLine("Remove a TODO");
            break;

        default:
            System.Console.WriteLine("Invalid choice");
            break;
    }
}

void AddTodo()
{
    System.Console.WriteLine("Enter TODO description");
    var description = Console.ReadLine();

    if(description == "")
    {
        System.Console.WriteLine("the description cannot be empty");
    }else if (todos.Contains(description))
    {
        System.Console.WriteLine("The description must be unique");
    }else
    {
        
    }
}

#region Exercises



#endregion