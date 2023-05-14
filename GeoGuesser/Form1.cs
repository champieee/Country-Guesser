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
        int country;
        Random rnd = new Random();
        

        public Form1()
        {
            country = rnd.Next(0, 2);
            c1.fillCountries();
            keyValuePairs = c1.getCountries(); 
            InitializeComponent();
            string imageLink = keyValuePairs[country].ToArray()[country]; 
            mapBox.SizeMode = PictureBoxSizeMode.StretchImage;
            mapBox.ImageLocation = imageLink;
        }
            

        private void enterButton_Click(object sender, EventArgs e)
        {
            g1.getGuess(userText.Text);

            if (userText.Text.Equals(keyValuePairs[country].ToArray()[country]))
            {
                score++; 
                scoreLbl.Text = "Score: " + score;
                userText.Clear();
            }
        }
    }
}
