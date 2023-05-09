using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.EntityConfigurations;

public class CoursesStudentConfigurationIEntityTypeConfiguration<CoursesStudent>
{
    public void Configure(EntityTypeBuilder<CourseStudent> builder)
    {
        builder.ToTable("CoursesStudent").HasKey(u => u.Id); ; //var olan veri tabanına yazacağım tablo adını buradan güncelleyebilirim mesela ("Ogrenciler")
        builder.Property(u => u.Id).HasColumnName("id").IsRequired();
        builder.Property(u => u.StudentId).HasColumnName("StudentId").IsRequired();
        builder.Property(u => u.CourseId).HasColumnName("CourseId").IsRequired();
      

        builder.Property(u => u.CreatedDate).HasColumnName("CreatedDate").IsRequired();
        builder.Property(u => u.DeletedDate).HasColumnName("DeletedDate");
        builder.Property(u => u.UpdatedDate).HasColumnName("UpdatedDate");

        builder.HasOne(u => u.Student);//one to many bir kurs birden fazla course students
        builder.HasOne(u => u.Course);//one to many bir kurs birden fazla course students

        builder.HasQueryFilter(u => !u.DeletedDate.HasValue);
    }
}

