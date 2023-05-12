using System.Collections;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using System.Collections.Generic;
using System;
using System.Security.Cryptography.Xml;
using System.Security.Policy;

namespace GeoGuesser
{
    public partial class Form1 : Form
    {

        Game g1 = new Game();
        Country c1 = new Country(); 
        Dictionary<int, Array> countries = new Dictionary<int, Array>();
        Dictionary<int, HashSet<string>> keyValuePairs= new Dictionary<int, HashSet<string>>();
        int score = 0; 

        public Form1()
        {
            c1.fillCountries();
            keyValuePairs = c1.getCountries(); 
            InitializeComponent();
            string imageLink = keyValuePairs[1].ToArray()[1]; 
            mapBox.SizeMode = PictureBoxSizeMode.StretchImage;
            mapBox.ImageLocation = imageLink;
        }
        

        private void enterButton_Click(object sender, EventArgs e)
        {
            g1.getGuess(userText.Text);

            if (userText.Text.Equals(keyValuePairs[1].ToArray()[0]))
            {
                score++; 
                scoreLbl.Text = "Score: " + score;
                userText.Clear();
            }
        }
    }
}
