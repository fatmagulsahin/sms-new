
using Core.Persistance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete; //class scope bir dosyada birden fazla class kullanımını engeller

public class Student :Entity<Guid>
{
    public string StudentNumber { get; set; }
    public string? NationalityId { get; set; }
    public string FirstName { get; set;}
    public string LastName { get;set;}
    public DateTime BirthDate { get; set; }
    public bool Status { get; set; }
   
    public ICollection<CourseStudent> CourseStudents { get; set; }//bir ders kaydı bu bunun bir öğrencisi bir kaydı olabilir //kayıt datası
    public Student()
    {
        CourseStudents = new HashSet<CourseStudent>(); //tekrar edemeyeceğini bildiğim için hashset olarak tutuyorum
        
    }
    public Student(Guid id, string studentNumber, string nationalityId, string firstName, string lastName, DateTime birthDate, bool status):this ()
    {
        Id = id;
        StudentNumber = studentNumber;
        NationalityId = nationalityId;
        FirstName = firstName;
        LastName = lastName;
        BirthDate = birthDate;
        Status = status;
    }
}
