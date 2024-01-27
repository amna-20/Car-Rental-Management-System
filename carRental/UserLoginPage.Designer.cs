namespace carRental
{
    partial class UserLoginPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserLoginPage));
            panel1 = new Panel();
            signInBox = new GroupBox();
            forgotPasswordLabel = new Label();
            loginButton = new Button();
            showPasswordCheck = new CheckBox();
            label5 = new Label();
            passwordTextbox = new TextBox();
            label4 = new Label();
            emailTextbox = new TextBox();
            userLoginLabel = new Label();
            panel2 = new Panel();
            backButton = new PictureBox();
            label3 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            passwordresetBox = new GroupBox();
            signInLabel = new Label();
            sendButton = new Button();
            label9 = new Label();
            textBox2 = new TextBox();
            panel1.SuspendLayout();
            signInBox.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)backButton).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            passwordresetBox.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(1, 30, 64);
            panel1.Controls.Add(userLoginLabel);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(passwordresetBox);
            panel1.Dock = DockStyle.Fill;
            panel1.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1257, 710);
            panel1.TabIndex = 1;
            // 
            // signInBox
            // 
            signInBox.BackColor = Color.FromArgb(69, 19, 54);
            signInBox.Controls.Add(forgotPasswordLabel);
            signInBox.Controls.Add(loginButton);
            signInBox.Controls.Add(showPasswordCheck);
            signInBox.Controls.Add(label5);
            signInBox.Controls.Add(passwordTextbox);
            signInBox.Controls.Add(label4);
            signInBox.Controls.Add(emailTextbox);
            signInBox.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            signInBox.ForeColor = SystemColors.ControlLight;
            signInBox.Location = new Point(0, 0);
            signInBox.Name = "signInBox";
            signInBox.Size = new Size(612, 470);
            signInBox.TabIndex = 2;
            signInBox.TabStop = false;
            signInBox.Text = "  SIGN IN  ";
            // 
            // forgotPasswordLabel
            // 
            forgotPasswordLabel.AutoSize = true;
            forgotPasswordLabel.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            forgotPasswordLabel.Location = new Point(262, 421);
            forgotPasswordLabel.Name = "forgotPasswordLabel";
            forgotPasswordLabel.Size = new Size(125, 20);
            forgotPasswordLabel.TabIndex = 8;
            forgotPasswordLabel.Text = "Forgot Password?";
            forgotPasswordLabel.Click += forgotPasswordLabel_Click;
            // 
            // loginButton
            // 
            loginButton.BackColor = Color.FromArgb(1, 30, 64);
            loginButton.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            loginButton.ForeColor = SystemColors.ButtonHighlight;
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
            label5.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(46, 162);
            label5.Name = "label5";
            label5.Size = new Size(119, 25);
            label5.TabIndex = 3;
            label5.Text = "Password: ";
            // 
            // passwordTextbox
            // 
            passwordTextbox.Font = new Font("Segoe UI Light", 12F, FontStyle.Regular, GraphicsUnit.Point);
            passwordTextbox.Location = new Point(230, 162);
            passwordTextbox.Multiline = true;
            passwordTextbox.Name = "passwordTextbox";
            passwordTextbox.PasswordChar = '*';
            passwordTextbox.Size = new Size(342, 35);
            passwordTextbox.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(82, 86);
            label4.Name = "label4";
            label4.Size = new Size(72, 25);
            label4.TabIndex = 1;
            label4.Text = "Email:";
            // 
            // emailTextbox
            // 
            emailTextbox.Font = new Font("Segoe UI Light", 12F, FontStyle.Regular, GraphicsUnit.Point);
            emailTextbox.Location = new Point(230, 83);
            emailTextbox.Multiline = true;
            emailTextbox.Name = "emailTextbox";
            emailTextbox.Size = new Size(342, 35);
            emailTextbox.TabIndex = 0;
            // 
            // userLoginLabel
            // 
            userLoginLabel.AutoSize = true;
            userLoginLabel.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point);
            userLoginLabel.ForeColor = SystemColors.ButtonHighlight;
            userLoginLabel.Location = new Point(735, 68);
            userLoginLabel.Name = "userLoginLabel";
            userLoginLabel.Size = new Size(309, 36);
            userLoginLabel.TabIndex = 1;
            userLoginLabel.Text = "USER LOGIN FORM";
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
            panel2.Size = new Size(475, 710);
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
            label3.Location = new Point(130, 437);
            label3.Name = "label3";
            label3.Size = new Size(269, 87);
            label3.TabIndex = 3;
            label3.Text = "     EVERY BRAND\r\nQUALITY GUARANTY\r\n WONDERFUL PRICE";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 20F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ControlLight;
            label1.Location = new Point(51, 110);
            label1.Name = "label1";
            label1.Size = new Size(397, 39);
            label1.TabIndex = 1;
            label1.Text = "CAR RENTAL PALACE";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(105, 188);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(289, 203);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // passwordresetBox
            // 
            passwordresetBox.BackColor = Color.FromArgb(69, 19, 54);
            passwordresetBox.Controls.Add(signInBox);
            passwordresetBox.Controls.Add(signInLabel);
            passwordresetBox.Controls.Add(sendButton);
            passwordresetBox.Controls.Add(label9);
            passwordresetBox.Controls.Add(textBox2);
            passwordresetBox.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            passwordresetBox.ForeColor = SystemColors.ControlLight;
            passwordresetBox.Location = new Point(551, 151);
            passwordresetBox.Name = "passwordresetBox";
            passwordresetBox.Size = new Size(612, 470);
            passwordresetBox.TabIndex = 9;
            passwordresetBox.TabStop = false;
            passwordresetBox.Text = "FORGOT PASSWORD";
            // 
            // signInLabel
            // 
            signInLabel.AutoSize = true;
            signInLabel.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            signInLabel.Location = new Point(288, 419);
            signInLabel.Name = "signInLabel";
            signInLabel.Size = new Size(63, 20);
            signInLabel.TabIndex = 9;
            signInLabel.Text = "Sign-In?";
            signInLabel.Click += signInLabel_Click;
            // 
            // sendButton
            // 
            sendButton.BackColor = Color.FromArgb(1, 30, 64);
            sendButton.ForeColor = SystemColors.Control;
            sendButton.Location = new Point(207, 263);
            sendButton.Name = "sendButton";
            sendButton.Size = new Size(209, 49);
            sendButton.TabIndex = 7;
            sendButton.Text = "Send";
            sendButton.UseVisualStyleBackColor = false;
            sendButton.Click += sendButton_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(114, 148);
            label9.Name = "label9";
            label9.Size = new Size(69, 28);
            label9.TabIndex = 1;
            label9.Text = "Email:";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(262, 145);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(240, 35);
            textBox2.TabIndex = 0;
            // 
            // UserLoginPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1257, 710);
            Controls.Add(panel1);
            Name = "UserLoginPage";
            Text = "UserLoginPage";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            signInBox.ResumeLayout(false);
            signInBox.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)backButton).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            passwordresetBox.ResumeLayout(false);
            passwordresetBox.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private GroupBox signInBox;
        private Button loginButton;
        private CheckBox showPasswordCheck;
        private Label label5;
        private TextBox passwordTextbox;
        private Label label4;
        private TextBox emailTextbox;
        private Label userLoginLabel;
        private Panel panel2;
        private PictureBox backButton;
        private Label label3;
        private Label label1;
        private PictureBox pictureBox1;
        private GroupBox passwordresetBox;
        private Button sendButton;
        private Label label9;
        private TextBox textBox2;
        private Label forgotPasswordLabel;
        private Label signInLabel;
    }
}