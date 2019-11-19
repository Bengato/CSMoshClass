using System;
using System.IO;
using System.Linq;

namespace MoshPrep
{
    class Program
    {
        static void Main(string[] args)
        {
            //******************************************************************************************************
            //Generics
            //var numbers = new GenericList<int>();
            //numbers.Add(30);
            //var books = new GenericList<string>();
            //books.Add("Harry Potter");
            //var dictionary = new GenericDictionary<string, string>();
            //dictionary.Add("C#", "Programming language");
            //var number = new Nullable<int>(5);
            //Console.WriteLine("Has Value?"+number.HasValue);
            //Console.WriteLine("Value:"+number.GetValueOrDefault());
            //******************************************************************************************************
            // Delegates
            //var processor = new PhotoProcessor();
            //var filters = new PhotoFilters();
            //Action<Photo> filterHandler = filters.ApplyBrightness;
            //filterHandler += filters.ApplyContrast;
            //filterHandler += RemoveRedEye;
            //processor.Process("Photo.jpg", filterHandler);
            //******************************************************************************************************
            // Lambda Expressions
            //()=>...
            //x=>...
            //(x,y,z)=>...
            //Func<int, int> square = number => number * number;
            //Console.WriteLine(square(5));
            //const int factor = 5; 
            //Func<int, int> multiplier = n => n * factor;
            //Console.WriteLine(multiplier(10));
            ////
            //var books = new BookReposatory().GetBooks();
            //var cheapBooks = books.FindAll(book => book.Price < 10);
            //foreach(var book in cheapBooks)
            //{
            //    Console.WriteLine(book.Title);
            //}
            //******************************************************************************************************
            // Events and delegates
            //var video = new Video() { Title = "Video 1" };
            //var videoEncoder = new VideoEncoder();//publisher
            //var mailService = new MailService();//subscriber
            //var messageService = new MessegaService();//subscriber
            //videoEncoder.VideoEncoded += mailService.OnVideoEncoded;//adding mailService as a subscriber to videoEncoder
            //videoEncoder.VideoEncoded += messageService.OnVideoEncoded;//adding messageService as a subscriber to videoEncoder
            //videoEncoder.Encode(video);
            //******************************************************************************************************
            // Extension Methods
            //string post = "This is supposed to be a very very very very long blog post about alot of stuff that mean blah blah blah...";
            //var shortenedPost = post.Shorten(5);
            //Console.WriteLine(shortenedPost);
            //******************************************************************************************************
            // LINQ
            //var books = new BookReposatory().GetBooks();
            ////LINQ Query operators
            //var cheaperBooks= 
            //    from b in books
            //    where b.Price<10
            //    orderby b.Title
            //    select b.Title;

            ////LINQ Extension Methods
            //var cheapBooks = books
            //                    .Where(book => book.Price < 10)
            //                    .OrderBy(book=>book.Title)
            //                    .Select(book=>book.Title);

            ////var singleBook = books.Single(b => b.Title == "ASP.NET MVC");
            //var singleBook = books.SingleOrDefault(b => b.Title == "ASP.NET MVC");
            //var firstBook = books.First(b => b.Title == "C# Advanced");
            //var lastBook = books.Last(b => b.Title == "C# Advanced");
            //var pagedBooks = books.Skip(2).Take(3);



            //foreach (var book in cheapBooks)
            //{
            //    Console.WriteLine(book);
            //}
            //******************************************************************************************************
            // Nullables
            //DateTime? date = null;
            //// Nullable<DateTime> date = null; is the same
            //Console.WriteLine("GetValueOrDefault():"+date.GetValueOrDefault());// will return default in this case
            //Console.WriteLine("HasValue:"+date.HasValue);//will return false in this case
            //Console.WriteLine("Value:"+date.Value);// will crash the programn in this case
            ////Null coalising operator will get value if date has one and today if its null
            //DateTime date2 = date ?? DateTime.Today;
            //******************************************************************************************************
            // Exception Handling
            //StreamReader streamReader = null;
            //try
            //{
            //    streamReader = new StreamReader(@"D:\newtxtfile.txt");
            //    var content = streamReader.ReadToEnd();
            //    var calculator = new Calculator();
            //    var result = calculator.Divide(5, 0);
            //}
            //catch (DivideByZeroException) { }
            //catch (ArithmeticException) { }
            //catch (Exception)
            //{
            //    Console.WriteLine("Sorry, an unexpected error has accured");
            //}
            //finally
            //{
            //    if (streamReader != null)
            //    {
            //        streamReader.Dispose();
            //    }
            //}
            //******************************************************************************************************
            // Asynchronos Programming



        }
        static void RemoveRedEye(Photo photo)
        {
            Console.WriteLine("Red eyes removed!");
        }
        static bool isCheaperThanTenDollars(Book book)
        {
            return book.Price < 10;
        }
    }
}
