namespace carRental
{
    partial class AdminLoginPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminLoginPage));
            panel1 = new Panel();
            groupBox1 = new GroupBox();
            loginButton = new Button();
            showPasswordCheck = new CheckBox();
            label5 = new Label();
            passwordTextbox = new TextBox();
            label4 = new Label();
            emailTextbox = new TextBox();
            label2 = new Label();
            panel2 = new Panel();
            backButton = new PictureBox();
            label3 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)backButton).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(1, 30, 64);
            panel1.Controls.Add(groupBox1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1315, 724);
            panel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.FromArgb(69, 19, 54);
            groupBox1.Controls.Add(loginButton);
            groupBox1.Controls.Add(showPasswordCheck);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(passwordTextbox);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(emailTextbox);
            groupBox1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.ForeColor = SystemColors.ControlLight;
            groupBox1.Location = new Point(551, 133);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(612, 470);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "  SIGN IN  ";
            // 
            // loginButton
            // 
            loginButton.BackColor = Color.FromArgb(1, 30, 64);
            loginButton.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            loginButton.ForeColor = Color.FromArgb(224, 224, 224);
            loginButton.Location = new Point(216, 318);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(209, 49);
            loginButton.TabIndex = 7;
            loginButton.Text = "Log in";
            loginButton.UseVisualStyleBackColor = false;
            loginButton.Click += loginButton_Click;
            // 
            // showPasswordCheck
            // 
            showPasswordCheck.AutoSize = true;
            showPasswordCheck.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            showPasswordCheck.Location = new Point(262, 224);
            showPasswordCheck.Name = "showPasswordCheck";
            showPasswordCheck.Size = new Size(132, 24);
            showPasswordCheck.TabIndex = 5;
            showPasswordCheck.Text = "Show Password";
            showPasswordCheck.UseVisualStyleBackColor = true;
            showPasswordCheck.CheckedChanged += showPasswordCheck_CheckedChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(49, 172);
            label5.Name = "label5";
            label5.Size = new Size(119, 25);
            label5.TabIndex = 3;
            label5.Text = "Password: ";
            // 
            // passwordTextbox
            // 
            passwordTextbox.Font = new Font("Segoe UI Light", 12F, FontStyle.Regular, GraphicsUnit.Point);
            passwordTextbox.Location = new Point(188, 161);
            passwordTextbox.Multiline = true;
            passwordTextbox.Name = "passwordTextbox";
            passwordTextbox.PasswordChar = '*';
            passwordTextbox.Size = new Size(342, 35);
            passwordTextbox.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(86, 93);
            label4.Name = "label4";
            label4.Size = new Size(72, 25);
            label4.TabIndex = 1;
            label4.Text = "Email:";
            // 
            // emailTextbox
            // 
            emailTextbox.Font = new Font("Segoe UI Light", 12F, FontStyle.Regular, GraphicsUnit.Point);
            emailTextbox.Location = new Point(188, 82);
            emailTextbox.Multiline = true;
            emailTextbox.Name = "emailTextbox";
            emailTextbox.Size = new Size(342, 35);
            emailTextbox.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ButtonFace;
            label2.Location = new Point(739, 63);
            label2.Name = "label2";
            label2.Size = new Size(323, 36);
            label2.TabIndex = 1;
            label2.Text = "ADMIN LOGIN FORM";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(69, 19, 54);
            panel2.Controls.Add(backButton);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(pictureBox1);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(475, 724);
            panel2.TabIndex = 0;
            // 
            // backButton
            // 
            backButton.Image = Properties.Resources.backarrow;
            backButton.Location = new Point(12, 23);
            backButton.Name = "backButton";
            backButton.Size = new Size(35, 32);
            backButton.SizeMode = PictureBoxSizeMode.StretchImage;
            backButton.TabIndex = 4;
            backButton.TabStop = false;
            backButton.Click += backButton_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ControlLight;
            label3.Location = new Point(126, 441);
            label3.Name = "label3";
            label3.Size = new Size(269, 87);
            label3.TabIndex = 3;
            label3.Text = "      EVERY BRAND\r\nQUALITY GUARANTY\r\n WONDERFUL PRICE";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 20F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ControlLight;
            label1.Location = new Point(39, 93);
            label1.Name = "label1";
            label1.Size = new Size(397, 39);
            label1.TabIndex = 1;
            label1.Text = "CAR RENTAL PALACE";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(105, 160);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(260, 231);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // AdminLoginPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1315, 724);
            Controls.Add(panel1);
            Name = "AdminLoginPage";
            Text = "AdminLoginPage";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)backButton).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private PictureBox pictureBox1;
        private Label label2;
        private Label label3;
        private Label label1;
        private GroupBox groupBox1;
        private CheckBox showPasswordCheck;
        private Label label5;
        private TextBox passwordTextbox;
        private Label label4;
        private TextBox emailTextbox;
        private Button loginButton;
        private PictureBox backButton;
    }
}