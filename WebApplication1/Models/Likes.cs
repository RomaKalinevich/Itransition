using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class Likes
    {
        public Likes()
        {
            Id = Guid.NewGuid();
        }
        public Guid Id { get; set; }
        public Guid CompanyId { get; set; }
        public int likeUp { get; set; }
        public int likeDown { get; set; }
    }
}
