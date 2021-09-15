using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DemoASPFramework.Models
{
    public class Article
    {
        public int Id { get; set; }
        [Required]
        public string Libelle { get; set; }
        [Required]
        [DataType(DataType.Currency)]
        public int Prix { get; set; }

        [EmailAddress]
        [RegularExpression(@"[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,4}", ErrorMessage ="Doit être une adresse e-mail valable : example@mail.com")]
        public string Email { get; set; }
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "Les deux mots de passe doivent correspondre")]
        public string ConfirmPassword { get; set; }
        public string Description { get; set; }
    }
}