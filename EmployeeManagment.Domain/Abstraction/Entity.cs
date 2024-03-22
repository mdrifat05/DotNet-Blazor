using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagment.Domain.Abstraction;

public abstract class Entity<TEntityId>
{
    protected Entity(TEntityId id)
    {
        Id = id;
    }
    public TEntityId Id { get; init; }
}
