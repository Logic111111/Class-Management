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
using MySql.Data.MySqlClient;
using static System.ComponentModel.Design.ObjectSelectorEditor;


namespace WinFormsApp6
{
    public partial class RegisterForm : Form
    {
        studentClass student = new studentClass();

        public RegisterForm()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label_lname_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }



        private void button_upload_Click(object sender, EventArgs e)
        {
            // Browse photo from your PC 
            using (OpenFileDialog opf = new OpenFileDialog())
            {
                opf.Filter = "Select Photo (*.jpg; *.png; *.gif)|*.jpg; *.png; *.gif";

                if (opf.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        pictureBox_student.Image = Image.FromFile(opf.FileName);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error loading image: " + ex.Message);
                    }
                }
            }
        }

        private void button_clear_Click(object sender, EventArgs e)
        {
            textBox_fname.Clear();
            textBox_lname.Clear();
            textBox_phone.Clear();
            textBox_address.Clear();
            radioButton_male.Checked = true;
            dateTimePicker1.Value = DateTime.Now;
            pictureBox_student.Image = null;
        }

        // create a function to verify

        bool verify()
        {
            if ((textBox_fname.Text == " ") || (textBox_lname.Text == " ") ||
                (textBox_phone.Text == " ") || (textBox_address.Text == " ") ||
                (pictureBox_student.Image == null))
            {
                return false;
            }
            else
                return true;
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            // add new student

            string fname = textBox_fname.Text;
            string lname = textBox_lname.Text;
            DateTime bdate = dateTimePicker1.Value;
            string phone = textBox_phone.Text;
            string address = textBox_address.Text;
            string gender = radioButton_male.Checked ? "Male" : "Female";



            // calculate the age 

            int born_year = dateTimePicker1.Value.Year;
            int this_year = DateTime.Now.Year;


            if ((this_year - born_year) < 10 || (this_year - born_year) > 100)
            {
                MessageBox.Show("The Student age must be between 10 and 100", "Invalid Birthday", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



            else if (verify())
            {
                try
                {
                    // to get photo from picture box
                    MemoryStream ms = new MemoryStream();

                    pictureBox_student.Image.Save(ms, pictureBox_student.Image.RawFormat);
                    byte[] img = ms.ToArray();

                    if (student.insertStudent(fname, lname, bdate, gender, phone, address, img))
                    {
                        showTable();
                        MessageBox.Show("New Student Added", "Add Student", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)

                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            else
            {
                MessageBox.Show("Empty Field", "Add Student", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }




        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void radioButton_female_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void RegisterForm_Load_1(object sender, EventArgs e)
        {
            showTable();

        }
        //to show student list in in data grid view


        public void showTable()
        {
            dataGridView_student.DataSource = student.getStudentlist(new MySqlCommand("SELECT * FROM `student`"));
            DataGridViewImageColumn imageColumn = new DataGridViewImageColumn();
            imageColumn = (DataGridViewImageColumn)dataGridView_student.Columns[7];
            imageColumn.ImageLayout = DataGridViewImageCellLayout.Zoom;

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button_upload_Click_1(object sender, EventArgs e)
        {
            // Browse photo from your PC 
            using (OpenFileDialog opf = new OpenFileDialog())
            {
                opf.Filter = "Select Photo (*.jpg; *.png; *.gif)|*.jpg; *.png; *.gif";

                if (opf.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        pictureBox_student.Image = Image.FromFile(opf.FileName);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error loading image: " + ex.Message);
                    }
                }
            }

        }

        private void button_add_Click_1(object sender, EventArgs e)
        {
            // add new student

            string fname = textBox_fname.Text;
            string lname = textBox_lname.Text;
            DateTime bdate = dateTimePicker1.Value;
            string phone = textBox_phone.Text;
            string address = textBox_address.Text;
            string gender = radioButton_male.Checked ? "Male" : "Female";



            // calculate the age 

            int born_year = dateTimePicker1.Value.Year;
            int this_year = DateTime.Now.Year;


            if ((this_year - born_year) < 10 || (this_year - born_year) > 100)
            {
                MessageBox.Show("The Student age must be between 10 and 100", "Invalid Birthday", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



            else if (verify())
            {
                try
                {
                    // to get photo from picture box
                    MemoryStream ms = new MemoryStream();

                    pictureBox_student.Image.Save(ms, pictureBox_student.Image.RawFormat);
                    byte[] img = ms.ToArray();

                    if (student.insertStudent(fname, lname, bdate, gender, phone, address, img))
                    {
                        showTable();
                        MessageBox.Show("New Student Added", "Add Student", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)

                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            else
            {
                MessageBox.Show("Empty Field", "Add Student", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


        }

        private void button_clear_Click_1(object sender, EventArgs e)
        {
            textBox_fname.Clear();
            textBox_lname.Clear();
            textBox_phone.Clear();
            textBox_address.Clear();
            radioButton_male.Checked = true;
            dateTimePicker1.Value = DateTime.Now;
            pictureBox_student.Image = null;
        }

        private void dataGridView_student_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }
    }
}
