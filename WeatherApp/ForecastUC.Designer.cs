namespace WeatherApp
{
    partial class ForecastUC
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.DateAndTimeLabel = new System.Windows.Forms.Label();
            this.WeatherCondtionLabel = new System.Windows.Forms.Label();
            this.DescriptionWeatherLabel = new System.Windows.Forms.Label();
            this.PicWeatherIcon = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PicWeatherIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // DateAndTimeLabel
            // 
            this.DateAndTimeLabel.AutoSize = true;
            this.DateAndTimeLabel.Font = new System.Drawing.Font("Ravie", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateAndTimeLabel.Location = new System.Drawing.Point(106, 3);
            this.DateAndTimeLabel.Name = "DateAndTimeLabel";
            this.DateAndTimeLabel.Size = new System.Drawing.Size(51, 22);
            this.DateAndTimeLabel.TabIndex = 1;
            this.DateAndTimeLabel.Text = "N/A";
            this.DateAndTimeLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // WeatherCondtionLabel
            // 
            this.WeatherCondtionLabel.AutoSize = true;
            this.WeatherCondtionLabel.Font = new System.Drawing.Font("Ravie", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WeatherCondtionLabel.Location = new System.Drawing.Point(106, 38);
            this.WeatherCondtionLabel.Name = "WeatherCondtionLabel";
            this.WeatherCondtionLabel.Size = new System.Drawing.Size(51, 22);
            this.WeatherCondtionLabel.TabIndex = 2;
            this.WeatherCondtionLabel.Text = "N/A";
            this.WeatherCondtionLabel.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // DescriptionWeatherLabel
            // 
            this.DescriptionWeatherLabel.AutoSize = true;
            this.DescriptionWeatherLabel.Font = new System.Drawing.Font("Ravie", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DescriptionWeatherLabel.Location = new System.Drawing.Point(106, 70);
            this.DescriptionWeatherLabel.Name = "DescriptionWeatherLabel";
            this.DescriptionWeatherLabel.Size = new System.Drawing.Size(51, 22);
            this.DescriptionWeatherLabel.TabIndex = 3;
            this.DescriptionWeatherLabel.Text = "N/A";
            // 
            // PicWeatherIcon
            // 
            this.PicWeatherIcon.Location = new System.Drawing.Point(3, 3);
            this.PicWeatherIcon.Name = "PicWeatherIcon";
            this.PicWeatherIcon.Size = new System.Drawing.Size(97, 89);
            this.PicWeatherIcon.TabIndex = 0;
            this.PicWeatherIcon.TabStop = false;
            this.PicWeatherIcon.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // ForecastUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.DescriptionWeatherLabel);
            this.Controls.Add(this.WeatherCondtionLabel);
            this.Controls.Add(this.DateAndTimeLabel);
            this.Controls.Add(this.PicWeatherIcon);
            this.Name = "ForecastUC";
            this.Size = new System.Drawing.Size(508, 95);
            this.Load += new System.EventHandler(this.ForecastUC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PicWeatherIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.ComponentModel.BackgroundWorker backgroundWorker1;
        public System.Windows.Forms.PictureBox PicWeatherIcon;
        public System.Windows.Forms.Label DateAndTimeLabel;
        public System.Windows.Forms.Label WeatherCondtionLabel;
        public System.Windows.Forms.Label DescriptionWeatherLabel;
    }
}
