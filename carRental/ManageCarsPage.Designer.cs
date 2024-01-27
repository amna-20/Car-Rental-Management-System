namespace carRental
{
    partial class ManageCarsPage
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
            availableTextBox = new TextBox();
            carIDTextBox = new TextBox();
            label10 = new Label();
            label9 = new Label();
            fuelTypeTextBox = new TextBox();
            label7 = new Label();
            carTypeTextBox = new TextBox();
            deleteButton = new Button();
            updateButton = new Button();
            showButton = new Button();
            label6 = new Label();
            pricePerDayTextBox = new TextBox();
            label5 = new Label();
            modelTextBox = new TextBox();
            label4 = new Label();
            brandTextBox = new TextBox();
            label3 = new Label();
            regNumTextBox = new TextBox();
            addButton = new Button();
            label2 = new Label();
            dataGridView1 = new DataGridView();
            panel3 = new Panel();
            panel2 = new Panel();
            backButton = new PictureBox();
            label8 = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)backButton).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(46, 97, 145);
            panel1.Controls.Add(availableTextBox);
            panel1.Controls.Add(carIDTextBox);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(fuelTypeTextBox);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(carTypeTextBox);
            panel1.Controls.Add(deleteButton);
            panel1.Controls.Add(updateButton);
            panel1.Controls.Add(showButton);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(pricePerDayTextBox);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(modelTextBox);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(brandTextBox);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(regNumTextBox);
            panel1.Controls.Add(addButton);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(dataGridView1);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(4, 4, 4, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1645, 936);
            panel1.TabIndex = 1;
            // 
            // availableTextBox
            // 
            availableTextBox.Anchor = AnchorStyles.None;
            availableTextBox.Location = new Point(198, 675);
            availableTextBox.Margin = new Padding(4, 4, 4, 4);
            availableTextBox.Multiline = true;
            availableTextBox.Name = "availableTextBox";
            availableTextBox.Size = new Size(293, 36);
            availableTextBox.TabIndex = 43;
            // 
            // carIDTextBox
            // 
            carIDTextBox.Anchor = AnchorStyles.None;
            carIDTextBox.Location = new Point(198, 202);
            carIDTextBox.Margin = new Padding(4, 4, 4, 4);
            carIDTextBox.Multiline = true;
            carIDTextBox.Name = "carIDTextBox";
            carIDTextBox.Size = new Size(293, 36);
            carIDTextBox.TabIndex = 42;
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.None;
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(74, 202);
            label10.Margin = new Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.Size = new Size(98, 32);
            label10.TabIndex = 41;
            label10.Text = "Car Id: *";
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.None;
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(35, 609);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(139, 32);
            label9.TabIndex = 40;
            label9.Text = "Fuel Type: *";
            // 
            // fuelTypeTextBox
            // 
            fuelTypeTextBox.Anchor = AnchorStyles.None;
            fuelTypeTextBox.Location = new Point(198, 609);
            fuelTypeTextBox.Margin = new Padding(4, 4, 4, 4);
            fuelTypeTextBox.Multiline = true;
            fuelTypeTextBox.Name = "fuelTypeTextBox";
            fuelTypeTextBox.Size = new Size(293, 36);
            fuelTypeTextBox.TabIndex = 39;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.None;
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(44, 541);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(129, 32);
            label7.TabIndex = 38;
            label7.Text = "Car Type: *";
            // 
            // carTypeTextBox
            // 
            carTypeTextBox.Anchor = AnchorStyles.None;
            carTypeTextBox.Location = new Point(198, 541);
            carTypeTextBox.Margin = new Padding(4, 4, 4, 4);
            carTypeTextBox.Multiline = true;
            carTypeTextBox.Name = "carTypeTextBox";
            carTypeTextBox.Size = new Size(293, 36);
            carTypeTextBox.TabIndex = 35;
            // 
            // deleteButton
            // 
            deleteButton.Anchor = AnchorStyles.None;
            deleteButton.BackColor = Color.FromArgb(1, 30, 64);
            deleteButton.Font = new Font("Roboto Condensed", 11F, FontStyle.Bold, GraphicsUnit.Point);
            deleteButton.ForeColor = SystemColors.ButtonHighlight;
            deleteButton.Location = new Point(329, 806);
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
            updateButton.Location = new Point(38, 806);
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
            showButton.Location = new Point(329, 728);
            showButton.Margin = new Padding(4, 4, 4, 4);
            showButton.Name = "showButton";
            showButton.Size = new Size(162, 52);
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
            label6.Location = new Point(38, 670);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(132, 32);
            label6.TabIndex = 31;
            label6.Text = "Available: *";
            // 
            // pricePerDayTextBox
            // 
            pricePerDayTextBox.Anchor = AnchorStyles.None;
            pricePerDayTextBox.Location = new Point(198, 472);
            pricePerDayTextBox.Margin = new Padding(4, 4, 4, 4);
            pricePerDayTextBox.Multiline = true;
            pricePerDayTextBox.Name = "pricePerDayTextBox";
            pricePerDayTextBox.Size = new Size(293, 36);
            pricePerDayTextBox.TabIndex = 30;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(85, 472);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(87, 32);
            label5.TabIndex = 29;
            label5.Text = "Price: *";
            // 
            // modelTextBox
            // 
            modelTextBox.Anchor = AnchorStyles.None;
            modelTextBox.Location = new Point(198, 404);
            modelTextBox.Margin = new Padding(4, 4, 4, 4);
            modelTextBox.Multiline = true;
            modelTextBox.Name = "modelTextBox";
            modelTextBox.Size = new Size(293, 36);
            modelTextBox.TabIndex = 28;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(66, 404);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(105, 32);
            label4.TabIndex = 27;
            label4.Text = "Model: *";
            // 
            // brandTextBox
            // 
            brandTextBox.Anchor = AnchorStyles.None;
            brandTextBox.Location = new Point(198, 335);
            brandTextBox.Margin = new Padding(4, 4, 4, 4);
            brandTextBox.Multiline = true;
            brandTextBox.Name = "brandTextBox";
            brandTextBox.Size = new Size(293, 36);
            brandTextBox.TabIndex = 26;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(74, 335);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(98, 32);
            label3.TabIndex = 25;
            label3.Text = "Brand: *";
            // 
            // regNumTextBox
            // 
            regNumTextBox.Anchor = AnchorStyles.None;
            regNumTextBox.Location = new Point(198, 265);
            regNumTextBox.Margin = new Padding(4, 4, 4, 4);
            regNumTextBox.Multiline = true;
            regNumTextBox.Name = "regNumTextBox";
            regNumTextBox.Size = new Size(293, 36);
            regNumTextBox.TabIndex = 24;
            // 
            // addButton
            // 
            addButton.Anchor = AnchorStyles.None;
            addButton.BackColor = Color.FromArgb(1, 30, 64);
            addButton.Font = new Font("Roboto Condensed", 11F, FontStyle.Bold, GraphicsUnit.Point);
            addButton.ForeColor = SystemColors.ButtonHighlight;
            addButton.Location = new Point(38, 728);
            addButton.Margin = new Padding(4, 4, 4, 4);
            addButton.Name = "addButton";
            addButton.Size = new Size(162, 52);
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
            label2.Location = new Point(60, 265);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(111, 32);
            label2.TabIndex = 13;
            label2.Text = "CarReg: *";
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.None;
            dataGridView1.BackgroundColor = SystemColors.ControlLight;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(512, 202);
            dataGridView1.Margin = new Padding(4, 4, 4, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(1118, 610);
            dataGridView1.TabIndex = 9;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(1, 30, 64);
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
            panel2.Controls.Add(backButton);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(4, 4, 4, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(1645, 143);
            panel2.TabIndex = 7;
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
            // label8
            // 
            label8.Anchor = AnchorStyles.Top;
            label8.AutoSize = true;
            label8.Font = new Font("Roboto Condensed", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = SystemColors.ControlLight;
            label8.Location = new Point(622, 26);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(337, 43);
            label8.TabIndex = 13;
            label8.Text = "CAR RENTAL SYSTEM";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Roboto Condensed", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ControlLight;
            label1.Location = new Point(725, 81);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(160, 34);
            label1.TabIndex = 12;
            label1.Text = "Manage Cars";
            // 
            // ManageCarsPage
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1645, 936);
            Controls.Add(panel1);
            Margin = new Padding(4, 4, 4, 4);
            Name = "ManageCarsPage";
            Text = "ManageCarsPage";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)backButton).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel3;
        private Panel panel2;
        private DataGridView dataGridView1;
        private Button addButton;
        private Label label2;
        private Label label1;
        private Label label8;
        private PictureBox backButton;
        private TextBox regNumTextBox;
        private Label label6;
        private TextBox pricePerDayTextBox;
        private Label label5;
        private TextBox modelTextBox;
        private Label label4;
        private TextBox brandTextBox;
        private Label label3;
        private Button deleteButton;
        private Button updateButton;
        private Button showButton;
        private TextBox carTypeTextBox;
        private Label label9;
        private TextBox fuelTypeTextBox;
        private Label label7;
        private TextBox carIDTextBox;
        private Label label10;
        private TextBox availableTextBox;
    }
}