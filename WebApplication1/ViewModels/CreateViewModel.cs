using WebApplication1.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace WebApplication1.ViewModels
{
    public class CreateViewModel
    {
        [Required]
        [Display(Name = "Name")]
        public string Name { get; set; }
        [Required]
        [Display(Name = "Add image")]
        public string mainImg { get; set; }
        [Required]
        [Display(Name = "Short description")]
        public string shortDesc { get; set; }
        [Required]
        [Display(Name = "Long description")]
        public string longDecs { get; set; }
        [Required]
        [Display(Name = "Price")]
        public ushort price { get; set; }
        public string ReturnUrl { get; set; }
        public IEnumerable<Company> companies { get; }
    }
}
