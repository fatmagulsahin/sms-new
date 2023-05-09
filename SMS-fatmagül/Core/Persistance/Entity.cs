using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Persistance;

public class Entity<TId> : IEntityTimestamps // <TId>generic hale getirdim istediğim tiple çalışırım

{
    public TId Id { get; set; }
    public DateTime CreatedDate { get; set; } //timestamp
    public DateTime? UpdatedDate { get; set; } //nullable
    public DateTime? DeletedDate { get; set; }
    public Entity()
    {
        Id = default;
    }
    public Entity(TId id)
    {
        Id = id;
    }


}

