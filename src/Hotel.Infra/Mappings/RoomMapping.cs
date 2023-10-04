using Hotel.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Hotel.Infra.Mappings
{
    public class RoomMapping : IEntityTypeConfiguration<Room>
    {
        public void Configure(EntityTypeBuilder<Room> builder)
        {
            builder.ToTable(name: nameof(Room) + "s");

            builder.HasKey(q => q.Id);
            builder.Property(q => q.Capacity).IsRequired();
            builder.Property(q => q.Suite).IsRequired();
            builder.Property(q => q.Available).IsRequired();
            builder.Property(q => q.DoubleBads).IsRequired();
            builder.Property(q => q.SingleBads).IsRequired(); 
        }
    }
}
