using Core.Persistance;
using DataAccess.Abstracts;
using DataAccess.Contexts;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete;

public class EfCourseStudentDal : EfRepositoryBase<CourseStudent, Guid, BaseDbContext>, ICourseStudentDal
{
    public EfCourseStudentDal(BaseDbContext context) : base(context)
    {
    }
}
