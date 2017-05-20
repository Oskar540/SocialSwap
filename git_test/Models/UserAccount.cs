using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace git_test.Models
{
    public class UserAccount
    {
        [Key] 
        public int UserId { get; set; }
        [Required(ErrorMessage = "Imię jest wymagane")]
        [Display(Name = "Imie")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "Nazwisko jest wymagane")]
        [Display(Name = "Nazwisko")]
        public string LastName { get; set; }
        [Required(ErrorMessage = "Email jest wymagany")]
        [RegularExpression(@"^([\w-\.]+)@((\[[0-9]{1,3]\.)|(([\w-]+\.)+))([a-zA-Z{2,4}|[0-9]{1,3})(\]?)$", ErrorMessage = "Wpisz poprawny email")]
        [Display(Name = "Email")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Podaj Nick")]
        [Display(Name = "Nazwa")]
        public string Username { get; set; }
        [Required(ErrorMessage = "Wpisz hasło")]
        [MinLength(8,ErrorMessage ="Hasło za krótkie")]
        [DataType(DataType.Password)]
        [Display(Name = "Hasło")]
        public string Password { get; set; }
        
        [Compare("Password",ErrorMessage = "Hasła nie pasują")]
        [DataType(DataType.Password)]
        [Required(ErrorMessage = "Potwierdź hasło")]
        [Display(Name = "Potwierdź hasło")]
        public string ConfirmPassword { get; set; }
        [Required(ErrorMessage = "to pole jest wymagane")]
        [Display(Name = "Opis")]
        public string Describe { get; set; }
        [Required(ErrorMessage = "to pole jest wymagane")]
        [Display(Name = "Lokacja")]
        public string Location { get; set; }
        [Required(ErrorMessage = "to pole jest wymagane")]
        [Display(Name = "Numer")]
        public string Numer { get; set; }
        [Required(ErrorMessage = "to pole jest wymagane")]
        [Display(Name = "Hobby")]
        public string Hobby { get; set; }


    }
}