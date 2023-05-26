namespace GeoGuesser
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.enterButton = new System.Windows.Forms.Button();
            this.userText = new System.Windows.Forms.TextBox();
            this.Title = new System.Windows.Forms.Label();
            this.mapBox = new System.Windows.Forms.PictureBox();
            this.Timer = new System.Windows.Forms.Label();
            this.scoreLbl = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.skipButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.mapBox)).BeginInit();
            this.SuspendLayout();
            // 
            // enterButton
            // 
            this.enterButton.Location = new System.Drawing.Point(344, 333);
            this.enterButton.Name = "enterButton";
            this.enterButton.Size = new System.Drawing.Size(75, 23);
            this.enterButton.TabIndex = 0;
            this.enterButton.Text = "Enter";
            this.enterButton.UseVisualStyleBackColor = true;
            this.enterButton.Click += new System.EventHandler(this.enterButton_Click);
            // 
            // userText
            // 
            this.userText.Location = new System.Drawing.Point(305, 304);
            this.userText.Name = "userText";
            this.userText.Size = new System.Drawing.Size(156, 23);
            this.userText.TabIndex = 1;
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Title.Location = new System.Drawing.Point(281, 94);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(207, 37);
            this.Title.TabIndex = 2;
            this.Title.Text = "CountroGuesser";
            // 
            // mapBox
            // 
            this.mapBox.Location = new System.Drawing.Point(269, 145);
            this.mapBox.Name = "mapBox";
            this.mapBox.Size = new System.Drawing.Size(233, 153);
            this.mapBox.TabIndex = 3;
            this.mapBox.TabStop = false;
            // 
            // Timer
            // 
            this.Timer.AutoSize = true;
            this.Timer.Location = new System.Drawing.Point(31, 33);
            this.Timer.Name = "Timer";
            this.Timer.Size = new System.Drawing.Size(43, 15);
            this.Timer.TabIndex = 4;
            this.Timer.Text = "Timer: ";
            // 
            // scoreLbl
            // 
            this.scoreLbl.AutoSize = true;
            this.scoreLbl.Location = new System.Drawing.Point(652, 33);
            this.scoreLbl.Name = "scoreLbl";
            this.scoreLbl.Size = new System.Drawing.Size(42, 15);
            this.scoreLbl.TabIndex = 6;
            this.scoreLbl.Text = "Score: ";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // skipButton
            // 
            this.skipButton.Location = new System.Drawing.Point(344, 362);
            this.skipButton.Name = "skipButton";
            this.skipButton.Size = new System.Drawing.Size(75, 23);
            this.skipButton.TabIndex = 7;
            this.skipButton.Text = "Skip";
            this.skipButton.UseVisualStyleBackColor = true;
            this.skipButton.Click += new System.EventHandler(this.skipButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.skipButton);
            this.Controls.Add(this.scoreLbl);
            this.Controls.Add(this.Timer);
            this.Controls.Add(this.mapBox);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.userText);
            this.Controls.Add(this.enterButton);
            this.Name = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.mapBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button enterButton;
        private TextBox userText;
        private Label Title;
        private PictureBox mapBox;
        private Label Timer;
        private Label scoreLbl;
        private System.Windows.Forms.Timer timer1;
        private Button skipButton;
    }
}