namespace carRental
{
    partial class ManageUsersPage
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
            passwordTextBox = new TextBox();
            label2 = new Label();
            emailTextBox = new TextBox();
            userIDTextBox = new TextBox();
            label3 = new Label();
            deleteButton = new Button();
            updateButton = new Button();
            showButton = new Button();
            fullNameTextBox = new TextBox();
            label4 = new Label();
            addButton = new Button();
            userInfoGridview = new DataGridView();
            panel3 = new Panel();
            panel2 = new Panel();
            label8 = new Label();
            label1 = new Label();
            backButton = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)userInfoGridview).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)backButton).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(46, 97, 145);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(passwordTextBox);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(emailTextBox);
            panel1.Controls.Add(userIDTextBox);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(deleteButton);
            panel1.Controls.Add(updateButton);
            panel1.Controls.Add(showButton);
            panel1.Controls.Add(fullNameTextBox);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(addButton);
            panel1.Controls.Add(userInfoGridview);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(4, 4, 4, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1645, 936);
            panel1.TabIndex = 4;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(89, 530);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(116, 32);
            label5.TabIndex = 48;
            label5.Text = "Password:";
            // 
            // passwordTextBox
            // 
            passwordTextBox.Anchor = AnchorStyles.None;
            passwordTextBox.Location = new Point(240, 530);
            passwordTextBox.Margin = new Padding(4, 4, 4, 4);
            passwordTextBox.Multiline = true;
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.Size = new Size(293, 36);
            passwordTextBox.TabIndex = 47;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(131, 451);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(76, 32);
            label2.TabIndex = 46;
            label2.Text = "Email:";
            // 
            // emailTextBox
            // 
            emailTextBox.Anchor = AnchorStyles.None;
            emailTextBox.Location = new Point(240, 456);
            emailTextBox.Margin = new Padding(4, 4, 4, 4);
            emailTextBox.Multiline = true;
            emailTextBox.Name = "emailTextBox";
            emailTextBox.Size = new Size(293, 36);
            emailTextBox.TabIndex = 45;
            // 
            // userIDTextBox
            // 
            userIDTextBox.Anchor = AnchorStyles.None;
            userIDTextBox.Location = new Point(240, 304);
            userIDTextBox.Margin = new Padding(4, 4, 4, 4);
            userIDTextBox.Multiline = true;
            userIDTextBox.Name = "userIDTextBox";
            userIDTextBox.Size = new Size(293, 36);
            userIDTextBox.TabIndex = 44;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(111, 304);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(96, 32);
            label3.TabIndex = 43;
            label3.Text = "User ID:";
            // 
            // deleteButton
            // 
            deleteButton.Anchor = AnchorStyles.None;
            deleteButton.BackColor = Color.FromArgb(1, 30, 64);
            deleteButton.Font = new Font("Roboto Condensed", 11F, FontStyle.Bold, GraphicsUnit.Point);
            deleteButton.ForeColor = SystemColors.ButtonHighlight;
            deleteButton.Location = new Point(371, 784);
            deleteButton.Margin = new Padding(4, 4, 4, 4);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(162, 52);
            deleteButton.TabIndex = 34;
            deleteButton.Text = "DELETE";
            deleteButton.UseVisualStyleBackColor = false;
            deleteButton.Click += deleteButton_Click;
            // 
            // updateButton
            // 
            updateButton.Anchor = AnchorStyles.None;
            updateButton.BackColor = Color.FromArgb(1, 30, 64);
            updateButton.Font = new Font("Roboto Condensed", 11F, FontStyle.Bold, GraphicsUnit.Point);
            updateButton.ForeColor = SystemColors.ButtonHighlight;
            updateButton.Location = new Point(80, 784);
            updateButton.Margin = new Padding(4, 4, 4, 4);
            updateButton.Name = "updateButton";
            updateButton.Size = new Size(162, 52);
            updateButton.TabIndex = 33;
            updateButton.Text = "UPDATE";
            updateButton.UseVisualStyleBackColor = false;
            updateButton.Click += updateButton_Click;
            // 
            // showButton
            // 
            showButton.Anchor = AnchorStyles.None;
            showButton.BackColor = Color.FromArgb(1, 30, 64);
            showButton.Font = new Font("Roboto Condensed", 11F, FontStyle.Bold, GraphicsUnit.Point);
            showButton.ForeColor = SystemColors.ButtonHighlight;
            showButton.Location = new Point(371, 678);
            showButton.Margin = new Padding(4, 4, 4, 4);
            showButton.Name = "showButton";
            showButton.Size = new Size(162, 52);
            showButton.TabIndex = 32;
            showButton.Text = "SHOW";
            showButton.UseVisualStyleBackColor = false;
            showButton.Click += showButton_Click;
            // 
            // fullNameTextBox
            // 
            fullNameTextBox.Anchor = AnchorStyles.None;
            fullNameTextBox.Location = new Point(240, 380);
            fullNameTextBox.Margin = new Padding(4, 4, 4, 4);
            fullNameTextBox.Multiline = true;
            fullNameTextBox.Name = "fullNameTextBox";
            fullNameTextBox.Size = new Size(293, 36);
            fullNameTextBox.TabIndex = 28;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(80, 380);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(128, 32);
            label4.TabIndex = 27;
            label4.Text = "Full Name:";
            // 
            // addButton
            // 
            addButton.Anchor = AnchorStyles.None;
            addButton.BackColor = Color.FromArgb(1, 30, 64);
            addButton.Font = new Font("Roboto Condensed", 11F, FontStyle.Bold, GraphicsUnit.Point);
            addButton.ForeColor = SystemColors.ButtonHighlight;
            addButton.Location = new Point(80, 678);
            addButton.Margin = new Padding(4, 4, 4, 4);
            addButton.Name = "addButton";
            addButton.Size = new Size(162, 52);
            addButton.TabIndex = 20;
            addButton.Text = "ADD";
            addButton.UseVisualStyleBackColor = false;
            addButton.Click += addButton_Click;
            // 
            // userInfoGridview
            // 
            userInfoGridview.Anchor = AnchorStyles.None;
            userInfoGridview.BackgroundColor = SystemColors.ButtonHighlight;
            userInfoGridview.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            userInfoGridview.Location = new Point(569, 229);
            userInfoGridview.Margin = new Padding(4, 4, 4, 4);
            userInfoGridview.Name = "userInfoGridview";
            userInfoGridview.RowHeadersWidth = 51;
            userInfoGridview.RowTemplate.Height = 29;
            userInfoGridview.Size = new Size(1072, 610);
            userInfoGridview.TabIndex = 9;
            userInfoGridview.CellClick += userInfoGridview_CellClick;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(69, 19, 54);
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(0, 888);
            panel3.Margin = new Padding(4, 4, 4, 4);
            panel3.Name = "panel3";
            panel3.Size = new Size(1645, 48);
            panel3.TabIndex = 8;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(69, 19, 54);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(backButton);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(4, 4, 4, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(1645, 143);
            panel2.TabIndex = 7;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Top;
            label8.AutoSize = true;
            label8.Font = new Font("Roboto Condensed", 20F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = SystemColors.ControlLight;
            label8.Location = new Point(578, 24);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(461, 48);
            label8.TabIndex = 22;
            label8.Text = "THE CAR RENTAL SYSTAM ";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Roboto Condensed", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ControlLight;
            label1.Location = new Point(726, 87);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(199, 34);
            label1.TabIndex = 21;
            label1.Text = "MANAGE USERS";
            // 
            // backButton
            // 
            backButton.Image = Properties.Resources.backarrow;
            backButton.Location = new Point(4, 11);
            backButton.Margin = new Padding(4, 4, 4, 4);
            backButton.Name = "backButton";
            backButton.Size = new Size(44, 40);
            backButton.SizeMode = PictureBoxSizeMode.StretchImage;
            backButton.TabIndex = 14;
            backButton.TabStop = false;
            backButton.Click += backButton_Click;
            // 
            // ManageUsersPage
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1645, 936);
            Controls.Add(panel1);
            Margin = new Padding(4, 4, 4, 4);
            Name = "ManageUsersPage";
            Text = "ManageUsersPage";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)userInfoGridview).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)backButton).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button deleteButton;
        private Button updateButton;
        private Button showButton;
        private TextBox fullNameTextBox;
        private Label label4;
        private Button addButton;
        private DataGridView userInfoGridview;
        private Panel panel3;
        private Panel panel2;
        private PictureBox backButton;
        private Label label2;
        private TextBox emailTextBox;
        private TextBox userIDTextBox;
        private Label label3;
        private Label label5;
        private TextBox passwordTextBox;
        private Label label8;
        private Label label1;
    }
}