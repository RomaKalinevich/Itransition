using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class Likes
    {
        public string Id { get; set; }
        public string CompanyId { get; set; }
        public bool Like { get; set; }
        public int CommentId { get; set; }
    }
}
