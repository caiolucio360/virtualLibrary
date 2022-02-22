using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace VirtualLibrary.Models
{
    public class Book
    {
        public Guid Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string Title { get; set; }

        [Required]
        public Author Author { get; set; }

        [Required]
        [MaxLength(50)]
        public Publisher Publisher { get; set; }

        [Required]
        public DateTime ReleaseDate { get; set; } 
    }
}
