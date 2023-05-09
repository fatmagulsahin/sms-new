using Core.Persistance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete;

public class CourseStudent:Entity<Guid> //ara tablo
    
{
    public Guid CourseId { get; set; }//bu alanlar var
    public Guid StudentId { get; set; }

    public virtual Student Student { get; set; } //ilişkilendirdik
    public virtual Course Course { get; set; }

    public CourseStudent()
    {
        
    }
    public CourseStudent(Guid id,Guid courseId, Guid studentId):base(id)
    {
        StudentId = courseId;
        CourseId = studentId;
    }

}

