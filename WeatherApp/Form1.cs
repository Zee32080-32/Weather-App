using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Newtonsoft.Json;
using System.Net;

namespace WeatherApp
{
    public partial class Form1 : Form
    {
        double longitude;
        double latitude;
        public Form1()
        {
            InitializeComponent();
        }

        string API_Key = "6e6f75b8b4c13b1b075bbc7fdf4ff8af";
        private void CondtionLabel_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            GetWeather();
            GetForecast();
        }

        void GetWeather()
        { 
            using (WebClient web = new WebClient()) 
            {
                string url = string.Format("https://api.openweathermap.org/data/2.5/weather?q={0}&appid={1}", CityTextBox.Text, API_Key);
                var json = web.DownloadString(url);

                WeatherInfo.root info = JsonConvert.DeserializeObject<WeatherInfo.root>(json);

                PicIcon.ImageLocation = "https://openweathermap.org/img/w/" + info.weather[0].icon + ".png";
                CondtionLabel.Text = info.weather[0].main;
                DetailsLabel.Text = info.weather[0].description;
                SunsetDataLabel.Text = ConvertDateTime(info.sys.sunset).ToShortTimeString();
                SunriseDataLabel.Text = ConvertDateTime(info.sys.sunrise).ToShortTimeString();

                WindSpeedDataLabel.Text = info.wind.speed.ToString();
                PressureDataLabel.Text = info.main.pressure.ToString();
                longitude = info.coord.lon;
                latitude = info.coord.lat;

            }
        }

        DateTime ConvertDateTime(long seconds)
        {
            DateTime day = new DateTime(1970, 1, 1, 0, 0, 0, 0, System.DateTimeKind.Utc).ToLocalTime();
            day = day.AddSeconds(seconds).ToLocalTime();

            return day;
        }

        void GetForecast()
        {
            using (WebClient web = new WebClient())
            {
                string url = string.Format("https://api.openweathermap.org/data/2.5/forecast?lat={0}&lon={1}&appid={2}", latitude, longitude, API_Key);

                var json = web.DownloadString(url);
                WeatherForecast.ForecastInfo forecastInfo = JsonConvert.DeserializeObject<WeatherForecast.ForecastInfo>(json);

                ForecastUC FUC; 
                for(int i = 0; i < 40; i++) 
                {
                    FUC = new ForecastUC();
                    FUC.PicWeatherIcon.ImageLocation = "https://openweathermap.org/img/w/" + forecastInfo.list[i].weather[0].icon + ".png";
                    FUC.WeatherCondtionLabel.Text = forecastInfo.list[i].weather[0].main;
                    FUC.DescriptionWeatherLabel.Text = forecastInfo.list[i].weather[0].description;
                    FUC.DateAndTimeLabel.Text = ConvertDateTime(forecastInfo.list[i].dt).DayOfWeek.ToString();

                    ForecastFLP.Controls.Add(FUC);
                }



            }
        }

    }
}
