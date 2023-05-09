using Core.Persistance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete;

public class Instructor:Entity<Guid>

{
    public string Pbik { get; set; }
    public string? NationalityId { get; set; }
    public string  FirstName { get; set; }
    public string? LastName { get; set; }
    public DateTime? BirthDate { get; set; }
    public bool Status { get; set; }
}
