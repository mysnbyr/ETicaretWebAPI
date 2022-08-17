using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Abstract
{
    public interface IUpdate
    {
        public int? ModificationBy { get; set; }
        public DateTime? ModificationDate { get; set; }
    }
}
