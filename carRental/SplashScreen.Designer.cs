namespace carRental
{
    partial class SplashScreen
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SplashScreen));
            splashPanel = new Panel();
            label3 = new Label();
            progressBar = new ProgressBar();
            timerPer = new Label();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            timer1 = new System.Windows.Forms.Timer(components);
            splashPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // splashPanel
            // 
            splashPanel.BackColor = Color.Transparent;
            splashPanel.BackgroundImage = Properties.Resources.rm218_bb_07;
            splashPanel.BackgroundImageLayout = ImageLayout.Stretch;
            splashPanel.Controls.Add(label3);
            splashPanel.Controls.Add(progressBar);
            splashPanel.Controls.Add(timerPer);
            splashPanel.Controls.Add(label2);
            splashPanel.Controls.Add(label1);
            splashPanel.Controls.Add(pictureBox1);
            splashPanel.Dock = DockStyle.Fill;
            splashPanel.Location = new Point(0, 0);
            splashPanel.Margin = new Padding(4);
            splashPanel.Name = "splashPanel";
            splashPanel.Size = new Size(1645, 936);
            splashPanel.TabIndex = 0;
            splashPanel.UseWaitCursor = true;
            splashPanel.Paint += splashPanel_Paint;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Cooper Black", 26F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.WhiteSmoke;
            label3.Location = new Point(280, 192);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(1055, 60);
            label3.TabIndex = 7;
            label3.Text = "CAR RENTAL MANAGEMENT SYSTEM";
            label3.UseWaitCursor = true;
            // 
            // progressBar
            // 
            progressBar.ForeColor = Color.FromArgb(153, 30, 112);
            progressBar.Location = new Point(515, 829);
            progressBar.Margin = new Padding(4);
            progressBar.Name = "progressBar";
            progressBar.Size = new Size(642, 36);
            progressBar.TabIndex = 6;
            progressBar.UseWaitCursor = true;
            // 
            // timerPer
            // 
            timerPer.AutoSize = true;
            timerPer.BackColor = Color.Transparent;
            timerPer.Font = new Font("Roboto Condensed", 9F, FontStyle.Regular, GraphicsUnit.Point);
            timerPer.ForeColor = SystemColors.ControlLight;
            timerPer.Location = new Point(821, 774);
            timerPer.Margin = new Padding(4, 0, 4, 0);
            timerPer.Name = "timerPer";
            timerPer.Size = new Size(53, 22);
            timerPer.TabIndex = 5;
            timerPer.Text = "label3";
            timerPer.UseWaitCursor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Roboto", 14F, FontStyle.Italic, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ControlLight;
            label2.Location = new Point(682, 728);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(335, 34);
            label2.TabIndex = 2;
            label2.Text = "Loading........  Please Wait!";
            label2.UseWaitCursor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Roboto Condensed", 20F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ControlLight;
            label1.Location = new Point(706, 107);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(260, 48);
            label1.TabIndex = 1;
            label1.Text = "WELCOME   TO ";
            label1.UseWaitCursor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(457, 273);
            pictureBox1.Margin = new Padding(4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(726, 384);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.UseWaitCursor = true;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // SplashScreen
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1645, 936);
            Controls.Add(splashPanel);
            Margin = new Padding(4);
            Name = "SplashScreen";
            Text = "Form1";
            splashPanel.ResumeLayout(false);
            splashPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel splashPanel;
        private Label label2;
        private Label label1;
        private System.Windows.Forms.Timer timer1;
        private Label timerPer;
        private ProgressBar progressBar;
        private PictureBox pictureBox1;
        private Label label3;
    }
}