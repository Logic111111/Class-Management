
namespace WinFormsApp6
{
    partial class PrintStudent
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
            button_search = new Button();
            button_delete = new Button();
            label2 = new Label();
            comboBox_class = new ComboBox();
            radioButton_female = new RadioButton();
            radioButton_male = new RadioButton();
            radioButton_all = new RadioButton();
            label4 = new Label();
            panel3 = new Panel();
            dataGridView_student = new Guna.UI2.WinForms.Guna2DataGridView();
            panel1 = new Panel();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView_student).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // button_search
            // 
            button_search.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button_search.BackColor = Color.FromArgb(0, 71, 160);
            button_search.FlatStyle = FlatStyle.Flat;
            button_search.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            button_search.ForeColor = Color.White;
            button_search.Location = new Point(857, 72);
            button_search.Name = "button_search";
            button_search.Size = new Size(147, 47);
            button_search.TabIndex = 77;
            button_search.Text = "Search";
            button_search.UseVisualStyleBackColor = false;
            button_search.Click += button_search_Click;
            // 
            // button_delete
            // 
            button_delete.Anchor = AnchorStyles.Right;
            button_delete.BackColor = Color.FromArgb(0, 71, 160);
            button_delete.FlatStyle = FlatStyle.Flat;
            button_delete.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            button_delete.ForeColor = Color.White;
            button_delete.Location = new Point(848, 475);
            button_delete.Name = "button_delete";
            button_delete.Size = new Size(147, 47);
            button_delete.TabIndex = 78;
            button_delete.Text = "Print";
            button_delete.UseVisualStyleBackColor = false;
            button_delete.Click += this.button_delete_Click;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(0, 71, 160);
            label2.Location = new Point(479, 81);
            label2.Name = "label2";
            label2.Size = new Size(125, 23);
            label2.TabIndex = 76;
            label2.Text = "Select class";
            // 
            // comboBox_class
            // 
            comboBox_class.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            comboBox_class.FormattingEnabled = true;
            comboBox_class.Location = new Point(641, 81);
            comboBox_class.Name = "comboBox_class";
            comboBox_class.Size = new Size(197, 28);
            comboBox_class.TabIndex = 75;
            // 
            // radioButton_female
            // 
            radioButton_female.Anchor = AnchorStyles.None;
            radioButton_female.AutoSize = true;
            radioButton_female.BackColor = Color.White;
            radioButton_female.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            radioButton_female.ForeColor = Color.FromArgb(0, 71, 160);
            radioButton_female.Location = new Point(327, 473);
            radioButton_female.Name = "radioButton_female";
            radioButton_female.Size = new Size(104, 27);
            radioButton_female.TabIndex = 74;
            radioButton_female.Text = "Female";
            radioButton_female.UseVisualStyleBackColor = false;
            // 
            // radioButton_male
            // 
            radioButton_male.Anchor = AnchorStyles.None;
            radioButton_male.AutoSize = true;
            radioButton_male.BackColor = Color.White;
            radioButton_male.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            radioButton_male.ForeColor = Color.FromArgb(0, 71, 160);
            radioButton_male.Location = new Point(225, 473);
            radioButton_male.Name = "radioButton_male";
            radioButton_male.Size = new Size(80, 27);
            radioButton_male.TabIndex = 73;
            radioButton_male.Text = "Male";
            radioButton_male.UseVisualStyleBackColor = false;
            // 
            // radioButton_all
            // 
            radioButton_all.Anchor = AnchorStyles.None;
            radioButton_all.AutoSize = true;
            radioButton_all.BackColor = Color.White;
            radioButton_all.Checked = true;
            radioButton_all.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            radioButton_all.ForeColor = Color.FromArgb(0, 71, 160);
            radioButton_all.Location = new Point(146, 473);
            radioButton_all.Name = "radioButton_all";
            radioButton_all.Size = new Size(56, 27);
            radioButton_all.TabIndex = 72;
            radioButton_all.TabStop = true;
            radioButton_all.Text = "All";
            radioButton_all.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(0, 71, 160);
            label4.Location = new Point(29, 475);
            label4.Name = "label4";
            label4.Size = new Size(96, 23);
            label4.TabIndex = 71;
            label4.Text = "Gender :";
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            panel3.BackColor = Color.FromArgb(0, 71, 160);
            panel3.ForeColor = Color.FromArgb(0, 71, 160);
            panel3.Location = new Point(-84, 390);
            panel3.Name = "panel3";
            panel3.Size = new Size(1178, 23);
            panel3.TabIndex = 70;
            // 
            // dataGridView_student
            // 
            dataGridView_student.AllowUserToAddRows = false;
            dataGridView_student.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = Color.White;
            dataGridView_student.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView_student.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
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
            dataGridView_student.Location = new Point(1, 125);
            dataGridView_student.Name = "dataGridView_student";
            dataGridView_student.RowHeadersVisible = false;
            dataGridView_student.RowHeadersWidth = 51;
            dataGridViewCellStyle4.Font = new Font("Century Gothic", 8F);
            dataGridView_student.RowsDefaultCellStyle = dataGridViewCellStyle4;
            dataGridView_student.RowTemplate.Height = 80;
            dataGridView_student.Size = new Size(1003, 242);
            dataGridView_student.TabIndex = 69;
            dataGridView_student.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            dataGridView_student.ThemeStyle.AlternatingRowsStyle.Font = null;
            dataGridView_student.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            dataGridView_student.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            dataGridView_student.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            dataGridView_student.ThemeStyle.BackColor = Color.White;
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
            dataGridView_student.CellContentClick += this.dataGridView_student_CellContentClick;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.FromArgb(0, 71, 160);
            panel1.Controls.Add(label6);
            panel1.Font = new Font("Century Gothic", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            panel1.ForeColor = Color.White;
            panel1.Location = new Point(-84, -2);
            panel1.Name = "panel1";
            panel1.Size = new Size(1088, 72);
            panel1.TabIndex = 68;
            panel1.Paint += this.panel1_Paint;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(510, 22);
            label6.Name = "label6";
            label6.Size = new Size(110, 34);
            label6.TabIndex = 0;
            label6.Text = "To Print";
            label6.Click += this.label6_Click;
            // 
            // PrintStudent
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1007, 571);
            Controls.Add(button_search);
            Controls.Add(button_delete);
            Controls.Add(label2);
            Controls.Add(comboBox_class);
            Controls.Add(radioButton_female);
            Controls.Add(radioButton_male);
            Controls.Add(radioButton_all);
            Controls.Add(label4);
            Controls.Add(panel3);
            Controls.Add(dataGridView_student);
            Controls.Add(panel1);
            Name = "PrintStudent";
            Text = "pasi";
            Load += PrintStudent_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView_student).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void label6_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void dataGridView_student_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            printer.Title = "Mdemy Students list";
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

        #endregion

        private Button button_search;
        private Button button_delete;
        private Label label2;
        private ComboBox comboBox_class;
        private RadioButton radioButton_female;
        private RadioButton radioButton_male;
        private RadioButton radioButton_all;
        private Label label4;
        private Panel panel3;
        private Guna.UI2.WinForms.Guna2DataGridView dataGridView_student;
        private Panel panel1;
        private Label label6;
    }
}