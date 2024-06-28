namespace WeatherApp
{
    partial class Form1
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
            this.CityLabel = new System.Windows.Forms.Label();
            this.CityTextBox = new System.Windows.Forms.TextBox();
            this.SearchBtn = new System.Windows.Forms.Button();
            this.CondtionLabel = new System.Windows.Forms.Label();
            this.DetailsLabel = new System.Windows.Forms.Label();
            this.SunriseLabel = new System.Windows.Forms.Label();
            this.SunriseDataLabel = new System.Windows.Forms.Label();
            this.SunsetDataLabel = new System.Windows.Forms.Label();
            this.SunsetLabel = new System.Windows.Forms.Label();
            this.WindSpeedDataLabel = new System.Windows.Forms.Label();
            this.WindSpeedLabel = new System.Windows.Forms.Label();
            this.PressureDataLabel = new System.Windows.Forms.Label();
            this.PressureLabel = new System.Windows.Forms.Label();
            this.PicIcon = new System.Windows.Forms.PictureBox();
            this.ForecastFLP = new System.Windows.Forms.FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.PicIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // CityLabel
            // 
            this.CityLabel.AutoSize = true;
            this.CityLabel.BackColor = System.Drawing.Color.Transparent;
            this.CityLabel.Font = new System.Drawing.Font("Ravie", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CityLabel.ForeColor = System.Drawing.Color.Coral;
            this.CityLabel.Location = new System.Drawing.Point(69, 60);
            this.CityLabel.Name = "CityLabel";
            this.CityLabel.Size = new System.Drawing.Size(80, 32);
            this.CityLabel.TabIndex = 0;
            this.CityLabel.Text = "City";
            // 
            // CityTextBox
            // 
            this.CityTextBox.Font = new System.Drawing.Font("Ravie", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CityTextBox.Location = new System.Drawing.Point(155, 60);
            this.CityTextBox.Name = "CityTextBox";
            this.CityTextBox.Size = new System.Drawing.Size(213, 38);
            this.CityTextBox.TabIndex = 1;
            // 
            // SearchBtn
            // 
            this.SearchBtn.BackColor = System.Drawing.Color.Transparent;
            this.SearchBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SearchBtn.Font = new System.Drawing.Font("Ravie", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchBtn.ForeColor = System.Drawing.Color.IndianRed;
            this.SearchBtn.Location = new System.Drawing.Point(384, 51);
            this.SearchBtn.Name = "SearchBtn";
            this.SearchBtn.Size = new System.Drawing.Size(177, 57);
            this.SearchBtn.TabIndex = 2;
            this.SearchBtn.Text = "Search";
            this.SearchBtn.UseVisualStyleBackColor = false;
            this.SearchBtn.Click += new System.EventHandler(this.SearchBtn_Click);
            // 
            // CondtionLabel
            // 
            this.CondtionLabel.AutoSize = true;
            this.CondtionLabel.BackColor = System.Drawing.Color.Transparent;
            this.CondtionLabel.Font = new System.Drawing.Font("Ravie", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CondtionLabel.ForeColor = System.Drawing.Color.Coral;
            this.CondtionLabel.Location = new System.Drawing.Point(64, 234);
            this.CondtionLabel.Name = "CondtionLabel";
            this.CondtionLabel.Size = new System.Drawing.Size(157, 32);
            this.CondtionLabel.TabIndex = 3;
            this.CondtionLabel.Text = "Condition";
            this.CondtionLabel.Click += new System.EventHandler(this.CondtionLabel_Click);
            // 
            // DetailsLabel
            // 
            this.DetailsLabel.AutoSize = true;
            this.DetailsLabel.BackColor = System.Drawing.Color.Transparent;
            this.DetailsLabel.Font = new System.Drawing.Font("Ravie", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DetailsLabel.ForeColor = System.Drawing.Color.Coral;
            this.DetailsLabel.Location = new System.Drawing.Point(64, 296);
            this.DetailsLabel.Name = "DetailsLabel";
            this.DetailsLabel.Size = new System.Drawing.Size(124, 32);
            this.DetailsLabel.TabIndex = 4;
            this.DetailsLabel.Text = "Details";
            // 
            // SunriseLabel
            // 
            this.SunriseLabel.AutoSize = true;
            this.SunriseLabel.BackColor = System.Drawing.Color.Transparent;
            this.SunriseLabel.Font = new System.Drawing.Font("Ravie", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SunriseLabel.ForeColor = System.Drawing.Color.Coral;
            this.SunriseLabel.Location = new System.Drawing.Point(64, 351);
            this.SunriseLabel.Name = "SunriseLabel";
            this.SunriseLabel.Size = new System.Drawing.Size(142, 32);
            this.SunriseLabel.TabIndex = 5;
            this.SunriseLabel.Text = "Sunrise:";
            // 
            // SunriseDataLabel
            // 
            this.SunriseDataLabel.AutoSize = true;
            this.SunriseDataLabel.BackColor = System.Drawing.Color.Transparent;
            this.SunriseDataLabel.Font = new System.Drawing.Font("Ravie", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SunriseDataLabel.ForeColor = System.Drawing.Color.Coral;
            this.SunriseDataLabel.Location = new System.Drawing.Point(212, 351);
            this.SunriseDataLabel.Name = "SunriseDataLabel";
            this.SunriseDataLabel.Size = new System.Drawing.Size(69, 32);
            this.SunriseDataLabel.TabIndex = 6;
            this.SunriseDataLabel.Text = "N/A";
            // 
            // SunsetDataLabel
            // 
            this.SunsetDataLabel.AutoSize = true;
            this.SunsetDataLabel.BackColor = System.Drawing.Color.Transparent;
            this.SunsetDataLabel.Font = new System.Drawing.Font("Ravie", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SunsetDataLabel.ForeColor = System.Drawing.Color.Coral;
            this.SunsetDataLabel.Location = new System.Drawing.Point(201, 402);
            this.SunsetDataLabel.Name = "SunsetDataLabel";
            this.SunsetDataLabel.Size = new System.Drawing.Size(69, 32);
            this.SunsetDataLabel.TabIndex = 8;
            this.SunsetDataLabel.Text = "N/A";
            this.SunsetDataLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // SunsetLabel
            // 
            this.SunsetLabel.AutoSize = true;
            this.SunsetLabel.BackColor = System.Drawing.Color.Transparent;
            this.SunsetLabel.Font = new System.Drawing.Font("Ravie", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SunsetLabel.ForeColor = System.Drawing.Color.Coral;
            this.SunsetLabel.Location = new System.Drawing.Point(64, 402);
            this.SunsetLabel.Name = "SunsetLabel";
            this.SunsetLabel.Size = new System.Drawing.Size(131, 32);
            this.SunsetLabel.TabIndex = 7;
            this.SunsetLabel.Text = "Sunset:";
            this.SunsetLabel.Click += new System.EventHandler(this.label2_Click);
            // 
            // WindSpeedDataLabel
            // 
            this.WindSpeedDataLabel.AutoSize = true;
            this.WindSpeedDataLabel.BackColor = System.Drawing.Color.Transparent;
            this.WindSpeedDataLabel.Font = new System.Drawing.Font("Ravie", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WindSpeedDataLabel.ForeColor = System.Drawing.Color.Coral;
            this.WindSpeedDataLabel.Location = new System.Drawing.Point(620, 234);
            this.WindSpeedDataLabel.Name = "WindSpeedDataLabel";
            this.WindSpeedDataLabel.Size = new System.Drawing.Size(69, 32);
            this.WindSpeedDataLabel.TabIndex = 10;
            this.WindSpeedDataLabel.Text = "N/A";
            // 
            // WindSpeedLabel
            // 
            this.WindSpeedLabel.AutoSize = true;
            this.WindSpeedLabel.BackColor = System.Drawing.Color.Transparent;
            this.WindSpeedLabel.Font = new System.Drawing.Font("Ravie", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WindSpeedLabel.ForeColor = System.Drawing.Color.Coral;
            this.WindSpeedLabel.Location = new System.Drawing.Point(415, 234);
            this.WindSpeedLabel.Name = "WindSpeedLabel";
            this.WindSpeedLabel.Size = new System.Drawing.Size(199, 32);
            this.WindSpeedLabel.TabIndex = 9;
            this.WindSpeedLabel.Text = "Wind Speed:";
            // 
            // PressureDataLabel
            // 
            this.PressureDataLabel.AutoSize = true;
            this.PressureDataLabel.BackColor = System.Drawing.Color.Transparent;
            this.PressureDataLabel.Font = new System.Drawing.Font("Ravie", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PressureDataLabel.ForeColor = System.Drawing.Color.Coral;
            this.PressureDataLabel.Location = new System.Drawing.Point(586, 284);
            this.PressureDataLabel.Name = "PressureDataLabel";
            this.PressureDataLabel.Size = new System.Drawing.Size(69, 32);
            this.PressureDataLabel.TabIndex = 12;
            this.PressureDataLabel.Text = "N/A";
            // 
            // PressureLabel
            // 
            this.PressureLabel.AutoSize = true;
            this.PressureLabel.BackColor = System.Drawing.Color.Transparent;
            this.PressureLabel.Font = new System.Drawing.Font("Ravie", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PressureLabel.ForeColor = System.Drawing.Color.Coral;
            this.PressureLabel.Location = new System.Drawing.Point(415, 284);
            this.PressureLabel.Name = "PressureLabel";
            this.PressureLabel.Size = new System.Drawing.Size(165, 32);
            this.PressureLabel.TabIndex = 11;
            this.PressureLabel.Text = "Pressure:";
            // 
            // PicIcon
            // 
            this.PicIcon.BackColor = System.Drawing.Color.Transparent;
            this.PicIcon.Location = new System.Drawing.Point(70, 145);
            this.PicIcon.Name = "PicIcon";
            this.PicIcon.Size = new System.Drawing.Size(92, 70);
            this.PicIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PicIcon.TabIndex = 13;
            this.PicIcon.TabStop = false;
            this.PicIcon.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // ForecastFLP
            // 
            this.ForecastFLP.AutoScroll = true;
            this.ForecastFLP.BackColor = System.Drawing.Color.Transparent;
            this.ForecastFLP.Location = new System.Drawing.Point(12, 437);
            this.ForecastFLP.Name = "ForecastFLP";
            this.ForecastFLP.Size = new System.Drawing.Size(883, 159);
            this.ForecastFLP.TabIndex = 14;
            this.ForecastFLP.WrapContents = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WeatherApp.Properties.Resources.Weather_BG__2_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(907, 631);
            this.Controls.Add(this.ForecastFLP);
            this.Controls.Add(this.PicIcon);
            this.Controls.Add(this.PressureDataLabel);
            this.Controls.Add(this.PressureLabel);
            this.Controls.Add(this.WindSpeedDataLabel);
            this.Controls.Add(this.WindSpeedLabel);
            this.Controls.Add(this.SunsetDataLabel);
            this.Controls.Add(this.SunsetLabel);
            this.Controls.Add(this.SunriseDataLabel);
            this.Controls.Add(this.SunriseLabel);
            this.Controls.Add(this.DetailsLabel);
            this.Controls.Add(this.CondtionLabel);
            this.Controls.Add(this.SearchBtn);
            this.Controls.Add(this.CityTextBox);
            this.Controls.Add(this.CityLabel);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.PicIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label CityLabel;
        private System.Windows.Forms.TextBox CityTextBox;
        private System.Windows.Forms.Button SearchBtn;
        private System.Windows.Forms.Label CondtionLabel;
        private System.Windows.Forms.Label DetailsLabel;
        private System.Windows.Forms.Label SunriseLabel;
        private System.Windows.Forms.Label SunriseDataLabel;
        private System.Windows.Forms.Label SunsetDataLabel;
        private System.Windows.Forms.Label SunsetLabel;
        private System.Windows.Forms.Label WindSpeedDataLabel;
        private System.Windows.Forms.Label WindSpeedLabel;
        private System.Windows.Forms.Label PressureDataLabel;
        private System.Windows.Forms.Label PressureLabel;
        private System.Windows.Forms.PictureBox PicIcon;
        private System.Windows.Forms.FlowLayoutPanel ForecastFLP;
    }
}

