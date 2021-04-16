using System;
using System.ComponentModel.DataAnnotations;

namespace CoreWebAPI.Data.Models
{
    public class Book
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(250)]
        public string Title { get; set; }
    }
}
