using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.ViewModels
{
    public class RewardViewModel
    {
        [Required]
        [Display(Name = "Description")]
        public string rewardDesc { get; set; }
        [Required]
        [Display(Name = "Price")]
        public ushort rewardPrice { get; set; }
        public Guid Id { get; set; }
    }
}
