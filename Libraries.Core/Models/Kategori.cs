using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libraries.Core.Models
{
    public class Kategori : BaseEntity
    {
        public string Ad { get; set; }
        public long ParentId { get; set; }
    }
}
