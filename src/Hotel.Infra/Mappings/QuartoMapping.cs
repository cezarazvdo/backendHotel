using Hotel.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.Infra.Mappings
{
    public class QuartoMapping : IEntityTypeConfiguration<Quarto>
    {
        public void Configure(EntityTypeBuilder<Quarto> builder)
        {
            builder.ToTable(name: nameof(Quarto) + "s");

            //public Guid Id { get; set; }
            builder.HasKey(q => q.Id);
            //public int Capacity { get; set; }
            builder.Property(q => q.Capacity).IsRequired();
            //public bool Suite { get; set; }
            builder.Property(q => q.Suite).IsRequired();
            //public bool Available { get; set; }
            builder.Property(q => q.Available).IsRequired();
            //public int DoubleBads { get; set; }
            builder.Property(q => q.DoubleBads).IsRequired();
            //public int singleBads { get; set; }
            builder.Property(q => q.singleBads).IsRequired();
        }
    }
}
