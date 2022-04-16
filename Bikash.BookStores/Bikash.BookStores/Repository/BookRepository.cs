
using Bikash.BookStores.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bikash.BookStores.Repository
{
    public class BookRepository
    {
        public List<Book> GetAllBooks()
        {
            return DataSource();
        }

        public Book GetBookById(int id)
        {
            return DataSource().Where(x => x.Id == id).FirstOrDefault();
        }

        public List<Book> SearchBook(string title, string AuthorName)
        {
            return DataSource().Where(x => x.Title.Contains(title) && x.Author.Contains(AuthorName)) .ToList();
        
        }

        private List<Book> DataSource()
        {
            return new List<Book>()
            {
                new Book(){ Id = 1, Title = "MVC", Author = "Bikash", Description="This is the description for MVC Book",Categories="Programming",TotalPage="335",Language="English"},
                new Book(){ Id = 2, Title = "Java", Author = "Kajol", Description="This is the description for Java Book",Categories="Framework",TotalPage="999",Language="English"},
                new Book(){ Id = 3, Title = "PHP", Author = "Hari", Description="This is the description for PHP Book",Categories="Programming",TotalPage="133",Language="English"},
                new Book(){ Id = 4, Title = "CS", Author = "Ram", Description="This is the description for CS Book",Categories="Developer",TotalPage="544",Language="English"},
                new Book(){ Id = 5, Title = ".net", Author = "shyam", Description="This is the description for .net Book",Categories="Programming",TotalPage="655",Language="English"},
                new Book(){ Id = 6, Title = "Python", Author = "Kali", Description="This is the description for Python Book",Categories="Programming",TotalPage="876",Language="English"}
            };
        }
        
    }
}
