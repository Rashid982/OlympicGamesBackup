using BaseApp.Models;
using CompetitionManager.Messages;
using CompetitionManager.ViewModel;
using Dapper;
using GalaSoft.MvvmLight.Messaging;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CompetitionManager.View
{
    /// <summary>
    /// Interaction logic for CompetitionUC.xaml
    /// </summary>
    public partial class CompetitionUC : UserControl
    {        
        public CompetitionUC()
        {
            InitializeComponent();           
        }                
    }
}
