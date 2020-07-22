using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AggregatorMicroservice.Models
{
    public class Aggregrator
    {
        public User user { get; set; }
        public List<Order> orders { get; set; }
    }
}
