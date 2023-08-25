using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.Domain.Models
{
    public class Address
    {
        public Guid Id { get; set; }
        public string Street { get; set; }
        public string Neighborhood { get; set; }
        public int number { get; set; }
        public string City { get; set; }
    }
}
