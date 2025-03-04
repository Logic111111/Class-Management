namespace WinFormsApp6
{
    partial class LogingForm
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
            panel1 = new Panel();
            label5 = new Label();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            pictureBox2 = new PictureBox();
            textBox_username = new TextBox();
            textBox_password = new TextBox();
            label3 = new Label();
            label4 = new Label();
            button_login = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.FromArgb(0, 71, 160);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(2, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(950, 74);
            panel1.TabIndex = 0;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(923, 0);
            label5.Name = "label5";
            label5.Size = new Size(24, 23);
            label5.TabIndex = 1;
            label5.Text = "X";
            label5.Click += label1_Click;
            label5.MouseEnter += label5_MouseEnter;
            label5.MouseLeave += label5_MouseLeave;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(121, 24);
            label2.Name = "label2";
            label2.Size = new Size(176, 23);
            label2.TabIndex = 1;
            label2.Text = "Madhu Institution";
            label2.Click += label1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.student;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(115, 71);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(0, 71, 160);
            label1.Location = new Point(332, 276);
            label1.Name = "label1";
            label1.Size = new Size(199, 27);
            label1.TabIndex = 1;
            label1.Text = "Please Login First";
            label1.Click += label1_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.student;
            pictureBox2.Location = new Point(384, 175);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(110, 86);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // textBox_username
            // 
            textBox_username.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox_username.Location = new Point(322, 330);
            textBox_username.Name = "textBox_username";
            textBox_username.Size = new Size(310, 32);
            textBox_username.TabIndex = 2;
            // 
            // textBox_password
            // 
            textBox_password.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox_password.Location = new Point(322, 394);
            textBox_password.Name = "textBox_password";
            textBox_password.Size = new Size(310, 32);
            textBox_password.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(0, 71, 160);
            label3.Location = new Point(171, 339);
            label3.Name = "label3";
            label3.Size = new Size(128, 23);
            label3.TabIndex = 1;
            label3.Text = "User Name :";
            label3.Click += label1_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(0, 71, 160);
            label4.Location = new Point(171, 399);
            label4.Name = "label4";
            label4.Size = new Size(130, 27);
            label4.TabIndex = 1;
            label4.Text = "Password :";
            label4.Click += label1_Click;
            // 
            // button_login
            // 
            button_login.BackColor = Color.FromArgb(0, 71, 160);
            button_login.FlatStyle = FlatStyle.Flat;
            button_login.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_login.Location = new Point(322, 468);
            button_login.Name = "button_login";
            button_login.Size = new Size(310, 40);
            button_login.TabIndex = 3;
            button_login.Text = "Login";
            button_login.UseVisualStyleBackColor = false;
            button_login.Click += button_login_Click;
            // 
            // LogingForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(950, 650);
            Controls.Add(button_login);
            Controls.Add(textBox_password);
            Controls.Add(textBox_username);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(pictureBox2);
            Controls.Add(panel1);
            ForeColor = SystemColors.ControlLight;
            FormBorderStyle = FormBorderStyle.None;
            Name = "LogingForm";
            Text = "LogingForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private PictureBox pictureBox2;
        private TextBox textBox_username;
        private TextBox textBox_password;
        private Label label3;
        private Label label4;
        private Button button_login;
        private Label label5;
    }
}