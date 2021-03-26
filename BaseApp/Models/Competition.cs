using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseApp.Models
{
    public class Competition  : Entity
    {
        public bool IsFinal { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public virtual SubSportType SubSportType { get; set; }

        public virtual ICollection<Athlet> Athlets  { get; set; }
    }
}
