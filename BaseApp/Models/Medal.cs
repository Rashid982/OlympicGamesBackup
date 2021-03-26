using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace BaseApp.Models
{
    public class Medal  : Entity
    {
        public int Degree { get; set; }
        public int Name { get; set; }

        public virtual ICollection<Athlet> Athlets { get; set; }
    }
}
