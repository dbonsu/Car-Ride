using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRide.Domain.Entities
{
    public class Vehicle
    {
        public string Color { get; set; }
        public int Id { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public User Owner { get; set; }
        public Guid OwnerId { get; set; }
        public string Plate { get; set; }
        public long Year { get; set; }
    }
}