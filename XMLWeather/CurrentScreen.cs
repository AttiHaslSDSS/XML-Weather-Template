using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace XMLWeather
{
    public partial class CurrentScreen : UserControl
    {
        public CurrentScreen()
        {
            InitializeComponent();
            DisplayCurrent();
        }

        public void DisplayCurrent()
        {
            minOutput.Text = Form1.Days[0].tempLow;
            maxOutput.Text = Form1.Days[0].tempHigh;
            Shmungus.Text = Form1.Days[0].precipitation;
            wSpeed.Text = Form1.Days[0].windSpeed;
            minOutput.Text = Form1.Days[0].tempLow;
            feelsLabel.Text = Form1.Days[0].tempHigh;
        }

        private void forecastLabel_Click(object sender, EventArgs e)
        {
            Form f = this.FindForm();
            f.Controls.Remove(this);

            ForecastScreen fs = new ForecastScreen();
            f.Controls.Add(fs);
        }

        private void CurrentScreen_Load(object sender, EventArgs e)
        {

        }

        private void feelsLabel_Click(object sender, EventArgs e)
        {

        }

        private void weatherBox_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void cityValue_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        public void updateButton_Click(object sender, EventArgs e)
        {
            Form1.city =  cityBox.Text;
            Form1.Days.Clear();
            Form1.ExtractForecast();
            Form1.ExtractCurrent();
            DisplayCurrent();
            Refresh();
        }
    }
}
