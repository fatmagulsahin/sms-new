using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.EntityConfigurations; //classscope

public class StudentConfiguration : IEntityTypeConfiguration<Student>
{
    public void Configure(EntityTypeBuilder<Student> builder)
    {
        builder.ToTable("Students").HasKey(u => u.Id); ; //var olan veri tabanına yazacağım tablo adını buradan güncelleyebilirim mesela ("Ogrenciler")
        builder.Property(u=>u.Id).HasColumnName("id").IsRequired();
        builder.Property(u=>u.FirstName).HasColumnName("FirstName").IsRequired();
        builder.Property(u=>u.LastName).HasColumnName("LastName").IsRequired();
        builder.Property(u=>u.StudentNumber).HasColumnName("StudentNumber").IsRequired();
        builder.Property(u=>u.BirthDate).HasColumnName("BirthDate").IsRequired();
        builder.Property(u=>u.CreatedDate).HasColumnName("CreatedDate").IsRequired();
        builder.Property(u => u.DeletedDate).HasColumnName("DeletedDate");
        builder.Property(u => u.UpdatedDate).HasColumnName("UpdatedDate");
        builder.Property(u => u.NationalityId).HasColumnName("NationalityId");
        builder.Property(u => u.Status).HasColumnName("Status");

        builder.HasKey(u => u.Id);

        builder.HasMany(u => u.CourseStudents);

        builder.HasQueryFilter(u=>!u.DeletedDate.HasValue); //deleteddate varsa default olarak querylerde getirme
                                                            //silinenleri getirme
    

    }
}
