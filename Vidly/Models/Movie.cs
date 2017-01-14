﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Vidly.Models
{
    public class Movie
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public Genre Genre { get; set; }

        [Required]
        [Display(Name = "Genre")]
        public byte GenreId { get; set; }

        [Required]
        [Display(Name = "Release Date")]
        [DisplayFormat(DataFormatString = "{0:dddd, MMMM dd, yyyy}")]
        public DateTime? ReleaseTime { get; set; }

        [DisplayFormat(DataFormatString = "{0:dddd, MMMM dd, yyyy}")]
        public DateTime? DateAdded { get; set; }

        [Required]
        [Range(1,20)]
        [Display(Name = "Number in Stock")]
        public byte NumberInStock { get; set; }

    }



}