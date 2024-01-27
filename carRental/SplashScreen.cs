namespace carRental
{
    public partial class SplashScreen : Form
    {
        public SplashScreen()
        {
            InitializeComponent();

            this.FormBorderStyle = FormBorderStyle.None;
        }
        int startpoint = 0;

        private void timer1_Tick(object sender, EventArgs e)
        {
            startpoint += 2;
            progressBar.Value = startpoint;
            timerPer.Text = progressBar.Value.ToString() + "%";
            if (progressBar.Value == 100)
            {
                progressBar.Value = 0;
                timer1.Stop();
                LoginOptions op = new LoginOptions();
                op.Show();
                this.Hide();
            }
        }

        private void splashPanel_Paint(object sender, PaintEventArgs e)
        {
            timer1.Start();
        }
    }
}