using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Abstract
{
    public interface ICreated
    {
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
