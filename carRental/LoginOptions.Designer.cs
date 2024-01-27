namespace carRental
{
    partial class LoginOptions
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginOptions));
            panel1 = new Panel();
            adminImage = new PictureBox();
            pictureBox4 = new PictureBox();
            panel3 = new Panel();
            panel2 = new Panel();
            label3 = new Label();
            label7 = new Label();
            label2 = new Label();
            label1 = new Label();
            userImage = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)adminImage).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)userImage).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(1, 30, 64);
            panel1.Controls.Add(adminImage);
            panel1.Controls.Add(pictureBox4);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(userImage);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1314, 748);
            panel1.TabIndex = 0;
            // 
            // adminImage
            // 
            adminImage.Anchor = AnchorStyles.Top;
            adminImage.Image = (Image)resources.GetObject("adminImage.Image");
            adminImage.Location = new Point(404, 182);
            adminImage.Name = "adminImage";
            adminImage.Size = new Size(113, 114);
            adminImage.SizeMode = PictureBoxSizeMode.StretchImage;
            adminImage.TabIndex = 9;
            adminImage.TabStop = false;
            adminImage.Click += adminImage_Click;
            // 
            // pictureBox4
            // 
            pictureBox4.Anchor = AnchorStyles.None;
            pictureBox4.Image = Properties.Resources.splash;
            pictureBox4.Location = new Point(375, 353);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(595, 351);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 4;
            pictureBox4.TabStop = false;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(69, 19, 54);
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(0, 710);
            panel3.Name = "panel3";
            panel3.Size = new Size(1314, 38);
            panel3.TabIndex = 8;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(69, 19, 54);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label7);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1314, 134);
            panel2.TabIndex = 7;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top;
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 20F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ControlLight;
            label3.Location = new Point(404, 26);
            label3.Name = "label3";
            label3.Size = new Size(493, 39);
            label3.TabIndex = 6;
            label3.Text = "THE CAR RENTAL SYSTAM ";
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top;
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = SystemColors.ControlLight;
            label7.Location = new Point(518, 80);
            label7.Name = "label7";
            label7.Size = new Size(269, 36);
            label7.TabIndex = 5;
            label7.Text = "CHOOSE PROFIL";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ButtonFace;
            label2.Location = new Point(856, 299);
            label2.Name = "label2";
            label2.Size = new Size(61, 28);
            label2.TabIndex = 5;
            label2.Text = "USER";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(423, 299);
            label1.Name = "label1";
            label1.Size = new Size(82, 28);
            label1.TabIndex = 4;
            label1.Text = "ADMIN";
            // 
            // userImage
            // 
            userImage.Anchor = AnchorStyles.Top;
            userImage.Image = (Image)resources.GetObject("userImage.Image");
            userImage.Location = new Point(828, 182);
            userImage.Name = "userImage";
            userImage.Size = new Size(120, 114);
            userImage.SizeMode = PictureBoxSizeMode.StretchImage;
            userImage.TabIndex = 2;
            userImage.TabStop = false;
            userImage.Click += userImage_Click;
            // 
            // LoginOptions
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1314, 748);
            Controls.Add(panel1);
            Name = "LoginOptions";
            Text = "LoginOptions";
            Load += LoginOptions_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)adminImage).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)userImage).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox userImage;
        private Label label2;
        private Label label1;
        private Panel panel2;
        private Panel panel3;
        private PictureBox pictureBox4;
        private PictureBox adminImage;
        private Label label3;
        private Label label7;
    }
}