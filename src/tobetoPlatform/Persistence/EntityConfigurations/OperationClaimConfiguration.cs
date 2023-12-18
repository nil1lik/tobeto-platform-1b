using Application.Features.OperationClaims.Constants;
using Core.Security.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.EntityConfigurations;

public class OperationClaimConfiguration : IEntityTypeConfiguration<OperationClaim>
{
    public void Configure(EntityTypeBuilder<OperationClaim> builder)
    {
        builder.ToTable("OperationClaims").HasKey(oc => oc.Id);

        builder.Property(oc => oc.Id).HasColumnName("Id").IsRequired();
        builder.Property(oc => oc.Name).HasColumnName("Name").IsRequired();
        builder.Property(oc => oc.CreatedDate).HasColumnName("CreatedDate").IsRequired();
        builder.Property(oc => oc.UpdatedDate).HasColumnName("UpdatedDate");
        builder.Property(oc => oc.DeletedDate).HasColumnName("DeletedDate");

        builder.HasQueryFilter(oc => !oc.DeletedDate.HasValue);

        builder.HasMany(oc => oc.UserOperationClaims);

        builder.HasData(getSeeds());
    }

    private HashSet<OperationClaim> getSeeds()
    {
        int id = 0;
        HashSet<OperationClaim> seeds =
            new()
            {
                new OperationClaim { Id = ++id, Name = GeneralOperationClaims.Admin }
            };

        
        #region CourseClasses
        seeds.Add(new OperationClaim { Id = ++id, Name = "CourseClasses.Admin" });
        seeds.Add(new OperationClaim { Id = ++id, Name = "CourseClasses.Read" });
        seeds.Add(new OperationClaim { Id = ++id, Name = "CourseClasses.Write" });
        seeds.Add(new OperationClaim { Id = ++id, Name = "CourseClasses.Add" });
        seeds.Add(new OperationClaim { Id = ++id, Name = "CourseClasses.Update" });
        seeds.Add(new OperationClaim { Id = ++id, Name = "CourseClasses.Delete" });
        #endregion
        return seeds;
    }
}
