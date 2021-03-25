using BaseApp.Entity;
using BaseApp.Models;
using CompetitionManager.Messages;
using Dapper;
using GalaSoft.MvvmLight.CommandWpf;
using GalaSoft.MvvmLight.Messaging;
using LumenWorks.Framework.IO.Csv;
using PropertyChanged;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace CompetitionManager.ViewModel
{
    [AddINotifyPropertyChangedInterface]
    public class CompetitionVM : BaseVM
    {        
        public Messenger Messenger { get; set; }
        public RelayCommand SaveBtn { get; set; }
        public RelayCommand SelectionChangedCmd { get; set; }
        public List<Country> Countries { get; set; }
        public List<SportType> SportTypes { get; set; }
        public List<SportType> Categories { get; set; }
        public SportType SelectedSportType { get; set; }
        public SqlTransaction Transaction { get; set; }
        public List<Athlet> Athlets { get; set; }

        public CompetitionVM()
        {            
            var connstr = ConfigurationManager.ConnectionStrings["Connection"].ConnectionString;
            Messenger = App.Container.GetInstance<Messenger>();
            SportTypes = new List<SportType>();
            Categories = new List<SportType>();
                                    
            using (var connection=new SqlConnection(connstr))
            {
                connection.Open();
                
                var query = "SELECT*FROM SportTypes WHERE SportType_Id = NULL SET ANSI_NULLS OFF";         
                connection.Execute(query);
                var querySportTypeList = connection.Query<SportType>(query);
                SportTypes = querySportTypeList.ToList();

                var cquery = "SELECT*FROM Countries";
                connection.Execute(cquery);
                var queryCountryList = connection.Query<Country>(cquery);
                Countries = queryCountryList.ToList();


                SelectionChangedCmd = new RelayCommand(() =>
                {
                    MessageBox.Show("Salam");
                    
                   
                    var query1 = "SELECT*FROM SportTypes WHERE SportType_Id=@Id";
                    var q = connection.Query<SportType>(query1, new { ID = 674 });
                    Categories = q.ToList();                   

                });
            }
                        

            SaveBtn = new RelayCommand(()=>  
            {
                using (var db=new OlimpicDBContext())
                {

                }
            });
        }
        
    }
}
