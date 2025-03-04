namespace WinFormsApp6
{
    partial class CourseForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            panel1 = new Panel();
            label6 = new Label();
            dataGridView_course = new Guna.UI2.WinForms.Guna2DataGridView();
            panel3 = new Panel();
            textBox_Chour = new TextBox();
            label3 = new Label();
            label5 = new Label();
            textBox_Cname = new TextBox();
            textBox_description = new TextBox();
            label_lname = new Label();
            button_clear = new Button();
            button_add = new Button();
            panel2 = new Panel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_course).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.FromArgb(0, 71, 160);
            panel1.Controls.Add(label6);
            panel1.Font = new Font("Century Gothic", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            panel1.ForeColor = Color.White;
            panel1.Location = new Point(8, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(951, 85);
            panel1.TabIndex = 45;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label6.AutoSize = true;
            label6.Location = new Point(400, 23);
            label6.Name = "label6";
            label6.Size = new Size(180, 34);
            label6.TabIndex = 0;
            label6.Text = "New Course";
            // 
            // dataGridView_course
            // 
            dataGridView_course.AllowUserToAddRows = false;
            dataGridView_course.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = Color.White;
            dataGridView_course.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView_course.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView_course.BackgroundColor = Color.Gray;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridView_course.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridView_course.ColumnHeadersHeight = 24;
            dataGridView_course.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dataGridView_course.DefaultCellStyle = dataGridViewCellStyle3;
            dataGridView_course.GridColor = Color.FromArgb(231, 229, 255);
            dataGridView_course.Location = new Point(9, 94);
            dataGridView_course.Name = "dataGridView_course";
            dataGridView_course.RowHeadersVisible = false;
            dataGridView_course.RowHeadersWidth = 51;
            dataGridViewCellStyle4.Font = new Font("Century Gothic", 8F);
            dataGridView_course.RowsDefaultCellStyle = dataGridViewCellStyle4;
            dataGridView_course.RowTemplate.Height = 80;
            dataGridView_course.Size = new Size(951, 103);
            dataGridView_course.TabIndex = 50;
            dataGridView_course.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            dataGridView_course.ThemeStyle.AlternatingRowsStyle.Font = null;
            dataGridView_course.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            dataGridView_course.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            dataGridView_course.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            dataGridView_course.ThemeStyle.BackColor = Color.Gray;
            dataGridView_course.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            dataGridView_course.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            dataGridView_course.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridView_course.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 9F);
            dataGridView_course.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            dataGridView_course.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridView_course.ThemeStyle.HeaderStyle.Height = 24;
            dataGridView_course.ThemeStyle.ReadOnly = false;
            dataGridView_course.ThemeStyle.RowsStyle.BackColor = Color.White;
            dataGridView_course.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridView_course.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9F);
            dataGridView_course.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridView_course.ThemeStyle.RowsStyle.Height = 80;
            dataGridView_course.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridView_course.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel3.BackColor = Color.FromArgb(0, 71, 160);
            panel3.ForeColor = Color.FromArgb(0, 71, 160);
            panel3.Location = new Point(12, 203);
            panel3.Name = "panel3";
            panel3.Size = new Size(947, 22);
            panel3.TabIndex = 51;
            // 
            // textBox_Chour
            // 
            textBox_Chour.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            textBox_Chour.Font = new Font("Century Gothic", 12F);
            textBox_Chour.Location = new Point(3, 114);
            textBox_Chour.Name = "textBox_Chour";
            textBox_Chour.Size = new Size(146, 32);
            textBox_Chour.TabIndex = 34;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(0, 71, 160);
            label3.Location = new Point(3, 88);
            label3.Name = "label3";
            label3.Size = new Size(67, 23);
            label3.TabIndex = 32;
            label3.Text = "Hour :";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(0, 71, 160);
            label5.Location = new Point(3, 160);
            label5.Name = "label5";
            label5.Size = new Size(131, 23);
            label5.TabIndex = 49;
            label5.Text = "Description :";
            // 
            // textBox_Cname
            // 
            textBox_Cname.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            textBox_Cname.Font = new Font("Century Gothic", 12F);
            textBox_Cname.Location = new Point(3, 37);
            textBox_Cname.Name = "textBox_Cname";
            textBox_Cname.Size = new Size(146, 32);
            textBox_Cname.TabIndex = 47;
            // 
            // textBox_description
            // 
            textBox_description.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            textBox_description.Font = new Font("Century Gothic", 12F);
            textBox_description.Location = new Point(3, 186);
            textBox_description.Multiline = true;
            textBox_description.Name = "textBox_description";
            textBox_description.Size = new Size(445, 59);
            textBox_description.TabIndex = 38;
            // 
            // label_lname
            // 
            label_lname.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label_lname.AutoSize = true;
            label_lname.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_lname.ForeColor = Color.FromArgb(0, 71, 160);
            label_lname.Location = new Point(3, 11);
            label_lname.Name = "label_lname";
            label_lname.Size = new Size(157, 23);
            label_lname.TabIndex = 46;
            label_lname.Text = "Course Name :";
            // 
            // button_clear
            // 
            button_clear.Anchor = AnchorStyles.Right;
            button_clear.BackColor = Color.Orange;
            button_clear.FlatStyle = FlatStyle.Flat;
            button_clear.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            button_clear.ForeColor = Color.White;
            button_clear.Location = new Point(609, 198);
            button_clear.Name = "button_clear";
            button_clear.Size = new Size(142, 47);
            button_clear.TabIndex = 50;
            button_clear.Text = "Clear";
            button_clear.UseVisualStyleBackColor = false;
            button_clear.Click += button_clear_Click;
            // 
            // button_add
            // 
            button_add.Anchor = AnchorStyles.Right;
            button_add.BackColor = Color.FromArgb(0, 71, 160);
            button_add.FlatStyle = FlatStyle.Flat;
            button_add.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            button_add.ForeColor = Color.White;
            button_add.Location = new Point(757, 198);
            button_add.Name = "button_add";
            button_add.Size = new Size(147, 47);
            button_add.TabIndex = 51;
            button_add.Text = "Add";
            button_add.UseVisualStyleBackColor = false;
            button_add.Click += button_add_Click;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel2.Controls.Add(button_add);
            panel2.Controls.Add(button_clear);
            panel2.Controls.Add(label_lname);
            panel2.Controls.Add(textBox_description);
            panel2.Controls.Add(textBox_Cname);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(textBox_Chour);
            panel2.Location = new Point(12, 231);
            panel2.Name = "panel2";
            panel2.Size = new Size(952, 250);
            panel2.TabIndex = 52;
            panel2.Paint += panel2_Paint;
            // 
            // CourseForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(972, 493);
            Controls.Add(panel2);
            Controls.Add(panel3);
            Controls.Add(dataGridView_course);
            Controls.Add(panel1);
            Name = "CourseForm";
            Text = "CourseForm";
            Load += CourseForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_course).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private Label label6;
        private Guna.UI2.WinForms.Guna2DataGridView dataGridView_course;
        private Panel panel3;
        private TextBox textBox_Chour;
        private Label label3;
        private Label label5;
        private TextBox textBox_Cname;
        private TextBox textBox_description;
        private Label label_lname;
        private Button button_clear;
        private Button button_add;
        private Panel panel2;
    }
}