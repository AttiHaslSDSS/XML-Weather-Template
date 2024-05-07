using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Xml;

namespace XMLWeather
{
    public partial class Form1 : Form
    {
        // TODO: create list to hold day objects
        public static List<Day> Days = new List<Day>();
        public static string city = ("Stratford,CA");
        public static int WeatherX;

        public Form1()
        {
            InitializeComponent();
            ExtractForecast();
            ExtractCurrent();

            
            // open weather screen for todays weather
            CurrentScreen cs = new CurrentScreen();
            this.Controls.Add(cs);
        }

        public static void ExtractForecast()
        {
           // XmlReader reader = XmlReader.Create("https://api.openweathermap.org/data/2.5/weather?q="+city+"&mode=xml&units=metric&appid=3f2e224b815c0ed45524322e145149f0");
            XmlReader reader = XmlReader.Create("http://api.openweathermap.org/data/2.5/forecast/daily?q="+city+"&mode=xml&units=metric&cnt=7&appid=3f2e224b815c0ed45524322e145149f0");
    
            while (reader.Read())
            {
                //Create a 'day' object
                Day dy = new Day();

                // Necessary Data
                //Date and Time
                reader.ReadToFollowing("time");
                dy.date = reader.GetAttribute("day");

                reader.ReadToFollowing("symbol");
                dy.condition = reader.GetAttribute("number");

                // Precipitation Chance
                reader.ReadToFollowing("precipitation");
                dy.precipitation = reader.GetAttribute("probability");

                // Wind Speed
                reader.ReadToFollowing("windSpeed");
                dy.windSpeed = reader.GetAttribute("name");

                //Temperature
                reader.ReadToFollowing("temperature");
                dy.tempLow = reader.GetAttribute("min");
                dy.tempHigh = reader.GetAttribute("max");

                // If number = xxx
                //int number = reader
                //reader.ReadToFollowing("number");

                //If your day object is not null, add it to the days list
                Days.Add(dy);
            }
        }

        public static void ExtractCurrent()
        {

            // current info is not included in forecast file so we need to use this file to get it

            // reader.ReadToFollowing("city");
            // int givencity = XmlReader.GetAttribute("name");
            //cityValue.text = givencity;
            
            // Change this text to determine the city location?
            //XmlReader reader = XmlReader.Create("http://api.openweathermap.org/data/2.5/weather?q=Stratford,CA&mode=xml&units=metric&appid=3f2e224b815c0ed45524322e145149f0");
            XmlReader reader = XmlReader.Create("https://api.openweathermap.org/data/2.5/weather?q="+city+"&mode=xml&units=metric&appid=3f2e224b815c0ed45524322e145149f0");
            //TODO: find the city and current temperature and add to appropriate item in days list
            reader.ReadToFollowing("city");
            Days[0].location = reader.GetAttribute("name");

            // Temperature
            reader.ReadToFollowing("temperature");
            Days[0].location = reader.GetAttribute("value");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
