
using BookStoreApplication.Modules;

var bookList = new List<Book>();

while (true)
{
   

    Console.WriteLine("Please enter 'Add' or 'List' to start application or 'Del' for delete book from store");
    var command = Console.ReadLine()?.ToLower();

    if (command == "add")
    {
        Console.WriteLine("Please enter the book Name");
        var name = Console.ReadLine();
        var sameName = bookList.Where(b => b.Name == name)
            .ToList();
        if ( sameName.Count > 0) 
                {
            Console.WriteLine("Book with this name already exists.");
            continue;
        }

        Console.WriteLine("Please enter the Description");
        var description = Console.ReadLine();

        Console.WriteLine("Please enter the Amount of books");
        var amount = Console.ReadLine();

        var book = new Book(name, description, int.Parse(amount));
        bookList.Add(book);
    }
    else if (command == "list")
    {
        foreach (var book in bookList)
        {
            Console.WriteLine($"Book name: {book.Name}, Description: {book.Description}, amount: {book.Amount}");
        }
    }
    else if (command == "del")
    {
        Console.WriteLine("Please enter the book Name to delete");
        var nameToDelete = Console.ReadLine();
        var bookToDelete = bookList.FirstOrDefault(b => b.Name == nameToDelete);
        
        if (bookToDelete != null)
        {
            bookList.Remove(bookToDelete);
            Console.WriteLine($"Book '{nameToDelete}' has been deleted.");
        }
        else
        {
            Console.WriteLine($"Book '{nameToDelete}' not found.");
        }
    }
    else
    {
        Console.WriteLine("Invalid command. Please enter 'Add' or 'List'.");
    }

  


}