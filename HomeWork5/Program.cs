string nameData = "Aimee,Sara,Jenny";
string[] names = nameData.Split(',');
string? textChoice;
bool isValidChoice;
int choice;


do
{
    Console.Write("Enter a number between 1 and 3 (enter 5 to quit): ");
    textChoice = Console.ReadLine();

    isValidChoice = int.TryParse(textChoice, out choice);

    if (isValidChoice == false)
    {
        Console.WriteLine("You did not enter a number silly!");
    }
    else if (choice <=0 || choice > 3 && choice != 5)
    {
        Console.WriteLine("Numbers between 1 and 3 nerd!");
    }

    switch (choice)
    {
        case 1:
            Console.WriteLine(names[0]);
            break;
        case 2:
            Console.WriteLine(names[1]);
            break;
        case 3:
            Console.WriteLine(names[2]);
            break;
        case 5:
            Console.WriteLine("...Goodbye");
            return;
    }

} while (isValidChoice == false || choice <= 0 || choice > 3 || choice != 5);

Console.ReadLine();



   