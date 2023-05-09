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

public class InstructorManager: IInstructorService
{
    private IInstructorDal instructorDal;

    public InstructorManager(IInstructorDal instructorDal)
    {
        this.instructorDal = instructorDal;
    }

    public async Task Add(CreateInstructorRequest createInstructorRequest)
    {
        Instructor instructor = new Instructor();

        instructor.Pbik = "3637363";
        instructor.FirstName = createInstructorRequest.Firstname;
        instructor.LastName = createInstructorRequest.Lastname;
        instructor.BirthDate = createInstructorRequest.BirthDate;
        instructor.NationalityId = createInstructorRequest.NationalityId;
        await instructorDal.AddAsync(instructor);


    }
    }
