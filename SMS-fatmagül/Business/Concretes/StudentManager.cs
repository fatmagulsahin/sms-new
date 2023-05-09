using Business.Abstracts;
using Business.Dtos.Requests;
using DataAccess.Abstracts;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concretes;

public class StudentManager : IStudentService
{
    private IStudentDal studentDal;

    public StudentManager(IStudentDal studentDal)
    {
        this.studentDal = studentDal;
    }

    public async Task Add(CreateStudentRequest createStudentRequest)
    {
        Student student = new Student();
        //to do:regex yapılacak
        student.StudentNumber = "2023123412";
        student.FirstName = createStudentRequest.FirstName;//createStudentRequest den gelen first name
        student.LastName = createStudentRequest.LastName;
        student.BirthDate = createStudentRequest.BirthDate;
        student.NationalityId = createStudentRequest.NationalityId;
        await studentDal.AddAsync(student);


    }
}
