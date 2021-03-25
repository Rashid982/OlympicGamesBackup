using GalaSoft.MvvmLight.Messaging;
using PropertyChanged;
using Statistic.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Statistic.ViewModel
{
    [AddINotifyPropertyChangedInterface]
    public class BaseWindowVM : BaseVM
    {
        public Messenger Messenger { get; set; }
        public BaseWindowVM()
        {
            Messenger = App.Container.GetInstance<Messenger>();
            Messenger.Register<NavigationM>(this, x => { CurrentVM = x.CurrentVM; });
            CurrentVM = App.Container.GetInstance<StatisticsVM>();
        }
    }
}
