using System.Collections.Generic;

namespace MoshPrep
{
    public class BookReposatory
    {
        public IEnumerable<Book> GetBooks()
        {
            return new List<Book>
            {
                new Book() { Title="ADO.NET Step by Step",Price=5},
                new Book() { Title="ASP.NET MVC",Price=7},
                new Book() { Title="ASP.net Web API",Price=12},
                new Book() { Title="C# Advanced Topics",Price=7},
                new Book() { Title="C# Advanced",Price=9},
            };
        }
    }
}

