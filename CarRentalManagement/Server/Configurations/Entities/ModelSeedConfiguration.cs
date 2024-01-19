using CarRentalManagement.Shared.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CarRentalManagement.Server.Configurations.Entities
{
    public class ModelSeedConfiguration : IEntityTypeConfiguration<Model>
    {
        public void Configure(EntityTypeBuilder<Model> builder)
        {
            builder.HasData(
                new Model
                {
                    id = 1,
                    Name = "3 Series",
                    Datecreated = DateTime.Now,
                    Dateupdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                },
                new Model
                {
                    id = 2,
                    Name = "X5",
                    Datecreated = DateTime.Now,
                    Dateupdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                },
                new Model
                {
                    id = 3,
                    Name = "Prius",
                    Datecreated = DateTime.Now,
                    Dateupdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                },
                 new Model
                 {
                     id = 4,
                     Name = "Rav4",
                     Datecreated = DateTime.Now,
                     Dateupdated = DateTime.Now,
                     CreatedBy = "System",
                     UpdatedBy = "System"
                 }
            );
        }
    }
}


