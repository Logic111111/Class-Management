namespace WinFormsApp6
{
    public partial class Form1 : Form
    {
        studentClass student = new studentClass();

        public Form1()
        {
            InitializeComponent();
            customizeDesing();
        }

        private void button12_Click(object sender, EventArgs e)
        {

        }

        private void customizeDesing()
        {
            panel_studentmenu.Visible = false;
            panel_course_menu.Visible = false;
            panel_score_menu.Visible = false;
        }

        private void hideSubmenu()
        {
            if (panel_studentmenu.Visible == true)
                panel_studentmenu.Visible = false;

            if (panel_course_menu.Visible == true)
                panel_course_menu.Visible = false;

            if (panel_score_menu.Visible == true)
                panel_score_menu.Visible = false;
        }


        private void showSubmenu(Panel submenu)
        {
            if (submenu.Visible == false)
            {
                hideSubmenu();
                submenu.Visible = true;
            }
            else
            {
                submenu.Visible = false;
            }
        }

        private void button_std_Click(object sender, EventArgs e)
        {
            showSubmenu(panel_studentmenu);
        }

        #region studentmenu

        private void button_registration_Click(object sender, EventArgs e)
        {
            openChildForm(new RegisterForm());
            //...
            //.. your code
            //
            hideSubmenu();
        }

        private void button_manageStd_Click(object sender, EventArgs e)
        {
            openChildForm(new ManageStudentForm());
            //...
            //.. your code
            //
            hideSubmenu();
        }

        private void button_status_Click(object sender, EventArgs e)
        {
            //...
            //.. your code
            //
            hideSubmenu();
        }

        private void button_stdPrint_Click(object sender, EventArgs e)
        {
            openChildForm(new PrintStudent());
            //...
            //.. your code
            //
            hideSubmenu();
        }

        #endregion studentmenu

        private void button_course_Click(object sender, EventArgs e)
        {
            showSubmenu(panel_course_menu);
        }

        #region course_menu
        private void button_newCourse_Click(object sender, EventArgs e)
        {
            openChildForm(new CourseForm());
            //...
            //.. your code
            //
            hideSubmenu();
        }

        private void button_manageCourse_Click(object sender, EventArgs e)
        {

            openChildForm(new ManageCourseForm());
            //...
            //.. your code
            //
            hideSubmenu();
        }

        private void button_coursePrint_Click(object sender, EventArgs e)
        {
            openChildForm(new PrintCourseForm());
            //...
            //.. your code
            //
            hideSubmenu();
        }

        #endregion course_menu

        private void button_score_Click(object sender, EventArgs e)
        {
            showSubmenu(panel_score_menu);
        }

        #region score_menu
        private void button_newScore_Click(object sender, EventArgs e)
        {
            openChildForm(new ScoreForm());
            //...
            //.. your code
            //
            hideSubmenu();
        }

        private void button_manageScore_Click(object sender, EventArgs e)
        {
            //...
            //.. your code
            //
            hideSubmenu();
        }

        private void button_scorePrint_Click(object sender, EventArgs e)
        {
            //...
            //.. your code
            //
            hideSubmenu();
        }
        #endregion score_menu

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        // to show register form in mainform
        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panel_main.Controls.Add(childForm);
            panel_main.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            LogingForm loging = new LogingForm();
            this.Hide();
            loging.Show();


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            studentCount();
        }

        //create a function to display student count
        private void studentCount()
        {
            //Display the values
            label_totalStd.Text = "Total Students :" + student.totalStudent();
            label_maleStd.Text = "Male : " + student.maleStudent();
            label_femaleStd.Text = "Female : " + student.femaleStudent();
        }

        private void button_dashboard_Click(object sender, EventArgs e)
        {
            if (activeForm != null)
                activeForm.Close();
            panel_main.Controls.Add(panel_cover);
            studentCount();

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            openChildForm(new Form2());
        }
    }
}
