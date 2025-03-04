
namespace WinFormsApp6
{
    partial class ScoreForm
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
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            button_add = new Button();
            button_clear = new Button();
            label_lname = new Label();
            textBox_description = new TextBox();
            textBox_stdid = new TextBox();
            label5 = new Label();
            label3 = new Label();
            textBox_Score = new TextBox();
            panel3 = new Panel();
            dataGridView_student = new Guna.UI2.WinForms.Guna2DataGridView();
            panel1 = new Panel();
            label2 = new Label();
            label6 = new Label();
            comboBox_course = new ComboBox();
            label1 = new Label();
            dataGridView_score = new Guna.UI2.WinForms.Guna2DataGridView();
            panel2 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dataGridView_student).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_score).BeginInit();
            SuspendLayout();
            // 
            // button_add
            // 
            button_add.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button_add.BackColor = Color.FromArgb(0, 71, 160);
            button_add.FlatStyle = FlatStyle.Flat;
            button_add.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            button_add.ForeColor = Color.White;
            button_add.Location = new Point(782, 550);
            button_add.Name = "button_add";
            button_add.Size = new Size(147, 47);
            button_add.TabIndex = 59;
            button_add.Text = "Add";
            button_add.UseVisualStyleBackColor = false;
            button_add.Click += button_add_Click;
            // 
            // button_clear
            // 
            button_clear.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button_clear.BackColor = Color.Orange;
            button_clear.FlatStyle = FlatStyle.Flat;
            button_clear.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            button_clear.ForeColor = Color.White;
            button_clear.Location = new Point(634, 550);
            button_clear.Name = "button_clear";
            button_clear.Size = new Size(142, 47);
            button_clear.TabIndex = 58;
            button_clear.Text = "Clear";
            button_clear.UseVisualStyleBackColor = false;
            button_clear.Click += button_clear_Click;
            // 
            // label_lname
            // 
            label_lname.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label_lname.AutoSize = true;
            label_lname.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_lname.ForeColor = Color.FromArgb(0, 71, 160);
            label_lname.Location = new Point(41, 364);
            label_lname.Name = "label_lname";
            label_lname.Size = new Size(119, 23);
            label_lname.TabIndex = 55;
            label_lname.Text = "Student Id :";
            label_lname.Click += label_lname_Click;
            // 
            // textBox_description
            // 
            textBox_description.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            textBox_description.Font = new Font("Century Gothic", 12F);
            textBox_description.Location = new Point(190, 538);
            textBox_description.Multiline = true;
            textBox_description.Name = "textBox_description";
            textBox_description.Size = new Size(422, 59);
            textBox_description.TabIndex = 54;
            // 
            // textBox_stdid
            // 
            textBox_stdid.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            textBox_stdid.Font = new Font("Century Gothic", 12F);
            textBox_stdid.Location = new Point(190, 355);
            textBox_stdid.Name = "textBox_stdid";
            textBox_stdid.Size = new Size(403, 32);
            textBox_stdid.TabIndex = 56;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(0, 71, 160);
            label5.Location = new Point(29, 562);
            label5.Name = "label5";
            label5.Size = new Size(131, 23);
            label5.TabIndex = 57;
            label5.Text = "Description :";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(0, 71, 160);
            label3.Location = new Point(83, 480);
            label3.Name = "label3";
            label3.Size = new Size(77, 23);
            label3.TabIndex = 52;
            label3.Text = "Score :";
            label3.Click += label3_Click;
            // 
            // textBox_Score
            // 
            textBox_Score.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            textBox_Score.Font = new Font("Century Gothic", 12F);
            textBox_Score.Location = new Point(190, 477);
            textBox_Score.Name = "textBox_Score";
            textBox_Score.Size = new Size(146, 32);
            textBox_Score.TabIndex = 53;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel3.BackColor = Color.FromArgb(0, 71, 160);
            panel3.ForeColor = Color.FromArgb(0, 71, 160);
            panel3.Location = new Point(2, 318);
            panel3.Name = "panel3";
            panel3.Size = new Size(923, 22);
            panel3.TabIndex = 62;
            // 
            // dataGridView_student
            // 
            dataGridView_student.AllowUserToAddRows = false;
            dataGridView_student.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = Color.White;
            dataGridView_student.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView_student.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            dataGridView_student.BackgroundColor = Color.Gray;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridView_student.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridView_student.ColumnHeadersHeight = 24;
            dataGridView_student.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dataGridView_student.DefaultCellStyle = dataGridViewCellStyle3;
            dataGridView_student.GridColor = Color.FromArgb(231, 229, 255);
            dataGridView_student.Location = new Point(3, 93);
            dataGridView_student.Name = "dataGridView_student";
            dataGridView_student.RowHeadersVisible = false;
            dataGridView_student.RowHeadersWidth = 51;
            dataGridViewCellStyle4.Font = new Font("Century Gothic", 8F);
            dataGridView_student.RowsDefaultCellStyle = dataGridViewCellStyle4;
            dataGridView_student.RowTemplate.Height = 80;
            dataGridView_student.Size = new Size(448, 219);
            dataGridView_student.TabIndex = 61;
            dataGridView_student.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            dataGridView_student.ThemeStyle.AlternatingRowsStyle.Font = null;
            dataGridView_student.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            dataGridView_student.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            dataGridView_student.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            dataGridView_student.ThemeStyle.BackColor = Color.Gray;
            dataGridView_student.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            dataGridView_student.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            dataGridView_student.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridView_student.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 9F);
            dataGridView_student.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            dataGridView_student.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridView_student.ThemeStyle.HeaderStyle.Height = 24;
            dataGridView_student.ThemeStyle.ReadOnly = false;
            dataGridView_student.ThemeStyle.RowsStyle.BackColor = Color.White;
            dataGridView_student.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridView_student.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9F);
            dataGridView_student.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridView_student.ThemeStyle.RowsStyle.Height = 80;
            dataGridView_student.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridView_student.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridView_student.CellContentClick += dataGridView_student_CellContentClick;
            dataGridView_student.Click += dataGridView_student_Click;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.FromArgb(0, 71, 160);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label6);
            panel1.Font = new Font("Century Gothic", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            panel1.ForeColor = Color.White;
            panel1.Location = new Point(2, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(927, 85);
            panel1.TabIndex = 60;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Location = new Point(658, 42);
            label2.Name = "label2";
            label2.Size = new Size(140, 34);
            label2.TabIndex = 0;
            label2.Text = "Score List";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label6.AutoSize = true;
            label6.Location = new Point(143, 42);
            label6.Name = "label6";
            label6.Size = new Size(163, 34);
            label6.TabIndex = 0;
            label6.Text = "Student List";
            // 
            // comboBox_course
            // 
            comboBox_course.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            comboBox_course.FormattingEnabled = true;
            comboBox_course.Location = new Point(190, 419);
            comboBox_course.Name = "comboBox_course";
            comboBox_course.Size = new Size(314, 31);
            comboBox_course.TabIndex = 63;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(0, 71, 160);
            label1.Location = new Point(3, 422);
            label1.Name = "label1";
            label1.Size = new Size(157, 23);
            label1.TabIndex = 55;
            label1.Text = "Select Course :";
            label1.Click += label1_Click;
            // 
            // dataGridView_score
            // 
            dataGridView_score.AllowUserToAddRows = false;
            dataGridView_score.AllowUserToDeleteRows = false;
            dataGridViewCellStyle5.BackColor = Color.White;
            dataGridView_score.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            dataGridView_score.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            dataGridView_score.BackgroundColor = Color.Gray;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle6.ForeColor = Color.White;
            dataGridViewCellStyle6.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            dataGridView_score.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            dataGridView_score.ColumnHeadersHeight = 24;
            dataGridView_score.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = Color.White;
            dataGridViewCellStyle7.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle7.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle7.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle7.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.False;
            dataGridView_score.DefaultCellStyle = dataGridViewCellStyle7;
            dataGridView_score.GridColor = Color.FromArgb(231, 229, 255);
            dataGridView_score.Location = new Point(486, 93);
            dataGridView_score.Name = "dataGridView_score";
            dataGridView_score.RowHeadersVisible = false;
            dataGridView_score.RowHeadersWidth = 51;
            dataGridViewCellStyle8.Font = new Font("Century Gothic", 8F);
            dataGridView_score.RowsDefaultCellStyle = dataGridViewCellStyle8;
            dataGridView_score.RowTemplate.Height = 80;
            dataGridView_score.Size = new Size(443, 219);
            dataGridView_score.TabIndex = 64;
            dataGridView_score.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            dataGridView_score.ThemeStyle.AlternatingRowsStyle.Font = null;
            dataGridView_score.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            dataGridView_score.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            dataGridView_score.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            dataGridView_score.ThemeStyle.BackColor = Color.Gray;
            dataGridView_score.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            dataGridView_score.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            dataGridView_score.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridView_score.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 9F);
            dataGridView_score.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            dataGridView_score.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridView_score.ThemeStyle.HeaderStyle.Height = 24;
            dataGridView_score.ThemeStyle.ReadOnly = false;
            dataGridView_score.ThemeStyle.RowsStyle.BackColor = Color.White;
            dataGridView_score.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridView_score.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9F);
            dataGridView_score.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridView_score.ThemeStyle.RowsStyle.Height = 80;
            dataGridView_score.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridView_score.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            panel2.BackColor = Color.FromArgb(0, 71, 160);
            panel2.Location = new Point(457, 93);
            panel2.Name = "panel2";
            panel2.Size = new Size(23, 220);
            panel2.TabIndex = 65;
            // 
            // ScoreForm
            // 
            AutoScaleDimensions = new SizeF(12F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(932, 603);
            Controls.Add(panel2);
            Controls.Add(dataGridView_score);
            Controls.Add(comboBox_course);
            Controls.Add(panel3);
            Controls.Add(dataGridView_student);
            Controls.Add(panel1);
            Controls.Add(button_add);
            Controls.Add(button_clear);
            Controls.Add(label1);
            Controls.Add(label_lname);
            Controls.Add(textBox_description);
            Controls.Add(textBox_stdid);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(textBox_Score);
            Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 3, 4, 3);
            Name = "ScoreForm";
            Text = "ScoreForm";
            Load += ScoreForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView_student).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_score).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        /*private void ScoreForm_Load(object sender, EventArgs e)
        {
            throw new NotImplementedException();

        }*/

        private void label3_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private Button button_add;
        private Button button_clear;
        private Label label_lname;
        private TextBox textBox_description;
        private TextBox textBox_Cname;
        private Label label5;
        private Label label3;
        private TextBox textBox_Chour;
        private Panel panel3;
        private Guna.UI2.WinForms.Guna2DataGridView dataGridView_student;
        private Panel panel1;
        private Label label6;
        private ComboBox comboBox_course;
        private Label label1;
        private TextBox textBox_Score;
        private TextBox textBox_stdid;
        private Guna.UI2.WinForms.Guna2DataGridView dataGridView_score;
        private Panel panel2;
        private Label label2;
    }
}