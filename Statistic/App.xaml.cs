using GalaSoft.MvvmLight.Messaging;
using SimpleInjector;
using Statistic.ViewModel;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace Statistic
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public static Container Container { get; set; }
        public App()
        {
            Container = new Container();
            Container.RegisterSingleton<Messenger>();
            Container.Register<BaseWindowVM>();
            Container.Register<StatisticsVM>();
        }
    }
}
