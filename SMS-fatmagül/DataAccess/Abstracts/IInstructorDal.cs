using Core.Persistance;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstracts;

public  interface IInstructorDal:IAsyncRepository<Instructor,Guid>,IRepository<Instructor,Guid>
{
}
