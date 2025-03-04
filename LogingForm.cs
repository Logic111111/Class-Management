using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp6
{
    public partial class LogingForm : Form
    {
        studentClass student = new studentClass();
        public LogingForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_MouseEnter(object sender, EventArgs e)
        {
            label1.ForeColor = Color.Red;
        }

        private void label5_MouseLeave(object sender, EventArgs e)
        {
            label1.ForeColor = Color.Transparent;
        }

        private void button_login_Click(object sender, EventArgs e)
        {
            if (textBox_username.Text == "" || textBox_password.Text == "")
            {
                MessageBox.Show("Need login data", "Wrong Login", MessageBoxButtons.OK, MessageBoxIcon.Error);


            }
            else
            {
                string uname = textBox_username.Text;
                string pass = textBox_password.Text;
                DataTable table = student.getList(new MySqlCommand("SELECT * FROM `user` WHERE `username` = '" + uname + "' AND `password` = '" + pass + "'"));
                if (table.Rows.Count > 0)
                {

                    Form1 form1 = new Form1();
                    this.Hide();
                    form1.Show();
                }

                else
                {
                    MessageBox.Show("Your username and password are not exists", "Wrong Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

    }
}
