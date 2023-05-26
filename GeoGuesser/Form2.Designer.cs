namespace GeoGuesser
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.startButton = new System.Windows.Forms.Button();
            this.hardDiff = new System.Windows.Forms.Button();
            this.medDiff = new System.Windows.Forms.Button();
            this.easyDiff = new System.Windows.Forms.Button();
            this.diffLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(365, 273);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(75, 23);
            this.startButton.TabIndex = 0;
            this.startButton.Text = "Start Game";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // hardDiff
            // 
            this.hardDiff.Location = new System.Drawing.Point(284, 329);
            this.hardDiff.Name = "hardDiff";
            this.hardDiff.Size = new System.Drawing.Size(75, 23);
            this.hardDiff.TabIndex = 1;
            this.hardDiff.Text = "Hard";
            this.hardDiff.UseVisualStyleBackColor = true;
            this.hardDiff.Click += new System.EventHandler(this.hardDiff_Click);
            // 
            // medDiff
            // 
            this.medDiff.Location = new System.Drawing.Point(365, 329);
            this.medDiff.Name = "medDiff";
            this.medDiff.Size = new System.Drawing.Size(75, 23);
            this.medDiff.TabIndex = 2;
            this.medDiff.Text = "Medium";
            this.medDiff.UseVisualStyleBackColor = true;
            this.medDiff.Click += new System.EventHandler(this.medDiff_Click);
            // 
            // easyDiff
            // 
            this.easyDiff.Location = new System.Drawing.Point(446, 329);
            this.easyDiff.Name = "easyDiff";
            this.easyDiff.Size = new System.Drawing.Size(75, 23);
            this.easyDiff.TabIndex = 4;
            this.easyDiff.Text = "Easy";
            this.easyDiff.UseVisualStyleBackColor = true;
            this.easyDiff.Click += new System.EventHandler(this.easyDiff_Click);
            // 
            // diffLabel
            // 
            this.diffLabel.AutoSize = true;
            this.diffLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.diffLabel.Location = new System.Drawing.Point(379, 374);
            this.diffLabel.Name = "diffLabel";
            this.diffLabel.Size = new System.Drawing.Size(41, 21);
            this.diffLabel.TabIndex = 5;
            this.diffLabel.Text = "Easy";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.diffLabel);
            this.Controls.Add(this.easyDiff);
            this.Controls.Add(this.medDiff);
            this.Controls.Add(this.hardDiff);
            this.Controls.Add(this.startButton);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button startButton;
        private Button hardDiff;
        private Button medDiff;
        private Button easyDiff;
        private Label diffLabel;
    }
}