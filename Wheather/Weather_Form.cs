using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using Newtonsoft.Json;//installed package from nuget
using System.Runtime;//for internet connection
using System.Runtime.InteropServices;


namespace Wheather
{
   
    

    public partial class Weather_Form : Form
    {
        [DllImport("wininet.dll")]
        private extern static bool InternetGetConnectedState(out int Description, int ReservedValue);
        //for checking internet connection
        string APIkey = "92c0cde539bb34747d8831fbb67b8439";
        public Weather_Form()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)

        {
            if (TBcity.Text == "")
            {
                MessageBox.Show("Please Enter the City Name....", "Blank Text Box", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else {
                getWeather();
                getWeather2();
                TBcity.Focus();
            }
            
        }
        double lat, lon;
       void getWeather()
        {
            try {
            using (WebClient web=new WebClient())
            {
                string url = string.Format("https://api.openweathermap.org/data/2.5/weather?q={0}&appid={1}",TBcity.Text,APIkey);
                var json = web.DownloadString(url);
                Wheather_info.root Info = JsonConvert.DeserializeObject<Wheather_info.root>(json);
                picIcon.ImageLocation = "https://openweathermap.org/img/w/"+Info.weather[0].icon+ ".png";
                labCondition.Text = Info.weather[0].main;
                labDetails.Text = Info.weather[0].description;
                labsunset.Text = convertDatetime(Info.sys.sunset).ToShortTimeString();
                labsunsine.Text = convertDatetime(Info.sys.sunrise).ToShortTimeString();

                labWindspeed.Text = Info.wind.speed.ToString();
                labPressure.Text = Info.main.pressure.ToString();
                    //Hectopascal  in HPA
                    labCountry.Text = Info.sys.country;
                    labCity.Text=Info.name;
                //lbtemp.Text = Info.main.temp.ToString();
                lbtemp.Text = keltotemp(Info.main.temp).ToString()+ "°C";
                lat = Info.coord.lat;
                lon = Info.coord.lon;
                
            }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An Error is " + ex.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        DateTime convertDatetime(long sec)
        {
            DateTime dateTime = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc).ToLocalTime();
            dateTime = dateTime.AddSeconds(sec).ToLocalTime();
            return dateTime;
            //better explaintion at https://currentmillis.com/
        }
        double keltotemp(double kel)
        {
            double cel = (kel - 273.15);
            return cel;
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            All_City_List all_City_List = new All_City_List();
            var sourse = new AutoCompleteStringCollection();
            var source =all_City_List.City_List();
            // var sourse=  all_City_List.City_List();
            TBcity.AutoCompleteCustomSource.AddRange(source);//= sourse  ;
            //
            int Desc;
            if(InternetGetConnectedState(out Desc, 0))
            {
                NetStatbtn1.Visible = true;
            }
            else if(InternetGetConnectedState(out Desc, 0)==false)
            {
                NetStatbtn1.Visible = false;
                NetStatbtn2.Location = NetStatbtn1.Location;
                NetStatbtn2.Visible = true;
            }


        }

        private void NetStatbtn2_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            InitializeComponent();
            this.Refresh();
        }

        private void NetStatbtn1_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            InitializeComponent();
        }

        void getWeather2()
        {
            try { 
            using (WebClient web = new WebClient())
            {
                string API2= "18dede3a5891aa7f0c4f991203e451c0";
                string url = string.Format("https://api.openweathermap.org/data/2.5/onecall?lat={0}&lon={1}&exclude=current,minutely,hourly,alerts&appid={2}", lat,lon,API2 );
                var json = web.DownloadString(url);
                Weatherforecast.ForecastInfo forecastInfo = JsonConvert.DeserializeObject<Weatherforecast.ForecastInfo>(json);
                ForeCastUC FUC;
                for (int i = 0; i < 8; i++)
                {
                    FUC = new ForeCastUC();
                    FUC.picWeatherIcon.ImageLocation = "https://openweathermap.org/img/w/" + forecastInfo.daily[i].weather[0].icon + ".png";
                    FUC.labMainWeather.Text = forecastInfo.daily[i].weather[0].main;
                    FUC.labWeatherDesc.Text = forecastInfo.daily[i].weather[0].description;
                    FUC.label1.Text = convertDatetime(forecastInfo.daily[i].dt).DayOfWeek.ToString();
                    FLP.Controls.Add(FUC);
                }

                //picIcon.ImageLocation = "https://openweathermap.org/img/w/" + forecastInfo.weather[0].icon + ".png";
               
            }
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex.Message);
            }
        }
    }
}
