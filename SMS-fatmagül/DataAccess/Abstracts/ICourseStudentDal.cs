using Core.Persistance;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstracts;

public interface ICourseStudentDal:IAsyncRepository<CourseStudent, Guid>,IRepository<CourseStudent, Guid>
{

}
