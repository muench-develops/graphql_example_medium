using GraphQL.AspNet.Attributes;
using GraphQL.AspNet.Controllers;

namespace GraphQL_Example_Medium;

public class BookController : GraphController
{
    [QueryRoot("book")]
    public Book RetrieveBook(int id)
    {
        // Here would be the code to retrieve the book from the database
        return new Book
        {
            Id = id,
            Author = "Stephen King",
            Title = "The Shining",
            Genre = "Horror",
            Pages = 567
        };
    }
}