using Hotel.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Hotel.Infra.Mappings
{
    public class ClientMapping : IEntityTypeConfiguration<Client>
    {
        public void Configure(EntityTypeBuilder<Client> builder)
        {
            builder.ToTable(name: nameof(Client) + "s");

            builder.HasKey(c => c.Id);
            builder.Property(c => c.Name).IsRequired();
            builder.Property(c => c.SurName).IsRequired();
            builder.Property(c => c.Email).IsRequired();
            builder.Property(c => c.CPF).IsRequired();

            builder.OwnsOne(c => c.Address, address =>
            {
                address.Property(e => e.Street).IsRequired();
                address.Property(e => e.Neighborhood).IsRequired();
                address.Property(e => e.Number).IsRequired();  
                address.Property(e => e.City).IsRequired();
            });
        }
    }
}
