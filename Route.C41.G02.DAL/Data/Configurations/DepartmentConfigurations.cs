using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Route.C41.G02.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Route.C41.G02.DAL.Data.Configurations
{
    internal class DepartmentConfigurations : IEntityTypeConfiguration<Department>
    {
        public void Configure(EntityTypeBuilder<Department> builder)
        {
            //Fluent APi for "Department" Domain
            builder.Property(D=>D.Id).UseIdentityColumn(10,10);
            builder.Property(D=>D.Code).HasColumnType("varChar").HasMaxLength(50).IsRequired();
            builder.Property(D=>D.Name).HasColumnType("varChar").HasMaxLength(50).IsRequired();
            //builder.Property(D => D.DateOfCreation)
            //    .HasColumnType("datetime2") // or "date" if you only need the date part
            //    .IsRequired();
        }
    }
}
