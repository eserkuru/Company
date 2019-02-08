using System;
using System.Collections.Generic;
using System.Text;

namespace Company.Core.Entities
{
    public interface IEntity
    {
        Guid Id { get; set; }
        string Created { get; set; }
        string CreatedBy { get; set; }
        string Modified { get; set; }
        string ModifiedBy { get; set; }
    }
}
