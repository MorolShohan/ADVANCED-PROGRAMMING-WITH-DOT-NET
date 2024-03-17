﻿using System.ComponentModel.DataAnnotations;

namespace lab_02_ASP.NET.Models
{
    public class userModel
    {
        [Required(ErrorMessage = "Please Provide Name")]
        [StringLength(10, ErrorMessage = "Name cannot exceed 10 characters")]
        public string Name { get; set; }
        [Required]
        public string Username { get; set; }
        [Required]
        public string Gender { get; set; }
        [Required]
        public string Profession { get; set; }
        [Required]
        public string[] Hobbies { get; set; }
        [Required]
        public string dob { get; set; }

    }
}