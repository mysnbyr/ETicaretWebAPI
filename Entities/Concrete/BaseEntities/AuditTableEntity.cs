using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete.BaseEntities
{
    public class AuditTableEntity : BaseEntity, ICreated,IUpdate
    {
        public int CreatedBy { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public DateTime CreatedDate { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int? ModificationBy { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public DateTime? ModificationDate { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
