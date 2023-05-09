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

public class EfStudentDal : EfRepositoryBase<Student, Guid, BaseDbContext>, IStudentDal
{
    public EfStudentDal(BaseDbContext context) : base(context)
    {

    }
}
