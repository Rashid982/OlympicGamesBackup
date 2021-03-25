using PropertyChanged;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompetitionManager.ViewModel
{
    [AddINotifyPropertyChangedInterface]
    public class BaseVM
    {
        public BaseVM CurrentVM { get; set; }
    }
}
