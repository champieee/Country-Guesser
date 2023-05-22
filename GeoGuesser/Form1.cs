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
        private Form _firstForm;
        private Form _secondForm;


        public Form1()
        { 
            country = rnd.Next(0, 28);
            c1.fillCountriesEasy();
            keyValuePairs = c1.getCountries(); 
            InitializeComponent();
            string imageLink = keyValuePairs[country].ToArray()[1]; 
            mapBox.SizeMode = PictureBoxSizeMode.StretchImage;
            mapBox.ImageLocation = imageLink;
        }



        int wrong = 0;
        private void enterButton_Click(object sender, EventArgs e)
        {
            g1.getGuess(userText.Text);

            if (userText.Text.Equals(keyValuePairs[country].ToArray()[0]))
            {
                score++; 
                scoreLbl.Text = "Score: " + score;
                userText.Clear();
                country = rnd.Next(0, 28);
                string imageLink = keyValuePairs[country].ToArray()[1];
                mapBox.SizeMode = PictureBoxSizeMode.StretchImage;
                mapBox.ImageLocation = imageLink;
            } else
            {
                userText.Clear();
                wrong++; 
            }

            if (wrong == 3)
            {
                country = rnd.Next(0, 28);
                string imageLink = keyValuePairs[country].ToArray()[1];
                mapBox.SizeMode = PictureBoxSizeMode.StretchImage;
                mapBox.ImageLocation = imageLink;
            }
        }
    }
}
