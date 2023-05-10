using System.Collections;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using System.Collections.Generic;

namespace GeoGuesser
{
    public partial class Form1 : Form
    {

        Game g1 = new Game();
        Dictionary<int, ArrayList> countries = new Dictionary<int, ArrayList>();
        int score = 0;


        public Form1()
        {
            ArrayList nepal = new ArrayList();
            nepal.Add("Nepal");
            nepal.Add("https://webpati.com/wp-content/uploads/2020/07/new-nepal-map.png");
            countries.Add(0, nepal);
            InitializeComponent();


        for(int i = 0; i < 100; i++){
            string imageLink = (string)countries[0][i];
            mapBox.SizeMode = PictureBoxSizeMode.StretchImage;
            mapBox.ImageLocation = imageLink;
        }
        }
        

        private void enterButton_Click(object sender, EventArgs e)
        {
            g1.getGuess(userText.Text);

            if (userText.Text.Equals((string)countries[0][0]))
            {
                score++; 
                scoreLbl.Text = "Score: " + score;
                userText.Clear();
            }
        }

    }
}
