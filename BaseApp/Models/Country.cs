﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseApp.Models
{
    public class Country : Entity
    {
        public string  Name  { get; set; }
        public virtual ICollection<Athlet> Athlets { get; set; }       
    }
}
