﻿using Microsoft.VisualBasic.Devices;
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
    public partial class ManageCourseForm : Form
    {
        CourseClass course = new CourseClass();

        public ManageCourseForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button_clear_Click(object sender, EventArgs e)
        {
            if (textBox_Cname.Text == "" || textBox_Chour.Text == "" || textBox_Id.Text.Equals(""))
            {
                MessageBox.Show("Need Course data", "Field Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int id = Convert.ToInt32(textBox_Id.Text);
                string cName = textBox_Cname.Text;
                int chr = Convert.ToInt32(textBox_Chour.Text);
                string desc = textBox_description.Text;

                if (course.UpdateCourse(id, cName, chr, desc))
                {
                    showData();
                    button_clear.PerformClick();
                    MessageBox.Show("Course update successfully", "Update course", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                else
                {
                    MessageBox.Show("Error-Course not Edit", "Update Course", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void ManageCourseForm_Load(object sender, EventArgs e)
        {
            showData();
        }

        //show data of the course
        private void showData()
        {
            // to show course list on datagridview
            dataGridView_course.DataSource = course.getCourse(new MySqlCommand("SELECT * FROM `course`"));
        }

        private void button_clear_Click_1(object sender, EventArgs e)
        {
            textBox_Id.Clear();
            textBox_Cname.Clear();
            textBox_Chour.Clear();
            textBox_description.Clear();
        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            if (textBox_Id.Text.Equals(""))
            {
                MessageBox.Show("Need Course Id", "Field Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    int id = Convert.ToInt32(textBox_Id.Text);
                    if (course.deleteCourse(id))
                    {
                        showData();
                        button_clear.PerformClick();
                        MessageBox.Show("Course deleted", "Remove course", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Remove Course", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dataGridView_course_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView_course_Click(object sender, EventArgs e)
        {
            textBox_Id.Text = dataGridView_course.CurrentRow.Cells[0].Value.ToString();
            textBox_Cname.Text = dataGridView_course.CurrentRow.Cells[1].Value.ToString();
            textBox_Chour.Text = dataGridView_course.CurrentRow.Cells[2].Value.ToString();
            textBox_description.Text = dataGridView_course.CurrentRow.Cells[3].Value.ToString();
        }

        private void textBox_search_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_search_Click(object sender, EventArgs e)
        {
            //to search course and show on datagridview
            dataGridView_course.DataSource = course.getCourse(new MySqlCommand("SELECT * FROM `course` WHERE CONCAT(`CourseName`)LIKE '%"+textBox_search.Text+"%'"));
            textBox_search.Clear();
        }
    }
}
