using Microsoft.VisualBasic.Devices;
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
using DGVPrinterHelper;
namespace WinFormsApp6
{
    public partial class PrintCourseForm : Form
    {
        CourseClass course = new CourseClass();
        DGVPrinter printer = new DGVPrinter();
        public PrintCourseForm()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button_search_Click(object sender, EventArgs e)
        {
            //to search course and show on datagridview
            dataGridView_student.DataSource = course.getCourse(new MySqlCommand("SELECT * FROM `course` WHERE CONCAT(`CourseName`)LIKE '%" + textBox_search.Text + "%'"));
            textBox_search.Clear();
        }

        private void PrintCourseForm_Load(object sender, EventArgs e)
        {
            dataGridView_student.DataSource = course.getCourse(new MySqlCommand("SELECT * FROM `course`"));
          
        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            //We need DGVprinter helper for print pdf file
            printer.Title = "Course list";
            printer.SubTitle = string.Format("Date: {0}", DateTime.Now.Date);
            printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            printer.PageNumbers = true;
            printer.PageNumberInHeader = false;
            printer.PorportionalColumns = true;
            printer.HeaderCellAlignment = StringAlignment.Near;
            printer.Footer = "foxlearn";
            printer.FooterSpacing = 15;
            printer.printDocument.DefaultPageSettings.Landscape = true;
            printer.PrintDataGridView(dataGridView_student);
        }
    }
}
