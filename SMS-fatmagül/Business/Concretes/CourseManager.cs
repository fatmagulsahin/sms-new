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

public class CourseManager : ICourseService
{
    private ICourseDal courseDal;

    public CourseManager(ICourseDal courseDal)
    {
        this.courseDal = courseDal;
    }

    public async Task Add(CreateCourseRequest createCourseRequest)
    {
        Course course = new Course();
        course.Credit=createCourseRequest.Credit;
        course.Name=createCourseRequest.Name;
        course.ShortName=createCourseRequest.ShortName;

        await courseDal.AddAsync(course);
    }
}
