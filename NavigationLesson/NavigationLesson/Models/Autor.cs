using System;
using System.Collections.Generic;

namespace NavigationLesson.Models
{
    public class Autor : Entity
    {
        public string FullName { get; set; }
        public ICollection<Book> Books { get; set; }
    }
}
