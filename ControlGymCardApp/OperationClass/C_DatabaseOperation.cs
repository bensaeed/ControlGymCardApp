using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlGymCardApp.OperationClass
{
    class C_DatabaseOperation
    {
        C_Connection _db = new C_Connection();
        OleDbConnection cnn;
        OleDbCommand cmd;
        #region
        public bool InsertPerson(string _Issue_date, decimal _Amount, string _Pay_To, string _National_No, string _Serial_NoPart1, string _Serial_NoPart2, string _Serial_NoPart3,
       string _National_No_Foreigners, string _DescriptionInCheck, string _DescriptionMore, int _Issue_User, string _Issue_Time)//, string _Is_Deleted)
        {
            //int primaryKey = 0;
            bool Flag = false;
            try
            {
                cmd = new OleDbCommand();
                cmd.CommandText = "INSERT INTO  TBL_Checks"
                            + " (Issue_date,Amount,Pay_To,National_No,Serial_NoPart1,Serial_NoPart2,Serial_NoPart3,National_No_Foreigners,DescriptionInCheck,DescriptionMore,Issue_User,Issue_Time) "
                            + " VALUES(@1,@2,@3,@4,@5,@6,@7,@8,@9,@10,@11,@12);";
                //,Is_Deleted,@13

                cmd.Parameters.AddWithValue("@1", _Issue_date);
                cmd.Parameters.AddWithValue("@2", _Amount);
                cmd.Parameters.AddWithValue("@3", _Pay_To);
                cmd.Parameters.AddWithValue("@4", _National_No);
                cmd.Parameters.AddWithValue("@5", _Serial_NoPart1);
                cmd.Parameters.AddWithValue("@6", _Serial_NoPart2);
                cmd.Parameters.AddWithValue("@7", _Serial_NoPart3);
                cmd.Parameters.AddWithValue("@8", _National_No_Foreigners);
                cmd.Parameters.AddWithValue("@9", _DescriptionInCheck);
                cmd.Parameters.AddWithValue("@10", _DescriptionMore);
                cmd.Parameters.AddWithValue("@11", _Issue_User);
                cmd.Parameters.AddWithValue("@12", _Issue_Time);
                _db.Open();
                cmd.ExecuteNonQuery();
                //primaryKey = (int)(cmd.ExecuteScalar());
                Flag = true;
                _db.Close();
                return Flag;
            }

            catch { return Flag; }
        }
        #endregion
    }
}
