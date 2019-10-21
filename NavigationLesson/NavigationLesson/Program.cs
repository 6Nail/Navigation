using NavigationLesson.DataAccess;
using NavigationLesson.Models;
using System;
using System.Linq;

namespace NavigationLesson
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new LIbraryContext())
            {
                //Autor autor = new Autor
                //{
                //    FullName = "Abay Pushkin"
                //};
                //Book book = new Book
                //{
                //    Title="Nad Propastiu porzhi",
                //    Autor=autor
                //};

                //context.Add(book);
                //context.SaveChanges();
                var result = context.Books.ToList();
            }
        }
    }
}
