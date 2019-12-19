using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlGymCardApp.OperationClass
{
    class C_Connection
    {
        OleDbConnection cnn;
        OleDbCommand cmd;
        public void ConfigurationApp()
        {
            string _ServerAddress = ConfigurationManager.AppSettings["ServerAddress"];
            string _DatabaseProvider = ConfigurationManager.AppSettings["DatabaseProvider"];
            //cnn = new OleDbConnection(@"Provider =" + _DatabaseProvider + " Data Source =" + _ServerAddress + "\\ControlGymCard.mdb" + " ;Persist Security Info=False; Jet OLEDB:Database Password='123456789';");
            cnn = new OleDbConnection(@"Provider =" + _DatabaseProvider + " Data Source =" + _ServerAddress + "\\ControlGymCard.accdb" + " ;Persist Security Info=False; Jet OLEDB:Database Password='123456789';");
        }
        public void Open()
        {
            ConfigurationApp();
            cmd.Connection = cnn;
            cnn.Close();
            cnn.Open();
        }
        public void Close()
        {
            cnn.Close();
            cnn.Dispose();
            cnn.ResetState();
        }
    }
}
