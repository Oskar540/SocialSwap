using System;
using System.Collections.Generic;
<<<<<<< HEAD
=======
using System.ComponentModel.DataAnnotations;
>>>>>>> refs/remotes/origin/master
using System.Linq;
using System.Web;

namespace git_test.Models
{
    public class Thing
    {
<<<<<<< HEAD
=======
        [Key]
        public int ThingId { get; set; }
        public int UserId { get; set; }
        [MaxLength(25,ErrorMessage = "Nazwa moze miec tylko 25 znakow")]
        public string Name { get; set; }
        [Required]
        public string Describe { get; set; }
        [Required]
        public string Tags { get; set; }
>>>>>>> refs/remotes/origin/master
    }
}