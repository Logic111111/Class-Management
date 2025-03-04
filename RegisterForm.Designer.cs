namespace WinFormsApp6
{
    partial class RegisterForm
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
            dataGridView_student = new Guna.UI2.WinForms.Guna2DataGridView();
            panel2 = new Panel();
            panel3 = new Panel();
            label2 = new Label();
            textBox_phone = new TextBox();
            button_add = new Button();
            button_clear = new Button();
            button_upload = new Button();
            pictureBox_student = new PictureBox();
            textBox_address = new TextBox();
            radioButton_female = new RadioButton();
            radioButton_male = new RadioButton();
            dateTimePicker1 = new DateTimePicker();
            label3 = new Label();
            textBox_lname = new TextBox();
            label5 = new Label();
            label1 = new Label();
            textBox_fname = new TextBox();
            label4 = new Label();
            label_lname = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_student).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox_student).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.FromArgb(0, 71, 160);
            panel1.Controls.Add(label6);
            panel1.Font = new Font("Century Gothic", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            panel1.ForeColor = Color.White;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(951, 85);
            panel1.TabIndex = 12;
            panel1.Paint += panel1_Paint_1;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(391, 30);
            label6.Name = "label6";
            label6.Size = new Size(171, 34);
            label6.TabIndex = 0;
            label6.Text = "Registration";
            // 
            // dataGridView_student
            // 
            dataGridView_student.AllowUserToAddRows = false;
            dataGridView_student.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = Color.White;
            dataGridView_student.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView_student.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
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
            dataGridView_student.Location = new Point(0, 91);
            dataGridView_student.Name = "dataGridView_student";
            dataGridView_student.RowHeadersVisible = false;
            dataGridView_student.RowHeadersWidth = 51;
            dataGridViewCellStyle4.Font = new Font("Century Gothic", 8F);
            dataGridView_student.RowsDefaultCellStyle = dataGridViewCellStyle4;
            dataGridView_student.RowTemplate.Height = 80;
            dataGridView_student.Size = new Size(951, 73);
            dataGridView_student.TabIndex = 13;
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
            // 
            // panel2
            // 
            panel2.Controls.Add(panel3);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(textBox_phone);
            panel2.Controls.Add(button_add);
            panel2.Controls.Add(button_clear);
            panel2.Controls.Add(button_upload);
            panel2.Controls.Add(pictureBox_student);
            panel2.Controls.Add(textBox_address);
            panel2.Controls.Add(radioButton_female);
            panel2.Controls.Add(radioButton_male);
            panel2.Controls.Add(dateTimePicker1);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(textBox_lname);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(textBox_fname);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label_lname);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 170);
            panel2.Name = "panel2";
            panel2.Size = new Size(952, 303);
            panel2.TabIndex = 14;
            panel2.Paint += panel2_Paint;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel3.BackColor = Color.FromArgb(0, 71, 160);
            panel3.ForeColor = Color.FromArgb(0, 71, 160);
            panel3.Location = new Point(1, 19);
            panel3.Name = "panel3";
            panel3.Size = new Size(911, 17);
            panel3.TabIndex = 32;
            panel3.Paint += panel3_Paint;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(0, 71, 160);
            label2.Location = new Point(610, 66);
            label2.Name = "label2";
            label2.Size = new Size(83, 23);
            label2.TabIndex = 30;
            label2.Text = "Phone :";
            // 
            // textBox_phone
            // 
            textBox_phone.Anchor = AnchorStyles.None;
            textBox_phone.Font = new Font("Century Gothic", 12F);
            textBox_phone.Location = new Point(699, 57);
            textBox_phone.Name = "textBox_phone";
            textBox_phone.Size = new Size(146, 32);
            textBox_phone.TabIndex = 31;
            // 
            // button_add
            // 
            button_add.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button_add.BackColor = Color.FromArgb(0, 71, 160);
            button_add.FlatStyle = FlatStyle.Flat;
            button_add.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            button_add.ForeColor = Color.White;
            button_add.Location = new Point(664, 237);
            button_add.Name = "button_add";
            button_add.Size = new Size(147, 47);
            button_add.TabIndex = 29;
            button_add.Text = "Add";
            button_add.UseVisualStyleBackColor = false;
            button_add.Click += button_add_Click_1;
            // 
            // button_clear
            // 
            button_clear.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button_clear.BackColor = Color.Orange;
            button_clear.FlatStyle = FlatStyle.Flat;
            button_clear.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            button_clear.ForeColor = Color.White;
            button_clear.Location = new Point(516, 237);
            button_clear.Name = "button_clear";
            button_clear.Size = new Size(142, 47);
            button_clear.TabIndex = 28;
            button_clear.Text = "Clear";
            button_clear.UseVisualStyleBackColor = false;
            button_clear.Click += button_clear_Click_1;
            // 
            // button_upload
            // 
            button_upload.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button_upload.BackColor = Color.Green;
            button_upload.FlatStyle = FlatStyle.Flat;
            button_upload.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            button_upload.ForeColor = Color.White;
            button_upload.Location = new Point(818, 237);
            button_upload.Name = "button_upload";
            button_upload.Size = new Size(134, 47);
            button_upload.TabIndex = 27;
            button_upload.Text = "upload";
            button_upload.UseVisualStyleBackColor = false;
            button_upload.Click += button_upload_Click_1;
            // 
            // pictureBox_student
            // 
            pictureBox_student.Anchor = AnchorStyles.Right;
            pictureBox_student.BackColor = Color.Gainsboro;
            pictureBox_student.Location = new Point(825, 100);
            pictureBox_student.Name = "pictureBox_student";
            pictureBox_student.Size = new Size(116, 131);
            pictureBox_student.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox_student.TabIndex = 26;
            pictureBox_student.TabStop = false;
            // 
            // textBox_address
            // 
            textBox_address.Anchor = AnchorStyles.None;
            textBox_address.Font = new Font("Century Gothic", 12F);
            textBox_address.Location = new Point(116, 159);
            textBox_address.Name = "textBox_address";
            textBox_address.Size = new Size(556, 32);
            textBox_address.TabIndex = 25;
            // 
            // radioButton_female
            // 
            radioButton_female.Anchor = AnchorStyles.None;
            radioButton_female.AutoSize = true;
            radioButton_female.BackColor = Color.White;
            radioButton_female.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            radioButton_female.ForeColor = Color.FromArgb(0, 71, 160);
            radioButton_female.Location = new Point(705, 120);
            radioButton_female.Name = "radioButton_female";
            radioButton_female.Size = new Size(104, 27);
            radioButton_female.TabIndex = 24;
            radioButton_female.Text = "Female";
            radioButton_female.UseVisualStyleBackColor = false;
            // 
            // radioButton_male
            // 
            radioButton_male.Anchor = AnchorStyles.None;
            radioButton_male.AutoSize = true;
            radioButton_male.BackColor = Color.White;
            radioButton_male.Checked = true;
            radioButton_male.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            radioButton_male.ForeColor = Color.FromArgb(0, 71, 160);
            radioButton_male.Location = new Point(619, 120);
            radioButton_male.Name = "radioButton_male";
            radioButton_male.Size = new Size(80, 27);
            radioButton_male.TabIndex = 23;
            radioButton_male.TabStop = true;
            radioButton_male.Text = "Male";
            radioButton_male.UseVisualStyleBackColor = false;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Anchor = AnchorStyles.None;
            dateTimePicker1.Font = new Font("Century Gothic", 12F);
            dateTimePicker1.Location = new Point(158, 115);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(353, 32);
            dateTimePicker1.TabIndex = 22;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(0, 71, 160);
            label3.Location = new Point(299, 66);
            label3.Name = "label3";
            label3.Size = new Size(122, 23);
            label3.TabIndex = 18;
            label3.Text = "Last name :";
            // 
            // textBox_lname
            // 
            textBox_lname.Anchor = AnchorStyles.None;
            textBox_lname.Font = new Font("Century Gothic", 12F);
            textBox_lname.Location = new Point(427, 57);
            textBox_lname.Name = "textBox_lname";
            textBox_lname.Size = new Size(146, 32);
            textBox_lname.TabIndex = 21;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(0, 71, 160);
            label5.Location = new Point(23, 159);
            label5.Name = "label5";
            label5.Size = new Size(87, 23);
            label5.TabIndex = 17;
            label5.Text = "Adress :";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(0, 71, 160);
            label1.Location = new Point(17, 120);
            label1.Name = "label1";
            label1.Size = new Size(140, 23);
            label1.TabIndex = 16;
            label1.Text = "Date of Birth :";
            // 
            // textBox_fname
            // 
            textBox_fname.Anchor = AnchorStyles.None;
            textBox_fname.Font = new Font("Century Gothic", 12F);
            textBox_fname.Location = new Point(147, 57);
            textBox_fname.Name = "textBox_fname";
            textBox_fname.Size = new Size(146, 32);
            textBox_fname.TabIndex = 20;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(0, 71, 160);
            label4.Location = new Point(517, 122);
            label4.Name = "label4";
            label4.Size = new Size(96, 23);
            label4.TabIndex = 19;
            label4.Text = "Gender :";
            // 
            // label_lname
            // 
            label_lname.Anchor = AnchorStyles.None;
            label_lname.AutoSize = true;
            label_lname.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_lname.ForeColor = Color.FromArgb(0, 71, 160);
            label_lname.Location = new Point(17, 66);
            label_lname.Name = "label_lname";
            label_lname.Size = new Size(124, 23);
            label_lname.TabIndex = 15;
            label_lname.Text = "First Name :";
            // 
            // RegisterForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.White;
            ClientSize = new Size(952, 473);
            Controls.Add(panel2);
            Controls.Add(dataGridView_student);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "RegisterForm";
            Text = "RegisterForm";
            Load += RegisterForm_Load_1;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_student).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox_student).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private Label label6;
        private Guna.UI2.WinForms.Guna2DataGridView dataGridView_student;
        private Panel panel2;
        private Panel panel3;
        private Label label2;
        private TextBox textBox_phone;
        private Button button_add;
        private Button button_clear;
        private Button button_upload;
        private PictureBox pictureBox_student;
        private TextBox textBox_address;
        private RadioButton radioButton_female;
        private RadioButton radioButton_male;
        private DateTimePicker dateTimePicker1;
        private Label label3;
        private TextBox textBox_lname;
        private Label label5;
        private Label label1;
        private TextBox textBox_fname;
        private Label label4;
        private Label label_lname;
    }
}