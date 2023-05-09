using Core.Persistance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete;

public class Course : Entity<Guid>
{
    public string Name { get; set; }
    public string ShortName { get; set; }
    public int Credit { get; set; }
    public ICollection<CourseStudent> CourseStudents { get; set; }

    public Course()
    {
        
    }

    public Course(Guid id,string name, string shortName, int credit) //var olan bir kursu güncelleyece
    {
        Id = id;
        Name = name;
        ShortName = shortName;
        Credit = credit;
    }
}
