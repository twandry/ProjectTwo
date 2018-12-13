using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ProjectTwo.Models
{
    [Table("Users")]
    public class Users
    {
        [Key]
        public int userID { get; set; }

        [DisplayName("First Name")]
        [Required(ErrorMessage = "Please enter your first Name!")]
        public string userFName { get; set; }

        [DisplayName("Last Name")]
        [Required(ErrorMessage = "Please enter your last Name!")]
        public string userLName { get; set; }

        [EmailAddress]
        [DisplayName("Email")]
        [Required(ErrorMessage = "Please enter a valid email!")]
        public string userEmail { get; set; }

        [NotMapped]
        [Compare("userEmail")]
        [DisplayName("Confirm Email")]
        [Required(ErrorMessage = "Please confirm your email address")]
        public string confirmEmail { get; set; }

        [DisplayName("Password")]
        [PasswordPropertyText]
        [Required(ErrorMessage = "Please enter your password!")]
        public string password { get; set; }

        [NotMapped]
        [Compare("password")]
        [DisplayName("Confirm Password")]
        [PasswordPropertyText]
        [Required(ErrorMessage = "Please confirm your password!")]
        public string confirmPassword { get; set; }
    }
}