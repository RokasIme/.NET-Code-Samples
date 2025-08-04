
using ShopApplication;

var shopConsole = new ShopConsole();

while (true)
{
    Console.WriteLine("Please enter the command: 'Buy','Show','List' or 'Exit'");

    var command = Console.ReadLine();

    if (command.StartsWith("Buy"))
    {
        shopConsole.ExecuteBuy();
    }
    else if (command.StartsWith("Show"))
    {
        shopConsole.ExecuteShowBalance();
    }
    else if (command.StartsWith("List"))
    {
        shopConsole.ExecutePrintInfo();
    }
    else if (command.StartsWith("Exit"))
    {
        Console.WriteLine("Exiting program...");
        break;
    }
    else
    {
        Console.WriteLine("Unknown command. Please try again.");
    }
    {
        
    }
}