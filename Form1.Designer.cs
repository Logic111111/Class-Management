namespace WinFormsApp6
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panel_slide = new Panel();
            button_exit = new Button();
            button_dashboard = new Button();
            panel_score_menu = new Panel();
            button_fun = new Button();
            button_manageScore = new Button();
            button_newScore = new Button();
            button_score = new Button();
            panel_course_menu = new Panel();
            button_coursePrint = new Button();
            button_manageCourse = new Button();
            button_newCourse = new Button();
            button_course = new Button();
            panel_studentmenu = new Panel();
            button_stdPrint = new Button();
            button_status = new Button();
            button_manageStd = new Button();
            button_registration = new Button();
            button_std = new Button();
            panel_logo = new Panel();
            label4 = new Label();
            label3 = new Label();
            label1 = new Label();
            panel_main = new Panel();
            pictureBox2 = new PictureBox();
            panel6 = new Panel();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            label_femaleStd = new Label();
            label_maleStd = new Label();
            label_totalStd = new Label();
            comboBox1 = new ComboBox();
            panel4 = new Panel();
            pictureBox1 = new PictureBox();
            label_role = new Label();
            label_user = new Label();
            label5 = new Label();
            label2 = new Label();
            panel5 = new Panel();
            panel1 = new Panel();
            panel2 = new Panel();
            panel_cover = new Panel();
            label12 = new Label();
            panel3 = new Panel();
            panel_slide.SuspendLayout();
            panel_score_menu.SuspendLayout();
            panel_course_menu.SuspendLayout();
            panel_studentmenu.SuspendLayout();
            panel_logo.SuspendLayout();
            panel_main.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel6.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel_cover.SuspendLayout();
            SuspendLayout();
            // 
            // panel_slide
            // 
            panel_slide.AutoScroll = true;
            panel_slide.BackColor = Color.FromArgb(0, 71, 160);
            panel_slide.Controls.Add(button_exit);
            panel_slide.Controls.Add(button_dashboard);
            panel_slide.Controls.Add(panel_score_menu);
            panel_slide.Controls.Add(button_score);
            panel_slide.Controls.Add(panel_course_menu);
            panel_slide.Controls.Add(button_course);
            panel_slide.Controls.Add(panel_studentmenu);
            panel_slide.Controls.Add(button_std);
            panel_slide.Controls.Add(panel_logo);
            panel_slide.Dock = DockStyle.Left;
            panel_slide.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            panel_slide.Location = new Point(0, 0);
            panel_slide.Name = "panel_slide";
            panel_slide.Size = new Size(227, 613);
            panel_slide.TabIndex = 0;
            // 
            // button_exit
            // 
            button_exit.Dock = DockStyle.Top;
            button_exit.FlatAppearance.BorderSize = 0;
            button_exit.FlatStyle = FlatStyle.Flat;
            button_exit.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button_exit.ForeColor = Color.White;
            button_exit.Location = new Point(0, 900);
            button_exit.Name = "button_exit";
            button_exit.Padding = new Padding(10, 0, 0, 0);
            button_exit.Size = new Size(206, 55);
            button_exit.TabIndex = 9;
            button_exit.Text = "Exit";
            button_exit.TextAlign = ContentAlignment.MiddleLeft;
            button_exit.UseVisualStyleBackColor = true;
            button_exit.Click += button1_Click;
            // 
            // button_dashboard
            // 
            button_dashboard.Dock = DockStyle.Top;
            button_dashboard.FlatAppearance.BorderSize = 0;
            button_dashboard.FlatStyle = FlatStyle.Flat;
            button_dashboard.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button_dashboard.ForeColor = Color.White;
            button_dashboard.Location = new Point(0, 845);
            button_dashboard.Name = "button_dashboard";
            button_dashboard.Padding = new Padding(10, 0, 0, 0);
            button_dashboard.Size = new Size(206, 55);
            button_dashboard.TabIndex = 8;
            button_dashboard.Text = "Dashboard";
            button_dashboard.TextAlign = ContentAlignment.MiddleLeft;
            button_dashboard.UseVisualStyleBackColor = true;
            button_dashboard.Click += button_dashboard_Click;
            // 
            // panel_score_menu
            // 
            panel_score_menu.BackColor = Color.Blue;
            panel_score_menu.Controls.Add(button_fun);
            panel_score_menu.Controls.Add(button_manageScore);
            panel_score_menu.Controls.Add(button_newScore);
            panel_score_menu.Controls.Add(panel3);
            panel_score_menu.Dock = DockStyle.Top;
            panel_score_menu.Location = new Point(0, 687);
            panel_score_menu.Name = "panel_score_menu";
            panel_score_menu.Size = new Size(206, 158);
            panel_score_menu.TabIndex = 7;
            // 
            // button_fun
            // 
            button_fun.BackColor = Color.FromArgb(0, 71, 160);
            button_fun.Dock = DockStyle.Top;
            button_fun.FlatAppearance.BorderSize = 0;
            button_fun.FlatStyle = FlatStyle.Flat;
            button_fun.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button_fun.ForeColor = Color.White;
            button_fun.Location = new Point(0, 110);
            button_fun.Name = "button_fun";
            button_fun.Padding = new Padding(10, 0, 0, 0);
            button_fun.Size = new Size(206, 48);
            button_fun.TabIndex = 7;
            button_fun.Text = "Fun ";
            button_fun.TextAlign = ContentAlignment.MiddleLeft;
            button_fun.UseVisualStyleBackColor = false;
            button_fun.Click += button1_Click_1;
            // 
            // button_manageScore
            // 
            button_manageScore.Dock = DockStyle.Top;
            button_manageScore.FlatAppearance.BorderSize = 0;
            button_manageScore.FlatStyle = FlatStyle.Flat;
            button_manageScore.Font = new Font("Century Gothic", 12F);
            button_manageScore.ForeColor = Color.White;
            button_manageScore.Location = new Point(0, 50);
            button_manageScore.Name = "button_manageScore";
            button_manageScore.Padding = new Padding(35, 0, 0, 0);
            button_manageScore.Size = new Size(206, 60);
            button_manageScore.TabIndex = 1;
            button_manageScore.Text = "Manage Score";
            button_manageScore.TextAlign = ContentAlignment.MiddleLeft;
            button_manageScore.UseVisualStyleBackColor = true;
            button_manageScore.Click += button_manageScore_Click;
            // 
            // button_newScore
            // 
            button_newScore.Dock = DockStyle.Top;
            button_newScore.FlatAppearance.BorderSize = 0;
            button_newScore.FlatStyle = FlatStyle.Flat;
            button_newScore.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button_newScore.ForeColor = Color.White;
            button_newScore.Location = new Point(0, 0);
            button_newScore.Name = "button_newScore";
            button_newScore.Padding = new Padding(35, 0, 0, 0);
            button_newScore.Size = new Size(206, 50);
            button_newScore.TabIndex = 0;
            button_newScore.Text = "New Score";
            button_newScore.TextAlign = ContentAlignment.MiddleLeft;
            button_newScore.UseVisualStyleBackColor = true;
            button_newScore.Click += button_newScore_Click;
            // 
            // button_score
            // 
            button_score.Dock = DockStyle.Top;
            button_score.FlatAppearance.BorderSize = 0;
            button_score.FlatStyle = FlatStyle.Flat;
            button_score.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button_score.ForeColor = Color.White;
            button_score.Location = new Point(0, 632);
            button_score.Name = "button_score";
            button_score.Padding = new Padding(10, 0, 0, 0);
            button_score.Size = new Size(206, 55);
            button_score.TabIndex = 6;
            button_score.Text = "Score";
            button_score.TextAlign = ContentAlignment.MiddleLeft;
            button_score.UseVisualStyleBackColor = true;
            button_score.Click += button_score_Click;
            // 
            // panel_course_menu
            // 
            panel_course_menu.BackColor = Color.Blue;
            panel_course_menu.Controls.Add(button_coursePrint);
            panel_course_menu.Controls.Add(button_manageCourse);
            panel_course_menu.Controls.Add(button_newCourse);
            panel_course_menu.Dock = DockStyle.Top;
            panel_course_menu.Location = new Point(0, 468);
            panel_course_menu.Name = "panel_course_menu";
            panel_course_menu.Size = new Size(206, 164);
            panel_course_menu.TabIndex = 5;
            // 
            // button_coursePrint
            // 
            button_coursePrint.Dock = DockStyle.Top;
            button_coursePrint.FlatAppearance.BorderSize = 0;
            button_coursePrint.FlatStyle = FlatStyle.Flat;
            button_coursePrint.Font = new Font("Century Gothic", 12F);
            button_coursePrint.ForeColor = Color.White;
            button_coursePrint.Location = new Point(0, 110);
            button_coursePrint.Name = "button_coursePrint";
            button_coursePrint.Padding = new Padding(35, 0, 0, 0);
            button_coursePrint.Size = new Size(206, 54);
            button_coursePrint.TabIndex = 3;
            button_coursePrint.Text = "print";
            button_coursePrint.TextAlign = ContentAlignment.MiddleLeft;
            button_coursePrint.UseVisualStyleBackColor = true;
            button_coursePrint.Click += button_coursePrint_Click;
            // 
            // button_manageCourse
            // 
            button_manageCourse.Dock = DockStyle.Top;
            button_manageCourse.FlatAppearance.BorderSize = 0;
            button_manageCourse.FlatStyle = FlatStyle.Flat;
            button_manageCourse.Font = new Font("Century Gothic", 12F);
            button_manageCourse.ForeColor = Color.White;
            button_manageCourse.Location = new Point(0, 50);
            button_manageCourse.Name = "button_manageCourse";
            button_manageCourse.Padding = new Padding(35, 0, 0, 0);
            button_manageCourse.Size = new Size(206, 60);
            button_manageCourse.TabIndex = 1;
            button_manageCourse.Text = "Manage Course";
            button_manageCourse.TextAlign = ContentAlignment.MiddleLeft;
            button_manageCourse.UseVisualStyleBackColor = true;
            button_manageCourse.Click += button_manageCourse_Click;
            // 
            // button_newCourse
            // 
            button_newCourse.Dock = DockStyle.Top;
            button_newCourse.FlatAppearance.BorderSize = 0;
            button_newCourse.FlatStyle = FlatStyle.Flat;
            button_newCourse.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button_newCourse.ForeColor = Color.White;
            button_newCourse.Location = new Point(0, 0);
            button_newCourse.Name = "button_newCourse";
            button_newCourse.Padding = new Padding(35, 0, 0, 0);
            button_newCourse.Size = new Size(206, 50);
            button_newCourse.TabIndex = 0;
            button_newCourse.Text = "New Course";
            button_newCourse.TextAlign = ContentAlignment.MiddleLeft;
            button_newCourse.UseVisualStyleBackColor = true;
            button_newCourse.Click += button_newCourse_Click;
            // 
            // button_course
            // 
            button_course.Dock = DockStyle.Top;
            button_course.FlatAppearance.BorderSize = 0;
            button_course.FlatStyle = FlatStyle.Flat;
            button_course.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button_course.ForeColor = Color.White;
            button_course.Location = new Point(0, 413);
            button_course.Name = "button_course";
            button_course.Padding = new Padding(10, 0, 0, 0);
            button_course.Size = new Size(206, 55);
            button_course.TabIndex = 4;
            button_course.Text = "Course";
            button_course.TextAlign = ContentAlignment.MiddleLeft;
            button_course.UseVisualStyleBackColor = true;
            button_course.Click += button_course_Click;
            // 
            // panel_studentmenu
            // 
            panel_studentmenu.BackColor = Color.Blue;
            panel_studentmenu.Controls.Add(button_stdPrint);
            panel_studentmenu.Controls.Add(button_status);
            panel_studentmenu.Controls.Add(button_manageStd);
            panel_studentmenu.Controls.Add(button_registration);
            panel_studentmenu.Dock = DockStyle.Top;
            panel_studentmenu.Location = new Point(0, 196);
            panel_studentmenu.Name = "panel_studentmenu";
            panel_studentmenu.Size = new Size(206, 217);
            panel_studentmenu.TabIndex = 3;
            // 
            // button_stdPrint
            // 
            button_stdPrint.Dock = DockStyle.Top;
            button_stdPrint.FlatAppearance.BorderSize = 0;
            button_stdPrint.FlatStyle = FlatStyle.Flat;
            button_stdPrint.Font = new Font("Century Gothic", 12F);
            button_stdPrint.ForeColor = Color.White;
            button_stdPrint.Location = new Point(0, 160);
            button_stdPrint.Name = "button_stdPrint";
            button_stdPrint.Padding = new Padding(35, 0, 0, 0);
            button_stdPrint.Size = new Size(206, 54);
            button_stdPrint.TabIndex = 3;
            button_stdPrint.Text = "print";
            button_stdPrint.TextAlign = ContentAlignment.MiddleLeft;
            button_stdPrint.UseVisualStyleBackColor = true;
            button_stdPrint.Click += button_stdPrint_Click;
            // 
            // button_status
            // 
            button_status.Dock = DockStyle.Top;
            button_status.FlatAppearance.BorderSize = 0;
            button_status.FlatStyle = FlatStyle.Flat;
            button_status.Font = new Font("Century Gothic", 12F);
            button_status.ForeColor = Color.White;
            button_status.Location = new Point(0, 110);
            button_status.Name = "button_status";
            button_status.Padding = new Padding(35, 0, 0, 0);
            button_status.Size = new Size(206, 50);
            button_status.TabIndex = 2;
            button_status.Text = "Status";
            button_status.TextAlign = ContentAlignment.MiddleLeft;
            button_status.UseVisualStyleBackColor = true;
            button_status.Click += button_status_Click;
            // 
            // button_manageStd
            // 
            button_manageStd.Dock = DockStyle.Top;
            button_manageStd.FlatAppearance.BorderSize = 0;
            button_manageStd.FlatStyle = FlatStyle.Flat;
            button_manageStd.Font = new Font("Century Gothic", 12F);
            button_manageStd.ForeColor = Color.White;
            button_manageStd.Location = new Point(0, 50);
            button_manageStd.Name = "button_manageStd";
            button_manageStd.Padding = new Padding(35, 0, 0, 0);
            button_manageStd.Size = new Size(206, 60);
            button_manageStd.TabIndex = 1;
            button_manageStd.Text = "Manage Student";
            button_manageStd.TextAlign = ContentAlignment.MiddleLeft;
            button_manageStd.UseVisualStyleBackColor = true;
            button_manageStd.Click += button_manageStd_Click;
            // 
            // button_registration
            // 
            button_registration.Dock = DockStyle.Top;
            button_registration.FlatAppearance.BorderSize = 0;
            button_registration.FlatStyle = FlatStyle.Flat;
            button_registration.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button_registration.ForeColor = Color.White;
            button_registration.Location = new Point(0, 0);
            button_registration.Name = "button_registration";
            button_registration.Padding = new Padding(35, 0, 0, 0);
            button_registration.Size = new Size(206, 50);
            button_registration.TabIndex = 0;
            button_registration.Text = "Registration";
            button_registration.TextAlign = ContentAlignment.MiddleLeft;
            button_registration.UseVisualStyleBackColor = true;
            button_registration.Click += button_registration_Click;
            // 
            // button_std
            // 
            button_std.Dock = DockStyle.Top;
            button_std.FlatAppearance.BorderSize = 0;
            button_std.FlatStyle = FlatStyle.Flat;
            button_std.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button_std.ForeColor = Color.White;
            button_std.Location = new Point(0, 141);
            button_std.Name = "button_std";
            button_std.Padding = new Padding(10, 0, 0, 0);
            button_std.Size = new Size(206, 55);
            button_std.TabIndex = 2;
            button_std.Text = "Student";
            button_std.TextAlign = ContentAlignment.MiddleLeft;
            button_std.UseVisualStyleBackColor = true;
            button_std.Click += button_std_Click;
            // 
            // panel_logo
            // 
            panel_logo.Controls.Add(label4);
            panel_logo.Controls.Add(label3);
            panel_logo.Controls.Add(label1);
            panel_logo.Dock = DockStyle.Top;
            panel_logo.Location = new Point(0, 0);
            panel_logo.Name = "panel_logo";
            panel_logo.Size = new Size(206, 141);
            panel_logo.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            label4.ForeColor = Color.White;
            label4.Location = new Point(31, 100);
            label4.Name = "label4";
            label4.Size = new Size(138, 23);
            label4.TabIndex = 3;
            label4.Text = "Madu School";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            label3.ForeColor = Color.White;
            label3.Location = new Point(21, 77);
            label3.Name = "label3";
            label3.Size = new Size(164, 23);
            label3.TabIndex = 2;
            label3.Text = "Welcome From ";
            label3.Click += label3_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Broadway", 36F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(56, 9);
            label1.Name = "label1";
            label1.Size = new Size(87, 68);
            label1.TabIndex = 1;
            label1.Text = "M";
            // 
            // panel_main
            // 
            panel_main.Controls.Add(pictureBox2);
            panel_main.Controls.Add(panel6);
            panel_main.Controls.Add(panel4);
            panel_main.Controls.Add(panel1);
            panel_main.Dock = DockStyle.Fill;
            panel_main.Location = new Point(227, 0);
            panel_main.Name = "panel_main";
            panel_main.Size = new Size(907, 613);
            panel_main.TabIndex = 1;
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(0, 155);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(907, 373);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 6;
            pictureBox2.TabStop = false;
            // 
            // panel6
            // 
            panel6.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel6.BackColor = Color.FromArgb(0, 71, 160);
            panel6.Controls.Add(label11);
            panel6.Controls.Add(label10);
            panel6.Controls.Add(label9);
            panel6.Controls.Add(label_femaleStd);
            panel6.Controls.Add(label_maleStd);
            panel6.Controls.Add(label_totalStd);
            panel6.Controls.Add(comboBox1);
            panel6.Location = new Point(0, 528);
            panel6.Name = "panel6";
            panel6.Size = new Size(907, 85);
            panel6.TabIndex = 5;
            // 
            // label11
            // 
            label11.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label11.AutoSize = true;
            label11.Font = new Font("Century Gothic", 12F);
            label11.ForeColor = Color.White;
            label11.Location = new Point(765, 53);
            label11.Name = "label11";
            label11.Size = new Size(95, 23);
            label11.TabIndex = 15;
            label11.Text = "Female :";
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label10.AutoSize = true;
            label10.Font = new Font("Century Gothic", 12F);
            label10.ForeColor = Color.White;
            label10.Location = new Point(663, 53);
            label10.Name = "label10";
            label10.Size = new Size(70, 23);
            label10.TabIndex = 14;
            label10.Text = "Male :";
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label9.AutoSize = true;
            label9.Font = new Font("Century Gothic", 12F);
            label9.ForeColor = Color.White;
            label9.Location = new Point(534, 22);
            label9.Name = "label9";
            label9.Size = new Size(139, 23);
            label9.TabIndex = 12;
            label9.Text = "Select Class :";
            // 
            // label_femaleStd
            // 
            label_femaleStd.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label_femaleStd.AutoSize = true;
            label_femaleStd.Font = new Font("Century Gothic", 12F);
            label_femaleStd.ForeColor = Color.White;
            label_femaleStd.Location = new Point(183, 53);
            label_femaleStd.Name = "label_femaleStd";
            label_femaleStd.Size = new Size(95, 23);
            label_femaleStd.TabIndex = 10;
            label_femaleStd.Text = "Female :";
            label_femaleStd.Click += label7_Click;
            // 
            // label_maleStd
            // 
            label_maleStd.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label_maleStd.AutoSize = true;
            label_maleStd.Font = new Font("Century Gothic", 12F);
            label_maleStd.ForeColor = Color.White;
            label_maleStd.Location = new Point(44, 53);
            label_maleStd.Name = "label_maleStd";
            label_maleStd.Size = new Size(70, 23);
            label_maleStd.TabIndex = 9;
            label_maleStd.Text = "Male :";
            // 
            // label_totalStd
            // 
            label_totalStd.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label_totalStd.AutoSize = true;
            label_totalStd.Font = new Font("Century Gothic", 12F);
            label_totalStd.ForeColor = Color.White;
            label_totalStd.Location = new Point(44, 19);
            label_totalStd.Name = "label_totalStd";
            label_totalStd.Size = new Size(157, 23);
            label_totalStd.TabIndex = 7;
            label_totalStd.Text = "Total Students :";
            // 
            // comboBox1
            // 
            comboBox1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            comboBox1.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(663, 19);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(211, 31);
            comboBox1.TabIndex = 13;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(0, 71, 160);
            panel4.Controls.Add(pictureBox1);
            panel4.Controls.Add(label_role);
            panel4.Controls.Add(label_user);
            panel4.Controls.Add(label5);
            panel4.Controls.Add(label2);
            panel4.Controls.Add(panel5);
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(0, 77);
            panel4.Name = "panel4";
            panel4.Size = new Size(907, 82);
            panel4.TabIndex = 3;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Right;
            pictureBox1.Image = Properties.Resources.student;
            pictureBox1.Location = new Point(765, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(142, 82);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click_1;
            // 
            // label_role
            // 
            label_role.AutoSize = true;
            label_role.Font = new Font("Century Gothic", 12F);
            label_role.ForeColor = Color.White;
            label_role.Location = new Point(164, 41);
            label_role.Name = "label_role";
            label_role.Size = new Size(73, 23);
            label_role.TabIndex = 8;
            label_role.Text = "Admin";
            // 
            // label_user
            // 
            label_user.AutoSize = true;
            label_user.Font = new Font("Century Gothic", 12F);
            label_user.ForeColor = Color.White;
            label_user.Location = new Point(164, 18);
            label_user.Name = "label_user";
            label_user.Size = new Size(79, 23);
            label_user.TabIndex = 7;
            label_user.Text = "Madhu";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 12F);
            label5.ForeColor = Color.White;
            label5.Location = new Point(94, 41);
            label5.Name = "label5";
            label5.Size = new Size(64, 23);
            label5.TabIndex = 6;
            label5.Text = "Role :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(44, 18);
            label2.Name = "label2";
            label2.Size = new Size(114, 23);
            label2.TabIndex = 5;
            label2.Text = "Welcome :";
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(0, 71, 160);
            panel5.Dock = DockStyle.Top;
            panel5.Location = new Point(0, 0);
            panel5.Name = "panel5";
            panel5.Size = new Size(907, 0);
            panel5.TabIndex = 4;
            panel5.Paint += panel5_Paint;
            // 
            // panel1
            // 
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(907, 77);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Controls.Add(panel_cover);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(907, 77);
            panel2.TabIndex = 1;
            // 
            // panel_cover
            // 
            panel_cover.Controls.Add(label12);
            panel_cover.Dock = DockStyle.Top;
            panel_cover.Location = new Point(0, 0);
            panel_cover.Name = "panel_cover";
            panel_cover.Size = new Size(907, 77);
            panel_cover.TabIndex = 2;
            panel_cover.Paint += panel3_Paint;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.ForeColor = Color.FromArgb(0, 71, 200);
            label12.Location = new Point(0, 27);
            label12.Name = "label12";
            label12.Size = new Size(424, 23);
            label12.TabIndex = 6;
            label12.Text = "Madhu Institute of Education , Mathugama";
            // 
            // panel3
            // 
            panel3.Location = new Point(0, 110);
            panel3.Name = "panel3";
            panel3.Size = new Size(203, 48);
            panel3.TabIndex = 7;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1134, 613);
            Controls.Add(panel_main);
            Controls.Add(panel_slide);
            MinimumSize = new Size(1150, 650);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            panel_slide.ResumeLayout(false);
            panel_score_menu.ResumeLayout(false);
            panel_course_menu.ResumeLayout(false);
            panel_studentmenu.ResumeLayout(false);
            panel_logo.ResumeLayout(false);
            panel_logo.PerformLayout();
            panel_main.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel_cover.ResumeLayout(false);
            panel_cover.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel_slide;
        private Button button_std;
        private Panel panel_logo;
        private Panel panel_studentmenu;
        private Button button_stdPrint;
        private Button button_status;
        private Button button_manageStd;
        private Button button_registration;
        private Panel panel_course_menu;
        private Button button_coursePrint;
        private Button button_manageCourse;
        private Button button_newCourse;
        private Button button_course;
        private Button button_dashboard;
        private Panel panel_score_menu;
        private Button button_manageScore;
        private Button button_newScore;
        private Button button_score;
        private Label label3;
        private Label label1;
        private Label label4;
        private Panel panel_main;
        private Panel panel1;
        private Panel panel2;
        private Panel panel_cover;
        private Panel panel4;
        private Panel panel5;
        private Panel panel6;
        private Label label5;
        private Label label2;
        private Label label_role;
        private Label label_user;
        private Label label_femaleStd;
        private Label label_maleStd;
        private Label label_totalStd;
        private Label label9;
        private ComboBox comboBox1;
        private Label label11;
        private Label label10;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label label12;
        private Button button_exit;
        private Button button_fun;
        private Panel panel3;
    }
}
