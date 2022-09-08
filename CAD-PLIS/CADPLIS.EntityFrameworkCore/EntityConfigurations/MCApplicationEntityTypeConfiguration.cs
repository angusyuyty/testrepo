using CADPLIS.Domain.MCApplications;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CADPLIS.EntityFrameworkCore.EntityConfigurations
{
    public class MCApplicationEntityTypeConfiguration : IEntityTypeConfiguration<MCApplication>
    {
        public void Configure(EntityTypeBuilder<MCApplication> builder)
        {
            builder.ToTable("PLIS_MC_APPLICATION");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).HasColumnName("id");
            builder.Property(x => x.ApplicationNo).HasColumnName("application_no").IsRequired();
            builder.Property(x => x.ApplicationType).HasColumnName("application_type").IsRequired();
            builder.Property(x => x.ApplicationStatus).HasColumnName("application_status");
            builder.Property(x => x.ApplicantUserId).HasColumnName("applicant_user_id");
            builder.Property(x => x.CreatedBy).HasColumnName("creator_user_id").IsRequired();
            builder.Property(x => x.CreatedUserRoleId).HasColumnName("creator_urid").IsRequired();
            builder.Property(x => x.UpdatedBy).HasColumnName("last_updated_user_id");
            builder.Property(x => x.UpdatedUserRoleId).HasColumnName("last_updated_urid");
            builder.Property(x => x.CreatedTime).HasColumnName("created_date").IsRequired();
            builder.Property(x => x.UpdatedTime).HasColumnName("last_updated_date");
        }
    }
}
