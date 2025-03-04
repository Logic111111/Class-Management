namespace WinFormsApp6
{
    partial class PrintCourseForm
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
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle11 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle12 = new DataGridViewCellStyle();
            panel1 = new Panel();
            label6 = new Label();
            button_search = new Button();
            button_delete = new Button();
            dataGridView_student = new Guna.UI2.WinForms.Guna2DataGridView();
            textBox_search = new TextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_student).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.FromArgb(0, 71, 160);
            panel1.Controls.Add(label6);
            panel1.Font = new Font("Century Gothic", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            panel1.ForeColor = Color.White;
            panel1.Location = new Point(-146, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(1078, 70);
            panel1.TabIndex = 79;
            panel1.Paint += panel1_Paint;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(510, 22);
            label6.Name = "label6";
            label6.Size = new Size(158, 34);
            label6.TabIndex = 0;
            label6.Text = "Course List";
            // 
            // button_search
            // 
            button_search.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button_search.BackColor = Color.FromArgb(0, 71, 160);
            button_search.FlatStyle = FlatStyle.Flat;
            button_search.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            button_search.ForeColor = Color.White;
            button_search.Location = new Point(772, 77);
            button_search.Name = "button_search";
            button_search.Size = new Size(160, 47);
            button_search.TabIndex = 81;
            button_search.Text = "Search";
            button_search.UseVisualStyleBackColor = false;
            button_search.Click += button_search_Click;
            // 
            // button_delete
            // 
            button_delete.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button_delete.BackColor = Color.FromArgb(0, 71, 160);
            button_delete.FlatStyle = FlatStyle.Flat;
            button_delete.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            button_delete.ForeColor = Color.White;
            button_delete.Location = new Point(772, 544);
            button_delete.Name = "button_delete";
            button_delete.Size = new Size(147, 47);
            button_delete.TabIndex = 82;
            button_delete.Text = "Print";
            button_delete.UseVisualStyleBackColor = false;
            button_delete.Click += button_delete_Click;
            // 
            // dataGridView_student
            // 
            dataGridView_student.AllowUserToAddRows = false;
            dataGridView_student.AllowUserToDeleteRows = false;
            dataGridViewCellStyle9.BackColor = Color.White;
            dataGridView_student.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle9;
            dataGridView_student.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewCellStyle10.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle10.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle10.ForeColor = Color.White;
            dataGridViewCellStyle10.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = DataGridViewTriState.True;
            dataGridView_student.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            dataGridView_student.ColumnHeadersHeight = 24;
            dataGridView_student.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle11.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = Color.White;
            dataGridViewCellStyle11.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle11.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle11.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle11.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle11.WrapMode = DataGridViewTriState.False;
            dataGridView_student.DefaultCellStyle = dataGridViewCellStyle11;
            dataGridView_student.GridColor = Color.FromArgb(231, 229, 255);
            dataGridView_student.Location = new Point(3, 130);
            dataGridView_student.Name = "dataGridView_student";
            dataGridView_student.RowHeadersVisible = false;
            dataGridView_student.RowHeadersWidth = 51;
            dataGridViewCellStyle12.Font = new Font("Century Gothic", 8F);
            dataGridView_student.RowsDefaultCellStyle = dataGridViewCellStyle12;
            dataGridView_student.RowTemplate.Height = 80;
            dataGridView_student.Size = new Size(929, 379);
            dataGridView_student.TabIndex = 80;
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
            // 
            // textBox_search
            // 
            textBox_search.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            textBox_search.Location = new Point(564, 86);
            textBox_search.Name = "textBox_search";
            textBox_search.Size = new Size(202, 32);
            textBox_search.TabIndex = 83;
            // 
            // PrintCourseForm
            // 
            AutoScaleDimensions = new SizeF(12F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(932, 603);
            Controls.Add(textBox_search);
            Controls.Add(panel1);
            Controls.Add(button_search);
            Controls.Add(button_delete);
            Controls.Add(dataGridView_student);
            Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 3, 4, 3);
            Name = "PrintCourseForm";
            Text = "PrintCourseForm";
            Load += PrintCourseForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_student).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label6;
        private Button button_search;
        private Button button_delete;
        private Guna.UI2.WinForms.Guna2DataGridView dataGridView_student;
        private TextBox textBox_search;
    }
}