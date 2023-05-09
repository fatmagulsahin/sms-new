using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.EntityConfigurations;

public class CourseConfiguration : IEntityTypeConfiguration<Course>
{
 public void Configure(EntityTypeBuilder<Course> builder)
    {
        builder.ToTable("Courses").HasKey(u => u.Id); ; //var olan veri tabanına yazacağım tablo adını buradan güncelleyebilirim mesela ("Ogrenciler")
        builder.Property(u => u.Id).HasColumnName("id").IsRequired();
        builder.Property(u => u.Name).HasColumnName("Name").IsRequired();
        builder.Property(u => u.ShortName).HasColumnName("ShortName").IsRequired();
        builder.Property(u => u.Credit).HasColumnName("Credit").IsRequired();

        builder.Property(u => u.CreatedDate).HasColumnName("CreatedDate").IsRequired();
        builder.Property(u => u.DeletedDate).HasColumnName("DeletedDate");
        builder.Property(u => u.UpdatedDate).HasColumnName("UpdatedDate");

        builder.HasMany(u => u.CourseStudents);//one to many bir kurs birden fazla course students

        builder.HasQueryFilter(u => !u.DeletedDate.HasValue);
    }

}
