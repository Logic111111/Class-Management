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
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace WinFormsApp6
{
    public partial class ScoreForm : Form
    {
        CourseClass course = new CourseClass();
        studentClass student = new studentClass();
        ScoreClass score = new ScoreClass();
        public ScoreForm()
        {
            InitializeComponent();
        }

        //create a function to show data on datagrid
        private void showScoe()
        {
            dataGridView_score.DataSource = score.getList(new MySqlCommand("SELECT * FROM `score`"));
        }
        private void label_lname_Click(object sender, EventArgs e)
        {

        }

        private void button_clear_Click(object sender, EventArgs e)
        {
            textBox_stdid.Clear();
            textBox_Score.Clear();
            comboBox_course.SelectedIndex = 0;
            textBox_description.Clear();
        }

        private void ScoreForm_Load(object sender, EventArgs e)
        {
            //populate the combobox with course name 

            comboBox_course.DataSource = course.getCourse(new MySqlCommand("SELECT * FROM `course`"));
            comboBox_course.DisplayMember = "CourseName";
            comboBox_course.ValueMember = "CourseName";
            //
            showScoe();
            // To display the student list in data grid view 
            dataGridView_student.DataSource = student.getList(new MySqlCommand("SELECT `Stdid`,`StdFirstName`,`StdLastName` FROM `student` "));

        }

        private void button_add_Click(object sender, EventArgs e)
        {

            if (textBox_stdid.Text == "" || textBox_Score.Text == "")
            {
                MessageBox.Show("Need Course data", "Field Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int stdId = Convert.ToInt32(textBox_stdid.Text);
                string cName = comboBox_course.SelectedText;
                double sco = Convert.ToInt32(textBox_Score.Text);
                string desc = textBox_description.Text;

                if (score.insertScore(stdId, cName, sco, desc))
                {
                    showScoe();
                    button_clear.PerformClick();
                    MessageBox.Show("New score added", "Add Score", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                else
                {
                    MessageBox.Show("Score not added", "Add Score", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dataGridView_student_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView_student_Click(object sender, EventArgs e)
        {
            textBox_stdid.Text = dataGridView_student.CurrentRow.Cells[0].Value.ToString();
        }
    }
}
