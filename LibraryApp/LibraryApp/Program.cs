using LibraryApp.Controllers;
using Service.Helpers;

LibraryController controller = new LibraryController();

while (true)
{
    ConsoleColor.Cyan.WriteConsole("Please select one option: \n" +
        "");
    ConsoleColor.Cyan.WriteConsole("1-Create\n" +
        "2-Get all\n" +
        "3-Delete");

    Option: string option = Console.ReadLine();

    int selectedOption;

    bool isCorrectOption = int.TryParse(option, out selectedOption);

    if (isCorrectOption)
    {
        switch (selectedOption)
        {
            case 1:
                controller.Create();
                break;

            case 2:

            case 3:

            default:
                ConsoleColor.Red.WriteConsole("Please add correct option");
                goto Option;
        }
    }

    else
    {
        ConsoleColor.Red.WriteConsole("Please add correct format option");
    }
}