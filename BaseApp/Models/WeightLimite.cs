using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseApp.Models
{
   public  class WeightLimite : Entity
    {
        public double MaxWeight { get; set; }
        public double MinWeight { get; set; }

        // some awesome comment

        public virtual ICollection<SubSportType> SubSportTypes { get; set; }
    }
}
