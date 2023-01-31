namespace ScroolBar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            image.Size = new Size((int)nUpD.Value, (int)nUpD.Value);
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            image.Size = new Size(trackBar1.Value,trackBar1.Value);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Tick += Timer1_Tick;
            timer1.Start();
        }

        private void Timer1_Tick(object? sender, EventArgs e)
        {
            progressBar1.PerformStep();
            label1.Text = progressBar1.Value.ToString();
            if(progressBar1.Value == progressBar1.Maximum)
            {
                progressBar1.Value = progressBar1.Minimum;
            }
        }
        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            image.Location = new Point(0, vScrollBar1.Value * 5);
        }
    }
}