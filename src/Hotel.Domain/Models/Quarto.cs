using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.Domain.Models
{
    public class Quarto
    {
        public Guid Id { get; set; }
        public int Capacity { get; set; }
        public bool Suite { get; set; }
        public bool Available { get; set; }
        public int DoubleBads { get; set; }
        public int singleBads { get; set; }
    }
}
