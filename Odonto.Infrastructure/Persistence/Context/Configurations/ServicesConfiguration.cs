using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Odonto.Domain.Entities;

namespace Odonto.Infrastructure.Persistence.Context.Configurations
{
    internal sealed class ServicesConfiguration : IEntityTypeConfiguration<Services>
    {
        public void Configure(EntityTypeBuilder<Services> builder)
        {
            builder.ToTable(nameof(Services));

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id)
                .HasColumnName("SER_SERVICE_ID")
                .ValueGeneratedOnAdd();

            builder.Property(x => x.Name)
                .HasColumnName("SER_NAME")
                .HasMaxLength(100)
                .IsRequired();

            builder.Property(x => x.Description)
                .HasColumnName("SER_DESCRIPTION")
                .HasMaxLength(1000)
                .HasDefaultValue(null);

            builder.Property(X => X.Status)
                .HasColumnName("SER_STATUS")
                .HasDefaultValue(1);

            builder.OwnsOne(x => x.AuditInfo, audit =>
            {
                audit.Property(a => a.UserCreate)
                    .HasColumnName("SER_USER_CREATE")
                    .IsRequired();

                audit.Property(x => x.CreateDate)
                    .HasColumnName("SER_CREATE_DATE")
                    .HasDefaultValueSql("GETDATE()");

                audit.Property(x => x.UserUpdate)
                    .HasColumnName("SER_USER_UPDATE")
                    .HasDefaultValue(null);

                audit.Property(x => x.UserDelete)
                    .HasColumnName("SER_USER_DELETE")
                    .HasDefaultValue(null);

                audit.Property(x => x.UpdateDate)
                    .HasColumnName("SER_UPDATE_DATE")
                    .HasDefaultValue(null);

                audit.Property(x => x.DeleteDate)
                    .HasColumnName("SER_DELETE_DATE")
                    .HasDefaultValue(null);
            });
        }
    }
}
