using System;
using System.Collections.Generic;


using System.ComponentModel.DataAnnotations;

using System.Linq;
using System.Web;

namespace git_test.Models
{
    public class Thing
    {

        [Key]
        public int ThingId { get; set; }
        public string Username { get; set; }
        [MaxLength(25,ErrorMessage = "Nazwa moze miec tylko 25 znakow")]
        [Display(Name = "Nazwa")]
        public string Name { get; set; }
        [Required]
        [Display(Name = "Opis")]
        public string Describe { get; set; }
        [Required]
        [Display(Name = "Tagi")]
        public string Tags { get; set; }

    }
}