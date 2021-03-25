﻿using CompetitionManager.Messages;
using GalaSoft.MvvmLight.Messaging;
using PropertyChanged;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompetitionManager.ViewModel
{
    [AddINotifyPropertyChangedInterface]
    public class OlympicGamesVM : BaseVM
    {        
        public Messenger Messenger { get; set; }
        public OlympicGamesVM()
        {
            Messenger = App.Container.GetInstance<Messenger>();
            CurrentVM = App.Container.GetInstance<CompetitionVM>();
            Messenger.Register<NavigationM>(this, x => { CurrentVM = x.CurrentVM; });
        }
    }
}
