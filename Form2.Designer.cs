namespace WinFormsApp6
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            panelBlocks = new Panel();
            btnGenerate = new Button();
            btnSort = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panelBlocks
            // 
            panelBlocks.AllowDrop = true;
            panelBlocks.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panelBlocks.BackColor = Color.LightGray;
            panelBlocks.Location = new Point(228, 12);
            panelBlocks.Name = "panelBlocks";
            panelBlocks.Size = new Size(329, 217);
            panelBlocks.TabIndex = 0;
            // 
            // btnGenerate
            // 
            btnGenerate.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnGenerate.BackColor = Color.FromArgb(0, 71, 160);
            btnGenerate.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            btnGenerate.ForeColor = Color.White;
            btnGenerate.Location = new Point(134, 313);
            btnGenerate.Name = "btnGenerate";
            btnGenerate.Size = new Size(118, 61);
            btnGenerate.TabIndex = 1;
            btnGenerate.Text = "Generate";
            btnGenerate.UseVisualStyleBackColor = false;
            btnGenerate.Click += btnGenerate_Click_1;
            // 
            // btnSort
            // 
            btnSort.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnSort.BackColor = Color.FromArgb(0, 71, 160);
            btnSort.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            btnSort.ForeColor = Color.White;
            btnSort.Location = new Point(550, 313);
            btnSort.Name = "btnSort";
            btnSort.Size = new Size(118, 61);
            btnSort.TabIndex = 1;
            btnSort.Text = "Sort";
            btnSort.UseVisualStyleBackColor = false;
            btnSort.Click += btnSort_Click_1;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(1, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(801, 453);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSort);
            Controls.Add(btnGenerate);
            Controls.Add(panelBlocks);
            Controls.Add(pictureBox1);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelBlocks;
        private Button btnGenerate;
        private Button btnSort;
        private PictureBox pictureBox1;
    }
}