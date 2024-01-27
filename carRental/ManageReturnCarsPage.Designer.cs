namespace carRental
{
    partial class ManageReturnCarsPage
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
            returnviewPanel = new Panel();
            returnShow = new Button();
            dataGridView2 = new DataGridView();
            buttonShow = new Button();
            carIDTextBox = new TextBox();
            label7 = new Label();
            returnIDTextBox = new TextBox();
            label2 = new Label();
            generateBill = new Button();
            label12 = new Label();
            label11 = new Label();
            returnCarsGrid = new DataGridView();
            returnDatePicker = new DateTimePicker();
            deleteButton = new Button();
            showButton = new Button();
            label5 = new Label();
            rentIDTextBox = new TextBox();
            label4 = new Label();
            addButton = new Button();
            rentInfoGrid = new DataGridView();
            panel3 = new Panel();
            panel4 = new Panel();
            panel2 = new Panel();
            label8 = new Label();
            label1 = new Label();
            backButtonadmin = new PictureBox();
            backButtonuser = new PictureBox();
            panel1.SuspendLayout();
            returnviewPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)returnCarsGrid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)rentInfoGrid).BeginInit();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)backButtonadmin).BeginInit();
            ((System.ComponentModel.ISupportInitialize)backButtonuser).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(46, 97, 145);
            panel1.Controls.Add(returnviewPanel);
            panel1.Controls.Add(carIDTextBox);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(returnIDTextBox);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(generateBill);
            panel1.Controls.Add(label12);
            panel1.Controls.Add(label11);
            panel1.Controls.Add(returnCarsGrid);
            panel1.Controls.Add(returnDatePicker);
            panel1.Controls.Add(deleteButton);
            panel1.Controls.Add(showButton);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(rentIDTextBox);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(addButton);
            panel1.Controls.Add(rentInfoGrid);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1316, 749);
            panel1.TabIndex = 4;
            // 
            // returnviewPanel
            // 
            returnviewPanel.Anchor = AnchorStyles.None;
            returnviewPanel.Controls.Add(returnShow);
            returnviewPanel.Controls.Add(dataGridView2);
            returnviewPanel.Controls.Add(buttonShow);
            returnviewPanel.Location = new Point(3, 120);
            returnviewPanel.Name = "returnviewPanel";
            returnviewPanel.Size = new Size(1316, 591);
            returnviewPanel.TabIndex = 56;
            // 
            // returnShow
            // 
            returnShow.Anchor = AnchorStyles.None;
            returnShow.BackColor = Color.FromArgb(1, 30, 64);
            returnShow.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Bold, GraphicsUnit.Point);
            returnShow.ForeColor = SystemColors.ButtonHighlight;
            returnShow.Location = new Point(1156, 527);
            returnShow.Name = "returnShow";
            returnShow.Size = new Size(130, 42);
            returnShow.TabIndex = 35;
            returnShow.Text = "SHOW";
            returnShow.UseVisualStyleBackColor = false;
            returnShow.Click += returnShow_Click;
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
            // carIDTextBox
            // 
            carIDTextBox.Anchor = AnchorStyles.None;
            carIDTextBox.Location = new Point(186, 178);
            carIDTextBox.Multiline = true;
            carIDTextBox.Name = "carIDTextBox";
            carIDTextBox.Size = new Size(235, 30);
            carIDTextBox.TabIndex = 55;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.None;
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(75, 178);
            label7.Name = "label7";
            label7.Size = new Size(82, 28);
            label7.TabIndex = 54;
            label7.Text = "Car ID: *";
            // 
            // returnIDTextBox
            // 
            returnIDTextBox.Anchor = AnchorStyles.None;
            returnIDTextBox.Location = new Point(186, 232);
            returnIDTextBox.Multiline = true;
            returnIDTextBox.Name = "returnIDTextBox";
            returnIDTextBox.Size = new Size(235, 30);
            returnIDTextBox.TabIndex = 53;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(47, 232);
            label2.Name = "label2";
            label2.Size = new Size(110, 28);
            label2.TabIndex = 52;
            label2.Text = "Return ID: *";
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
            label12.Location = new Point(806, 412);
            label12.Name = "label12";
            label12.Size = new Size(175, 32);
            label12.TabIndex = 50;
            label12.Text = "Returned Cars";
            // 
            // label11
            // 
            label11.Anchor = AnchorStyles.None;
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label11.ForeColor = SystemColors.ControlText;
            label11.Location = new Point(806, 130);
            label11.Name = "label11";
            label11.Size = new Size(162, 32);
            label11.TabIndex = 49;
            label11.Text = "Cars On Rent";
            // 
            // returnCarsGrid
            // 
            returnCarsGrid.Anchor = AnchorStyles.None;
            returnCarsGrid.BackgroundColor = SystemColors.ButtonHighlight;
            returnCarsGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            returnCarsGrid.Location = new Point(458, 458);
            returnCarsGrid.Name = "returnCarsGrid";
            returnCarsGrid.RowHeadersWidth = 51;
            returnCarsGrid.RowTemplate.Height = 29;
            returnCarsGrid.Size = new Size(858, 240);
            returnCarsGrid.TabIndex = 46;
            // 
            // returnDatePicker
            // 
            returnDatePicker.Anchor = AnchorStyles.None;
            returnDatePicker.Location = new Point(186, 342);
            returnDatePicker.Name = "returnDatePicker";
            returnDatePicker.Size = new Size(263, 27);
            returnDatePicker.TabIndex = 42;
            // 
            // deleteButton
            // 
            deleteButton.Anchor = AnchorStyles.None;
            deleteButton.BackColor = Color.FromArgb(1, 30, 64);
            deleteButton.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Bold, GraphicsUnit.Point);
            deleteButton.ForeColor = SystemColors.ButtonHighlight;
            deleteButton.Location = new Point(41, 656);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(147, 42);
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
            showButton.Size = new Size(147, 42);
            showButton.TabIndex = 32;
            showButton.Text = "SHOW";
            showButton.UseVisualStyleBackColor = false;
            showButton.Click += showButton_Click;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(33, 340);
            label5.Name = "label5";
            label5.Size = new Size(124, 28);
            label5.TabIndex = 29;
            label5.Text = "Delay Date: *";
            // 
            // rentIDTextBox
            // 
            rentIDTextBox.Anchor = AnchorStyles.None;
            rentIDTextBox.Location = new Point(186, 286);
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
            label4.Location = new Point(65, 286);
            label4.Name = "label4";
            label4.Size = new Size(92, 28);
            label4.TabIndex = 27;
            label4.Text = "Rent ID: *";
            // 
            // addButton
            // 
            addButton.Anchor = AnchorStyles.None;
            addButton.BackColor = Color.FromArgb(1, 30, 64);
            addButton.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Bold, GraphicsUnit.Point);
            addButton.ForeColor = SystemColors.ButtonHighlight;
            addButton.Location = new Point(41, 594);
            addButton.Name = "addButton";
            addButton.Size = new Size(147, 42);
            addButton.TabIndex = 20;
            addButton.Text = "ADD";
            addButton.UseVisualStyleBackColor = false;
            addButton.Click += addButton_Click;
            // 
            // rentInfoGrid
            // 
            rentInfoGrid.Anchor = AnchorStyles.None;
            rentInfoGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            rentInfoGrid.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            rentInfoGrid.BackgroundColor = SystemColors.ButtonHighlight;
            rentInfoGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            rentInfoGrid.Location = new Point(458, 164);
            rentInfoGrid.Name = "rentInfoGrid";
            rentInfoGrid.RowHeadersWidth = 51;
            rentInfoGrid.RowTemplate.Height = 29;
            rentInfoGrid.Size = new Size(858, 224);
            rentInfoGrid.TabIndex = 9;
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
            panel4.TabIndex = 21;
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
            label8.Location = new Point(480, 22);
            label8.Name = "label8";
            label8.Size = new Size(493, 39);
            label8.TabIndex = 20;
            label8.Text = "THE CAR RENTAL SYSTAM ";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ControlLight;
            label1.Location = new Point(582, 70);
            label1.Name = "label1";
            label1.Size = new Size(252, 29);
            label1.TabIndex = 19;
            label1.Text = "MANAGE RETURNS";
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
            backButtonuser.TabIndex = 21;
            backButtonuser.TabStop = false;
            // 
            // ManageReturnCarsPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1316, 749);
            Controls.Add(panel1);
            Name = "ManageReturnCarsPage";
            Text = "ManageReturnCars";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            returnviewPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ((System.ComponentModel.ISupportInitialize)returnCarsGrid).EndInit();
            ((System.ComponentModel.ISupportInitialize)rentInfoGrid).EndInit();
            panel3.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)backButtonadmin).EndInit();
            ((System.ComponentModel.ISupportInitialize)backButtonuser).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button generateBill;
        private Label label12;
        private Label label11;
        private DataGridView returnCarsGrid;
        private Label label9;
        private TextBox regNumTextBox;
        private DateTimePicker endDatePicker;
        private DateTimePicker returnDatePicker;
        private ComboBox fuelTypeComboBox;
        private ComboBox carTypeComboBox;
        private Button deleteButton;
        private Button showButton;
        private Label label5;
        private TextBox rentIDTextBox;
        private Label label4;
        private Label label3;
        private Button addButton;
        private DataGridView rentInfoGrid;
        private Panel panel3;
        private Panel panel2;
        private PictureBox backButtonadmin;
        private TextBox returnIDTextBox;
        private Label label2;
        private TextBox carIDTextBox;
        private Label label7;
        private Label label8;
        private Label label1;
        private Panel returnviewPanel;
        private DataGridView dataGridView2;
        private Button buttonShow;
        private Button returnShow;
        private PictureBox backButtonuser;
        private Panel panel4;
    }
}