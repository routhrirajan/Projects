using EFMVC.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFMVC.Data.Configurations
{
    public class PostProfileConfiguration : EntityTypeConfiguration<PostProfile>
    {
        public PostProfileConfiguration()
        {
            ToTable("PostProfile");
            Property(e => e.DOB).IsRequired();
            Property(e => e.Email).IsRequired().HasMaxLength(200);
            Property(e => e.FileName).IsOptional().HasMaxLength(100);
            Property(e => e.Gender).IsRequired().HasMaxLength(1);
            Property(e => e.Headline).IsRequired();
            Property(e => e.Landline).IsOptional();
            Property(e => e.Mobile).IsRequired();
            Property(e => e.TotalExperience).IsRequired();
            Property(e => e.UserId).IsRequired();
            Property(e => e.FileURL).IsOptional();
            Property(e => e.DesignationId).IsRequired();
            Property(e => e.LocationId).IsRequired();
        }
    }
}
