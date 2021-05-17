using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class Rating
    {
        public Guid Id { get; set; }
        public Guid CompanyId { get; set; }
        public ushort Rate { get; set; }
        public int Count { get; set; }
        public int Sum { get; set; }
    }
}
