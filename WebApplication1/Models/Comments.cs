﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class Comments
    {
        public int Id { get; set; }
        public int CompanyId { get; set; }
        public string UserId { get; set; }
        public string Text { get; set; }
        public int Likes { get; set; }
    }
}
