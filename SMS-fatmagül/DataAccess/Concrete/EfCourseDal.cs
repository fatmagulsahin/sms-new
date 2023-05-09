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

public class EfCourseDal : EfRepositoryBase<Course, Guid, BaseDbContext>, ICourseDal
{
    public EfCourseDal(BaseDbContext context) : base(context)
    {
    }
}
