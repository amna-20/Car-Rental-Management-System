namespace carRental
{
    partial class ManageRentalCarsPage
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
            rentalviewPanel = new Panel();
            rentshow = new Button();
            dataGridView2 = new DataGridView();
            buttonShow = new Button();
            generateBill = new Button();
            label12 = new Label();
            label11 = new Label();
            label10 = new Label();
            carIDTextBox = new TextBox();
            rentCarsGrid = new DataGridView();
            endDatePicker = new DateTimePicker();
            startDatePicker = new DateTimePicker();
            label7 = new Label();
            fuelTypeComboBox = new ComboBox();
            carTypeComboBox = new ComboBox();
            customerIDTextBox = new TextBox();
            deleteButton = new Button();
            showButton = new Button();
            label6 = new Label();
            label5 = new Label();
            rentIDTextBox = new TextBox();
            label4 = new Label();
            label3 = new Label();
            addButton = new Button();
            label2 = new Label();
            carsInfoGrid = new DataGridView();
            panel3 = new Panel();
            panel4 = new Panel();
            panel2 = new Panel();
            label8 = new Label();
            label1 = new Label();
            backButtonadmin = new PictureBox();
            backButtonuser = new PictureBox();
            panel1.SuspendLayout();
            rentalviewPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)rentCarsGrid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)carsInfoGrid).BeginInit();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)backButtonadmin).BeginInit();
            ((System.ComponentModel.ISupportInitialize)backButtonuser).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(46, 97, 145);
            panel1.Controls.Add(rentalviewPanel);
            panel1.Controls.Add(generateBill);
            panel1.Controls.Add(label12);
            panel1.Controls.Add(label11);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(carIDTextBox);
            panel1.Controls.Add(rentCarsGrid);
            panel1.Controls.Add(endDatePicker);
            panel1.Controls.Add(startDatePicker);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(fuelTypeComboBox);
            panel1.Controls.Add(carTypeComboBox);
            panel1.Controls.Add(customerIDTextBox);
            panel1.Controls.Add(deleteButton);
            panel1.Controls.Add(showButton);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(rentIDTextBox);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(addButton);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(carsInfoGrid);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1316, 749);
            panel1.TabIndex = 3;
            // 
            // rentalviewPanel
            // 
            rentalviewPanel.Anchor = AnchorStyles.None;
            rentalviewPanel.Controls.Add(rentshow);
            rentalviewPanel.Controls.Add(dataGridView2);
            rentalviewPanel.Controls.Add(buttonShow);
            rentalviewPanel.Location = new Point(3, 120);
            rentalviewPanel.Name = "rentalviewPanel";
            rentalviewPanel.Size = new Size(1316, 591);
            rentalviewPanel.TabIndex = 52;
            // 
            // rentshow
            // 
            rentshow.Anchor = AnchorStyles.None;
            rentshow.BackColor = Color.FromArgb(1, 30, 64);
            rentshow.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Bold, GraphicsUnit.Point);
            rentshow.ForeColor = SystemColors.ButtonHighlight;
            rentshow.Location = new Point(1153, 522);
            rentshow.Name = "rentshow";
            rentshow.Size = new Size(130, 42);
            rentshow.TabIndex = 35;
            rentshow.Text = "SHOW";
            rentshow.UseVisualStyleBackColor = false;
            rentshow.Click += rentshow_Click;
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
            buttonShow.Location = new Point(1714, 765);
            buttonShow.Name = "buttonShow";
            buttonShow.Size = new Size(130, 42);
            buttonShow.TabIndex = 33;
            buttonShow.Text = "SHOW";
            buttonShow.UseVisualStyleBackColor = false;
            // 
            // generateBill
            // 
            generateBill.Anchor = AnchorStyles.None;
            generateBill.BackColor = Color.FromArgb(1, 30, 64);
            generateBill.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Bold, GraphicsUnit.Point);
            generateBill.ForeColor = SystemColors.ButtonHighlight;
            generateBill.Location = new Point(274, 656);
            generateBill.Name = "generateBill";
            generateBill.Size = new Size(147, 42);
            generateBill.TabIndex = 51;
            generateBill.Text = "GENERATE BILL";
            generateBill.UseVisualStyleBackColor = false;
            generateBill.Click += generateBill_Click;
            // 
            // label12
            // 
            label12.Anchor = AnchorStyles.None;
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label12.ForeColor = SystemColors.ControlText;
            label12.Location = new Point(862, 416);
            label12.Name = "label12";
            label12.Size = new Size(122, 32);
            label12.TabIndex = 50;
            label12.Text = "Rent Cars";
            // 
            // label11
            // 
            label11.Anchor = AnchorStyles.None;
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label11.ForeColor = SystemColors.ControlText;
            label11.Location = new Point(818, 132);
            label11.Name = "label11";
            label11.Size = new Size(208, 32);
            label11.TabIndex = 49;
            label11.Text = "Cars Information";
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.None;
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(75, 367);
            label10.Name = "label10";
            label10.Size = new Size(82, 28);
            label10.TabIndex = 48;
            label10.Text = "Car ID: *";
            // 
            // carIDTextBox
            // 
            carIDTextBox.Anchor = AnchorStyles.None;
            carIDTextBox.Location = new Point(186, 371);
            carIDTextBox.Multiline = true;
            carIDTextBox.Name = "carIDTextBox";
            carIDTextBox.Size = new Size(235, 30);
            carIDTextBox.TabIndex = 47;
            // 
            // rentCarsGrid
            // 
            rentCarsGrid.Anchor = AnchorStyles.None;
            rentCarsGrid.BackgroundColor = SystemColors.ButtonHighlight;
            rentCarsGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            rentCarsGrid.Location = new Point(458, 458);
            rentCarsGrid.Name = "rentCarsGrid";
            rentCarsGrid.RowHeadersWidth = 51;
            rentCarsGrid.RowTemplate.Height = 29;
            rentCarsGrid.Size = new Size(858, 240);
            rentCarsGrid.TabIndex = 46;
            rentCarsGrid.CellClick += rentCarsGrid_CellClick;
            // 
            // endDatePicker
            // 
            endDatePicker.Anchor = AnchorStyles.None;
            endDatePicker.Location = new Point(158, 528);
            endDatePicker.Name = "endDatePicker";
            endDatePicker.Size = new Size(263, 27);
            endDatePicker.TabIndex = 43;
            // 
            // startDatePicker
            // 
            startDatePicker.Anchor = AnchorStyles.None;
            startDatePicker.Location = new Point(158, 478);
            startDatePicker.Name = "startDatePicker";
            startDatePicker.Size = new Size(263, 27);
            startDatePicker.TabIndex = 42;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.None;
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(25, 314);
            label7.Name = "label7";
            label7.Size = new Size(132, 28);
            label7.TabIndex = 41;
            label7.Text = "CustomerID: *";
            // 
            // fuelTypeComboBox
            // 
            fuelTypeComboBox.Anchor = AnchorStyles.None;
            fuelTypeComboBox.FormattingEnabled = true;
            fuelTypeComboBox.Items.AddRange(new object[] { "Petrol", "Diesel", "Hybrid", "Electric" });
            fuelTypeComboBox.Location = new Point(186, 214);
            fuelTypeComboBox.Name = "fuelTypeComboBox";
            fuelTypeComboBox.Size = new Size(235, 28);
            fuelTypeComboBox.TabIndex = 38;
            // 
            // carTypeComboBox
            // 
            carTypeComboBox.Anchor = AnchorStyles.None;
            carTypeComboBox.FormattingEnabled = true;
            carTypeComboBox.Items.AddRange(new object[] { "Family", "City", "Sports" });
            carTypeComboBox.Location = new Point(186, 162);
            carTypeComboBox.Name = "carTypeComboBox";
            carTypeComboBox.Size = new Size(235, 28);
            carTypeComboBox.TabIndex = 37;
            // 
            // customerIDTextBox
            // 
            customerIDTextBox.Anchor = AnchorStyles.None;
            customerIDTextBox.Location = new Point(186, 318);
            customerIDTextBox.Multiline = true;
            customerIDTextBox.Name = "customerIDTextBox";
            customerIDTextBox.Size = new Size(235, 30);
            customerIDTextBox.TabIndex = 36;
            // 
            // deleteButton
            // 
            deleteButton.Anchor = AnchorStyles.None;
            deleteButton.BackColor = Color.FromArgb(1, 30, 64);
            deleteButton.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Bold, GraphicsUnit.Point);
            deleteButton.ForeColor = SystemColors.ButtonHighlight;
            deleteButton.Location = new Point(41, 656);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(145, 42);
            deleteButton.TabIndex = 34;
            deleteButton.Text = "DELETE";
            deleteButton.UseVisualStyleBackColor = false;
            deleteButton.Click += deleteButton_Click;
            // 
            // showButton
            // 
            showButton.Anchor = AnchorStyles.None;
            showButton.BackColor = Color.FromArgb(1, 30, 64);
            showButton.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Bold, GraphicsUnit.Point);
            showButton.ForeColor = SystemColors.ButtonHighlight;
            showButton.Location = new Point(274, 594);
            showButton.Name = "showButton";
            showButton.Size = new Size(146, 42);
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
            label6.Location = new Point(32, 526);
            label6.Name = "label6";
            label6.Size = new Size(113, 28);
            label6.TabIndex = 31;
            label6.Text = "Return date";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(32, 471);
            label5.Name = "label5";
            label5.Size = new Size(112, 28);
            label5.TabIndex = 29;
            label5.Text = "Rental Date";
            // 
            // rentIDTextBox
            // 
            rentIDTextBox.Anchor = AnchorStyles.None;
            rentIDTextBox.Location = new Point(186, 265);
            rentIDTextBox.Multiline = true;
            rentIDTextBox.Name = "rentIDTextBox";
            rentIDTextBox.Size = new Size(235, 30);
            rentIDTextBox.TabIndex = 28;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(65, 265);
            label4.Name = "label4";
            label4.Size = new Size(92, 28);
            label4.TabIndex = 27;
            label4.Text = "Rent ID: *";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(46, 214);
            label3.Name = "label3";
            label3.Size = new Size(111, 28);
            label3.TabIndex = 25;
            label3.Text = "Fuel Type: *";
            // 
            // addButton
            // 
            addButton.Anchor = AnchorStyles.None;
            addButton.BackColor = Color.FromArgb(1, 30, 64);
            addButton.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Bold, GraphicsUnit.Point);
            addButton.ForeColor = SystemColors.ButtonHighlight;
            addButton.Location = new Point(41, 594);
            addButton.Name = "addButton";
            addButton.Size = new Size(145, 42);
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
            label2.Location = new Point(53, 158);
            label2.Name = "label2";
            label2.Size = new Size(104, 28);
            label2.TabIndex = 13;
            label2.Text = "Car Type: *";
            // 
            // carsInfoGrid
            // 
            carsInfoGrid.Anchor = AnchorStyles.None;
            carsInfoGrid.BackgroundColor = SystemColors.ButtonHighlight;
            carsInfoGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            carsInfoGrid.Location = new Point(458, 176);
            carsInfoGrid.Name = "carsInfoGrid";
            carsInfoGrid.RowHeadersWidth = 51;
            carsInfoGrid.RowTemplate.Height = 29;
            carsInfoGrid.Size = new Size(858, 224);
            carsInfoGrid.TabIndex = 9;
            carsInfoGrid.CellClick += carsInfoGrid_CellClick;
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
            panel4.Dock = DockStyle.Bottom;
            panel4.Location = new Point(0, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(1316, 38);
            panel4.TabIndex = 22;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(69, 19, 54);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(backButtonadmin);
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
            label8.Location = new Point(479, 21);
            label8.Name = "label8";
            label8.Size = new Size(493, 39);
            label8.TabIndex = 18;
            label8.Text = "THE CAR RENTAL SYSTAM ";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ControlLight;
            label1.Location = new Point(625, 69);
            label1.Name = "label1";
            label1.Size = new Size(216, 29);
            label1.TabIndex = 17;
            label1.Text = "MANAGE RENTS";
            // 
            // backButtonadmin
            // 
            backButtonadmin.Image = Properties.Resources.backarrow;
            backButtonadmin.Location = new Point(3, 9);
            backButtonadmin.Name = "backButtonadmin";
            backButtonadmin.Size = new Size(35, 32);
            backButtonadmin.SizeMode = PictureBoxSizeMode.StretchImage;
            backButtonadmin.TabIndex = 14;
            backButtonadmin.TabStop = false;
            backButtonadmin.Click += backButton_Click;
            // 
            // backButtonuser
            // 
            backButtonuser.Image = Properties.Resources.backarrow;
            backButtonuser.Location = new Point(3, 9);
            backButtonuser.Name = "backButtonuser";
            backButtonuser.Size = new Size(35, 32);
            backButtonuser.SizeMode = PictureBoxSizeMode.StretchImage;
            backButtonuser.TabIndex = 19;
            backButtonuser.TabStop = false;
            backButtonuser.Click += backButtonuser_Click;
            // 
            // ManageRentalCarsPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1316, 749);
            Controls.Add(panel1);
            Name = "ManageRentalCarsPage";
            Text = "ManageRentalCarsPage";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            rentalviewPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ((System.ComponentModel.ISupportInitialize)rentCarsGrid).EndInit();
            ((System.ComponentModel.ISupportInitialize)carsInfoGrid).EndInit();
            panel3.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)backButtonadmin).EndInit();
            ((System.ComponentModel.ISupportInitialize)backButtonuser).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TextBox customerIDTextBox;
        private Button deleteButton;
        private Button showButton;
        private Label label6;
        private Label label5;
        private TextBox rentIDTextBox;
        private Label label4;
        private Label label3;
        private Button addButton;
        private Label label2;
        private DataGridView carsInfoGrid;
        private Panel panel3;
        private Panel panel2;
        private PictureBox backButtonadmin;
        private ComboBox fuelTypeComboBox;
        private ComboBox carTypeComboBox;
        private Label label7;
        private DateTimePicker endDatePicker;
        private DateTimePicker startDatePicker;
        private Label label10;
        private TextBox carIDTextBox;
        private DataGridView rentCarsGrid;
        private Label label11;
        private Button generateBill;
        private Label label12;
        private Label label8;
        private Label label1;
        private Panel rentalviewPanel;
        private DataGridView dataGridView2;
        private Button buttonShow;
        private Button rentshow;
        private PictureBox backButtonuser;
        private Label label9;
        private Panel panel4;
    }
}