namespace TimerAndRandom
{
    public partial class Form1 : Form
    {
        private Random _Random;
        public Form1()
        {
            InitializeComponent();
            _Random = new Random();
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            RunTimer.Enabled = !RunTimer.Enabled;
            StartButton.Text = RunTimer.Enabled ? "Stop" : "Start";
        }

        private void ChangePanelColor()
        {
            var red = _Random.Next(0, 256);
            var green = _Random.Next(0, 256);
            var blue = _Random.Next(0, 256);

            RedTextBox.Text = red.ToString();
            GreenTextBox.Text = green.ToString();
            BlueTextBox.Text = blue.ToString();

            ColorPanel.BackColor = Color.FromArgb(red, green, blue);
        }

        private void RunTimer_Tick(object sender, EventArgs e)
        {
            ChangePanelColor();
        }
    }
}