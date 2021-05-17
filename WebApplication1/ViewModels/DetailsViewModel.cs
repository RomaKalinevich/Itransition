using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;

namespace WebApplication1.ViewModels
{
    public class DetailsViewModel
    { 
        public List<Company> companies { get; set; } 
        public List<Likes> likes { get; set; }
        public List<Reward> rewards { get; set; }
    }
}
