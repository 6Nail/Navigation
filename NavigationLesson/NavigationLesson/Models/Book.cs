using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NavigationLesson.Models
{
   // [Table("books")]
    public class Book : Entity
    {
        //[Column("name")]
        //[Required]
        public string Title { get; set; }
        public Guid AutorId { get; set; }
        //[ForeignKey("AutorId")]
        
        public Autor Autor { get; set; }

    }
}
