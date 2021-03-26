using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace BaseApp.Models
{
    // sql relation
    // one to many 
    // many to many
    // one to one
    public class Gender : Entity
    {
        public string Name { get; set; }

        public virtual ICollection<Athlet> Athlets { get; set; }
        public virtual ICollection<SubSportType> SubSportTypes { get; set; }


    }
}
