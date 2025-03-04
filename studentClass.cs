using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using static System.ComponentModel.Design.ObjectSelectorEditor;
using System.Windows.Forms;
using MySqlX.XDevAPI.Relational;
using System.Security.Cryptography.X509Certificates;


namespace WinFormsApp6
{
    internal class studentClass
    {
        DBconnect connect = new DBconnect();

        // create a function to add new students to the dataset.

        public bool insertStudent(string fname,string lname, DateTime bdate, string gender, string phone, string address, byte[] img )
        {
            MySqlCommand Command = new MySqlCommand("INSERT INTO `student`(`StdFirstName`, `StdLastName`, `Birthdate`, `Gender`, `Phone`, `Address`, `Photo`) VALUES(@fn, @ln, @bd, @gd, @ph, @adr, @img)",connect.getConnection);

            Command.Parameters.Add("@fn", MySqlDbType.VarChar).Value = fname;
            Command.Parameters.Add("@ln", MySqlDbType.VarChar).Value = lname;
            Command.Parameters.Add("@bd", MySqlDbType.Date).Value = bdate;
            Command.Parameters.Add("@gd", MySqlDbType.VarChar).Value = gender;
            Command.Parameters.Add("@ph", MySqlDbType.VarChar).Value = phone;
            Command.Parameters.Add("@adr", MySqlDbType.VarChar).Value = address;
            Command.Parameters.Add("@img", MySqlDbType.Blob).Value = img;

            connect.openConnect();
            if(Command.ExecuteNonQuery() == 1)
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

        // to get student table

        public DataTable getStudentlist(MySqlCommand command)
        {
            // Replace invalid date values (e.g., '0000-00-00') with NULL in the query
            command.Connection = connect.getConnection;
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }


        //Create a function to execute the count query(total male female)
        public string exeCount(string query)
        {
            MySqlCommand command = new MySqlCommand(query,connect.getConnection);
            connect.openConnect();
            string count = command.ExecuteScalar().ToString();
            connect.closeConnect();
            return count;
        }

        // to get the total student
        public string totalStudent()
        {
            return exeCount("SELECT COUNT(*) FROM student");

        }

        // to get male student count
        public string maleStudent()
        {
            return exeCount("SELECT COUNT(*) FROM student WHERE Gender ='Male'");

        }

        // to get female
        public string femaleStudent()
        {
            return exeCount("SELECT COUNT(*) FROM student WHERE Gender ='Female'");

        }

        //create a function to search student
        public DataTable searchStudentlist(string searchdata)
        {
            // Replace invalid date values (e.g., '0000-00-00') with NULL in the query
            MySqlCommand command = new MySqlCommand("SELECT * FROM `student` WHERE CONCAT(`StdFirstName`,`StdLastName`,`Address`)  LIKE '%"+ searchdata+"%'", connect.getConnection);
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        //create a function to edit student
        public bool updateStudent(int id,string fname, string lname, DateTime bdate, string gender, string phone, string address, byte[] img)
        {
            MySqlCommand Command = new MySqlCommand("UPDATE `student` SET `StdFirstName`=@fn,`StdLastName`=@ln,`Birthdate`=@bd,`Gender`=@gd,`Phone`=@ph,`Address`=@adr,`Photo`=@img WHERE `Stdid`=@id", connect.getConnection);

            Command.Parameters.Add("@id", MySqlDbType.Int32).Value = id;
            Command.Parameters.Add("@fn", MySqlDbType.VarChar).Value = fname;
            Command.Parameters.Add("@ln", MySqlDbType.VarChar).Value = lname;
            Command.Parameters.Add("@bd", MySqlDbType.Date).Value = bdate;
            Command.Parameters.Add("@gd", MySqlDbType.VarChar).Value = gender;
            Command.Parameters.Add("@ph", MySqlDbType.VarChar).Value = phone;
            Command.Parameters.Add("@adr", MySqlDbType.VarChar).Value = address;
            Command.Parameters.Add("@img", MySqlDbType.Blob).Value = img;

            connect.openConnect();
            if (Command.ExecuteNonQuery() == 1)
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

        public DataTable getList(MySqlCommand command)
        {
            command.Connection = connect.getConnection;
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
    }
}
