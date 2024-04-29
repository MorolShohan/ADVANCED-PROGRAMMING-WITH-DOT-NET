using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace WebApplicationMVCDemo.Models
{
    public class Employee
    {
        [Required(ErrorMessage = "Please Enter ID")]
        [Display(Name = "Please Enter the ID")]
        public int Id { get; set; }

        [Required]
        [Display(Name ="hello")]
        public string Name { get; set; }
        
        [Required]
        public double Salary { get; set; }
        
        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [DataType(DataType.Date)]
        public DateTime DOB { get; set; }
    }
}