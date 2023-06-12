using System.Collections;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using System.Collections.Generic;
using System;
using System.Security.Cryptography.Xml;
using System.Security.Policy;
using System.Diagnostics;
using System;
using System.Drawing;
using System.Net;
using System.Windows.Forms;

namespace GeoGuesser
{
    public partial class Form1 : Form
    {

        private Form thirdForm;
        private Game g1 = new Game();
        private Country c1 = new Country(); 
        private Dictionary<int, Array> countries = new Dictionary<int, Array>();
        private Dictionary<int, HashSet<string>> keyValuePairs= new Dictionary<int, HashSet<string>>();
        private int score = 0;
        private int country;
        private int tTime;
        private int tQuestions;
        private Random rnd = new Random();
        private String diff;
        ArrayList used = new ArrayList();
        Boolean usedBool = false;

        System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"C:\Users\ayush\Downloads\correct.wav");


        public Form1()
        {
            diff = Form2.diff;
            if (diff.Equals("Hard"))
            {
                tTime = 90;
                tQuestions = 99;
                c1.fillCountriesHard();
            }
            else if (diff.Equals("Medium"))
            {
                tTime = 60;
                tQuestions = 53;
                c1.fillCountriesMedium();
            }
            else
            {
                tTime = 30;
                tQuestions = 28;
                c1.fillCountriesEasy();
            }
            country = rnd.Next(0, tQuestions);
            used.Add(country); 
            keyValuePairs = c1.getCountries(); 
            InitializeComponent();
            string imageLink = keyValuePairs[country].ToArray()[1]; 
            mapBox.SizeMode = PictureBoxSizeMode.StretchImage;
            mapBox.ImageLocation = imageLink;
        }
        
        
        private void SetBackgroundImage(string imageUrl)
        {
            try
            {
                using (WebClient client = new WebClient())
                {
                    byte[] imageData = client.DownloadData(imageUrl);
                    using (var stream = new System.IO.MemoryStream(imageData))
                    {
                        Image backgroundImage = Image.FromStream(stream);
                        this.BackgroundImage = backgroundImage;
                        this.BackgroundImageLayout = ImageLayout.Stretch;
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle any exceptions that may occur while setting the background image
                Console.WriteLine("Error setting background image: " + ex.Message);
            }
        }
        
        int wrong = 0;
        private void enterButton_Click(object sender, EventArgs e)
        {
            g1.getGuess(userText.Text);

            if (userText.Text.Equals(keyValuePairs[country].ToArray()[0]))
            {
                //player.Play();
                score++; 
                scoreLbl.Text = "Score: " + score;
                userText.Clear();

                country = findCountry(used, tQuestions);
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
                country = findCountry(used, tQuestions);
                string imageLink = keyValuePairs[country].ToArray()[1];
                mapBox.SizeMode = PictureBoxSizeMode.StretchImage;
                mapBox.ImageLocation = imageLink;
            }
        }

        int time = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {

            time++;
            Timer.Text = "Timer: " + (tTime - time); 
           
            if (time == tTime)
            {
                if (thirdForm == null)
                    thirdForm = new Form3();

                Hide();
                thirdForm.Show();
            }


        }

        private void skipButton_Click(object sender, EventArgs e)
        {
            userText.Clear();
            country = findCountry(used, tQuestions); 
            string imageLink = keyValuePairs[country].ToArray()[1];
            mapBox.SizeMode = PictureBoxSizeMode.StretchImage;
            mapBox.ImageLocation = imageLink;
        }

        public static int findCountry(ArrayList usedNumbers, int tQuestions)
        {
            Random random = new Random();
            int randomNumber = random.Next(0, tQuestions);

            while (usedNumbers.Contains(randomNumber))
            {
                randomNumber = random.Next(0, tQuestions);
            }

            usedNumbers.Add(randomNumber);
            return randomNumber;
        }
        
        private void mapBox_Paint(object sender, PaintEventArgs e)
        {
            PictureBox pictureBox = sender as PictureBox;
            if (pictureBox != null)
            {
                using (Pen pen = new Pen(Color.Orange, 2))
                {
                    e.Graphics.DrawRectangle(pen, new Rectangle(0, 0, pictureBox.Width - 1, pictureBox.Height - 1));
                }
            }
        }


    }
}
