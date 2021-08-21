using api.Models;

namespace api.Queries
{
    public class Query
    {
        public Book GetBook() => new Book { Title = "The Kite Runner", Author = "Dennis WAy" };
    }
}