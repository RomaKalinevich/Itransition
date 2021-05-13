using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;


namespace WebApplication1.Models
{
    public class User : IdentityUser
    {
        public bool isCompany { get; set; }
        public virtual ICollection<Company> Company { get; set; }
    }
}
