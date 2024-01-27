namespace carRental
{
    partial class ManageCustomersPage
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
            customersviewPanel = new Panel();
            dataGridView2 = new DataGridView();
            buttonShow = new Button();
            customerIDTextBox = new TextBox();
            label7 = new Label();
            drivLicenseTextBox = new TextBox();
            deleteButton = new Button();
            updateButton = new Button();
            showButton = new Button();
            label6 = new Label();
            cnicTextBox = new TextBox();
            label5 = new Label();
            mobNumTextBox = new TextBox();
            label4 = new Label();
            addressTextBox = new TextBox();
            label3 = new Label();
            fullNameTextBox = new TextBox();
            addButton = new Button();
            label2 = new Label();
            dataGridView1 = new DataGridView();
            panel3 = new Panel();
            panel4 = new Panel();
            label9 = new Label();
            panel2 = new Panel();
            label8 = new Label();
            backButtonadmin = new PictureBox();
            label1 = new Label();
            backButtonuser = new PictureBox();
            panel1.SuspendLayout();
            customersviewPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)backButtonadmin).BeginInit();
            ((System.ComponentModel.ISupportInitialize)backButtonuser).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(46, 97, 145);
            panel1.Controls.Add(customersviewPanel);
            panel1.Controls.Add(customerIDTextBox);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(drivLicenseTextBox);
            panel1.Controls.Add(deleteButton);
            panel1.Controls.Add(updateButton);
            panel1.Controls.Add(showButton);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(cnicTextBox);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(mobNumTextBox);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(addressTextBox);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(fullNameTextBox);
            panel1.Controls.Add(addButton);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(dataGridView1);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1316, 749);
            panel1.TabIndex = 2;
            // 
            // customersviewPanel
            // 
            customersviewPanel.Anchor = AnchorStyles.None;
            customersviewPanel.Controls.Add(dataGridView2);
            customersviewPanel.Controls.Add(buttonShow);
            customersviewPanel.Location = new Point(3, 120);
            customersviewPanel.Name = "customersviewPanel";
            customersviewPanel.Size = new Size(1316, 591);
            customersviewPanel.TabIndex = 38;
            // 
            // dataGridView2
            // 
            dataGridView2.AllowUserToResizeColumns = false;
            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView2.BackgroundColor = SystemColors.ControlLight;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(27, 30);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.RowTemplate.Height = 29;
            dataGridView2.Size = new Size(1259, 466);
            dataGridView2.TabIndex = 34;
            // 
            // buttonShow
            // 
            buttonShow.Anchor = AnchorStyles.None;
            buttonShow.BackColor = Color.FromArgb(1, 30, 64);
            buttonShow.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Bold, GraphicsUnit.Point);
            buttonShow.ForeColor = SystemColors.ButtonHighlight;
            buttonShow.Location = new Point(1156, 520);
            buttonShow.Name = "buttonShow";
            buttonShow.Size = new Size(130, 42);
            buttonShow.TabIndex = 33;
            buttonShow.Text = "SHOW";
            buttonShow.UseVisualStyleBackColor = false;
            buttonShow.Click += buttonShow_Click;
            // 
            // customerIDTextBox
            // 
            customerIDTextBox.Anchor = AnchorStyles.None;
            customerIDTextBox.Location = new Point(173, 197);
            customerIDTextBox.Multiline = true;
            customerIDTextBox.Name = "customerIDTextBox";
            customerIDTextBox.Size = new Size(235, 30);
            customerIDTextBox.TabIndex = 37;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.None;
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(23, 197);
            label7.Name = "label7";
            label7.Size = new Size(137, 28);
            label7.TabIndex = 36;
            label7.Text = "Customer ID: *";
            // 
            // drivLicenseTextBox
            // 
            drivLicenseTextBox.Anchor = AnchorStyles.None;
            drivLicenseTextBox.Location = new Point(173, 476);
            drivLicenseTextBox.Multiline = true;
            drivLicenseTextBox.Name = "drivLicenseTextBox";
            drivLicenseTextBox.Size = new Size(235, 30);
            drivLicenseTextBox.TabIndex = 35;
            // 
            // deleteButton
            // 
            deleteButton.Anchor = AnchorStyles.None;
            deleteButton.BackColor = Color.FromArgb(1, 30, 64);
            deleteButton.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Bold, GraphicsUnit.Point);
            deleteButton.ForeColor = SystemColors.ButtonHighlight;
            deleteButton.Location = new Point(263, 640);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(130, 42);
            deleteButton.TabIndex = 34;
            deleteButton.Text = "DELETE";
            deleteButton.UseVisualStyleBackColor = false;
            deleteButton.Click += deleteButton_Click;
            // 
            // updateButton
            // 
            updateButton.Anchor = AnchorStyles.None;
            updateButton.BackColor = Color.FromArgb(1, 30, 64);
            updateButton.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Bold, GraphicsUnit.Point);
            updateButton.ForeColor = SystemColors.ButtonHighlight;
            updateButton.Location = new Point(30, 640);
            updateButton.Name = "updateButton";
            updateButton.Size = new Size(130, 42);
            updateButton.TabIndex = 33;
            updateButton.Text = "UPDATE";
            updateButton.UseVisualStyleBackColor = false;
            updateButton.Click += updateButton_Click;
            // 
            // showButton
            // 
            showButton.Anchor = AnchorStyles.None;
            showButton.BackColor = Color.FromArgb(1, 30, 64);
            showButton.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Bold, GraphicsUnit.Point);
            showButton.ForeColor = SystemColors.ButtonHighlight;
            showButton.Location = new Point(263, 555);
            showButton.Name = "showButton";
            showButton.Size = new Size(130, 42);
            showButton.TabIndex = 32;
            showButton.Text = "SHOW";
            showButton.UseVisualStyleBackColor = false;
            showButton.Click += showButton_Click;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.None;
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(3, 472);
            label6.Name = "label6";
            label6.Size = new Size(160, 28);
            label6.TabIndex = 31;
            label6.Text = "Driving License: *";
            // 
            // cnicTextBox
            // 
            cnicTextBox.Anchor = AnchorStyles.None;
            cnicTextBox.Location = new Point(173, 421);
            cnicTextBox.Multiline = true;
            cnicTextBox.Name = "cnicTextBox";
            cnicTextBox.Size = new Size(235, 30);
            cnicTextBox.TabIndex = 30;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(87, 417);
            label5.Name = "label5";
            label5.Size = new Size(73, 28);
            label5.TabIndex = 29;
            label5.Text = "CNIC: *";
            // 
            // mobNumTextBox
            // 
            mobNumTextBox.Anchor = AnchorStyles.None;
            mobNumTextBox.Location = new Point(173, 366);
            mobNumTextBox.Multiline = true;
            mobNumTextBox.Name = "mobNumTextBox";
            mobNumTextBox.Size = new Size(235, 30);
            mobNumTextBox.TabIndex = 28;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(21, 362);
            label4.Name = "label4";
            label4.Size = new Size(139, 28);
            label4.TabIndex = 27;
            label4.Text = "Mobile Num: *";
            // 
            // addressTextBox
            // 
            addressTextBox.Anchor = AnchorStyles.None;
            addressTextBox.Location = new Point(173, 311);
            addressTextBox.Multiline = true;
            addressTextBox.Name = "addressTextBox";
            addressTextBox.Size = new Size(235, 30);
            addressTextBox.TabIndex = 26;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(61, 311);
            label3.Name = "label3";
            label3.Size = new Size(91, 28);
            label3.TabIndex = 25;
            label3.Text = "Address: ";
            // 
            // fullNameTextBox
            // 
            fullNameTextBox.Anchor = AnchorStyles.None;
            fullNameTextBox.Location = new Point(173, 255);
            fullNameTextBox.Multiline = true;
            fullNameTextBox.Name = "fullNameTextBox";
            fullNameTextBox.Size = new Size(235, 30);
            fullNameTextBox.TabIndex = 24;
            // 
            // addButton
            // 
            addButton.Anchor = AnchorStyles.None;
            addButton.BackColor = Color.FromArgb(1, 30, 64);
            addButton.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Bold, GraphicsUnit.Point);
            addButton.ForeColor = SystemColors.ButtonHighlight;
            addButton.Location = new Point(30, 555);
            addButton.Name = "addButton";
            addButton.Size = new Size(130, 42);
            addButton.TabIndex = 20;
            addButton.Text = "ADD";
            addButton.UseVisualStyleBackColor = false;
            addButton.Click += addButton_Click;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(43, 255);
            label2.Name = "label2";
            label2.Size = new Size(117, 28);
            label2.TabIndex = 13;
            label2.Text = "Full Name: *";
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.None;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(446, 197);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(837, 488);
            dataGridView1.TabIndex = 9;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(1, 30, 64);
            panel3.Controls.Add(panel4);
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(0, 711);
            panel3.Name = "panel3";
            panel3.Size = new Size(1316, 38);
            panel3.TabIndex = 8;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(1, 30, 64);
            panel4.Controls.Add(label9);
            panel4.Dock = DockStyle.Bottom;
            panel4.Location = new Point(0, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(1316, 38);
            panel4.TabIndex = 18;
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Top;
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Light", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label9.ForeColor = SystemColors.ControlLight;
            label9.Location = new Point(1717, 3);
            label9.Name = "label9";
            label9.Size = new Size(127, 28);
            label9.TabIndex = 17;
            label9.Text = "Next Page >>";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(69, 19, 54);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(backButtonadmin);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(backButtonuser);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1316, 114);
            panel2.TabIndex = 7;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Top;
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft Sans Serif", 20F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = SystemColors.ControlLight;
            label8.Location = new Point(484, 25);
            label8.Name = "label8";
            label8.Size = new Size(493, 39);
            label8.TabIndex = 16;
            label8.Text = "THE CAR RENTAL SYSTAM ";
            // 
            // backButtonadmin
            // 
            backButtonadmin.Image = Properties.Resources.backarrow;
            backButtonadmin.Location = new Point(3, 3);
            backButtonadmin.Name = "backButtonadmin";
            backButtonadmin.Size = new Size(35, 32);
            backButtonadmin.SizeMode = PictureBoxSizeMode.StretchImage;
            backButtonadmin.TabIndex = 14;
            backButtonadmin.TabStop = false;
            backButtonadmin.Click += backButton_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ControlLight;
            label1.Location = new Point(570, 72);
            label1.Name = "label1";
            label1.Size = new Size(291, 29);
            label1.TabIndex = 12;
            label1.Text = "MANAGE CUSTOMERS";
            // 
            // backButtonuser
            // 
            backButtonuser.Image = Properties.Resources.backarrow;
            backButtonuser.Location = new Point(3, 3);
            backButtonuser.Name = "backButtonuser";
            backButtonuser.Size = new Size(35, 32);
            backButtonuser.SizeMode = PictureBoxSizeMode.StretchImage;
            backButtonuser.TabIndex = 17;
            backButtonuser.TabStop = false;
            backButtonuser.Click += backButtonuser_Click;
            // 
            // ManageCustomersPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1316, 749);
            Controls.Add(panel1);
            Name = "ManageCustomersPage";
            Text = "ManageCustomersPage";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            customersviewPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel3.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)backButtonadmin).EndInit();
            ((System.ComponentModel.ISupportInitialize)backButtonuser).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button deleteButton;
        private Button updateButton;
        private Button showButton;
        private Label label6;
        private TextBox cnicTextBox;
        private Label label5;
        private TextBox mobNumTextBox;
        private Label label4;
        private TextBox addressTextBox;
        private Label label3;
        private TextBox fullNameTextBox;
        private Button addButton;
        private Label label2;
        private DataGridView dataGridView1;
        private Panel panel3;
        private Panel panel2;
        private PictureBox backButtonadmin;
        private Label label1;
        private TextBox drivLicenseTextBox;
        private TextBox customerIDTextBox;
        private Label label7;
        private Label label8;
        private Panel customersviewPanel;
        private DataGridView dataGridView2;
        private Button buttonShow;
        private PictureBox backButtonuser;
        private Panel panel4;
        private Label label9;
    }
}