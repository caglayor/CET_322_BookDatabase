// See https://aka.ms/new-console-template for more information
using CET_322_BookDatabase.Models;


Console.WriteLine("Hello, World!");

//Adding
//using (var context = new BookDataContext())
//{

//    var publisher = context.Publishers.FirstOrDefault(p => p.Name == "Everest Yayınları");


//    if (publisher == null)
//    {
//        publisher = new Publisher { Name = "Everest Yayınları" };
//        context.Publishers.Add(publisher);
//        context.SaveChanges();
//    }


//    var book = new Book
//    {
//        Title = "Eskici ve Oğulları",
//        Author = "Orhan Kemal",
//        PublisherId = publisher.Id,

//    };

//    context.Books.Add(book);
//    context.SaveChanges();
//}


//Updating
//void UpdateBook(int id, string title, string author)
//{
//    using (var context = new BookDataContext())
//    {
//        var book = context.Books.Find(id);

//        if (book != null)
//        {
//            book.Title = title;
//            book.Author = author;

//            context.SaveChanges();

//            Console.WriteLine("Book updated successfully!");
//        }
//        else
//        {
//            Console.WriteLine("Book not found!");
//        }
//    }
//}


//UpdateBook(5, "Yüzyıllık Yalnızlık", "Gabriel Marquez");


// Getting all books
void GetAllBooks()
{
    using (var context = new BookDataContext())
    {
        var books = context.Books.ToList();


        foreach (var book in books)
        {
            Console.WriteLine($"Title: {book.Title}");
            Console.WriteLine($"Author: {book.Author}");
        }
    }
}
GetAllBooks();

