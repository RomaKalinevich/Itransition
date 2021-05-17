using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class Company
    {
        public Company()
        {
            Id = Guid.NewGuid();
        }

        public Company(string name, string mainImg, string video, string shortDesc, string longDesc,
                       ushort price) : this()
        {
            this.Name = name;
            this.mainImg = mainImg;
            this.video = video;
            this.shortDesc = shortDesc;
            this.longDecs = longDesc;
            this.price = price;
            this.likesDown = 0;
            this.likesUp = 0;
            this.currentSum = 0;
        }

        public Guid Id { get; set; }
        public string Name { get; set; }
        public string mainImg { get; set; }
        public string img { get; set; }
        public string shortDesc { get; set; }
        public string longDecs { get; set; }
        public ushort price { get; set; }
        public ushort currentSum { get; set; }
        public ushort likesUp { get; set; }
        public ushort likesDown { get; set; }
        public string video { get; set; }

    }
}
