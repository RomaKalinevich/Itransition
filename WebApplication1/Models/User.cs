using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;


namespace WebApplication1.Models
{
    public class User : IdentityUser
    {
        public Guid companyId { get; set; }
    }
}
