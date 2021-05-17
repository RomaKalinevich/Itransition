using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{

    public class Reward
    {
        public Reward()
        {
        }

        public Reward(Guid id)
        {
            Id = Guid.NewGuid();
        }
        public Reward(Guid companyId, string rewardDesc, ushort rewardPrice) : this()
        {
            this.companyId = companyId;
            this.rewardDesc = rewardDesc;
            this.rewardPrice = rewardPrice;
        }
        public Guid Id { get; set; }
        public Guid companyId { get; set; }
        public string rewardDesc { get; set; }
        public ushort rewardPrice { get; set; }
    }
}
