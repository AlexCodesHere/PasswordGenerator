using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace PasswordGenerator.Models
{
    public class GeneratorViewModel
    {
        [Required]
        [MinLength(7)]
        public int Id { get; set; }

        [Required]
        [BindProperty, DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime Date { get; set; }
    }
}
