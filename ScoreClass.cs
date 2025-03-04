using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp6
{
     class ScoreClass
    {
        DBconnect connect = new DBconnect();
        public bool insertScore(int stdid,string courName,double sco, string desc)
        {
            MySqlCommand command = new MySqlCommand("INSERT INTO `score`(`StudentId`, `CourseName`, `Score`, `Description`) VALUES (@stid,@cn,@sco,@desc)", connect.getConnection);
            //@stid,@cn,@sco,@desc

            command.Parameters.Add("@stid", MySqlDbType.Int32).Value = stdid;
            command.Parameters.Add("@cn", MySqlDbType.VarChar).Value = courName;
            command.Parameters.Add("@sco", MySqlDbType.Double).Value = sco;
            command.Parameters.Add("@desc", MySqlDbType.VarChar).Value = desc;
            connect.openConnect();
            if (command.ExecuteNonQuery() == 1)
            {
                connect.closeConnect();
                return true;
            }

            else
            {
                connect.closeConnect();
                return false;
            }

        }

        // to get list
        public DataTable getList(MySqlCommand command)
        {
            command.Connection = connect.getConnection;
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        //to check already inserted score

        /*public bool checkScore(int stdId,string cName)
        {
            DataTable table = getList(new MySqlCommand("SELECT * FROM `score` WHERE `StudentId` = "+stdId+" AND `CourseName` ="+cName+" "));
            if(table.Rows.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }*/
    }
}
