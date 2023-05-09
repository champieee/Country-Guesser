namespace GeoGuesser
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Game g1 = new Game();

        private void enterButton_Click(object sender, EventArgs e)
        {
            g1.getGuess(userText.Text);
            userText.Clear();
        }
    }
}
