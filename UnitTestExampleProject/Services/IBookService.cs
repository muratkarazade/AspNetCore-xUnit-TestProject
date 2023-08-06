using ExampleAPI.Models;

namespace ExampleAPI.Services
{
    public interface IBookService
    {
        IEnumerable<Book> GetAll();
        Book Add(Book book);
        Book GetById(Guid id);
        Book Update(Book book);
        void Delete(Guid id);
    }
}
