using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace hava_durumu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private const string city = "Denizli";

        private const string api = "fd570a57165cce171d28384d744f037e";
        private const string connected = "http://api.openweathermap.org/data/2.5/weather?q=" + city + "&mode=xml&units=metric&APPID=" + api;

        private void Form1_Load(object sender, EventArgs e)
        {
            XDocument weather = XDocument.Load(connected);

            var temperature = weather.Descendants("temperature").ElementAt(0).Attribute("value").Value;
            label_degree.Text = temperature.ToString() + "°";

            var status = weather.Descendants("clouds").ElementAt(0).Attribute("value").Value;
            var statusName = weather.Descendants("clouds").ElementAt(0).Attribute("name").Value;
            label_clouds.Text = status.ToString() + "%";

            if(statusName.Contains("clouds") == true)
            {
                picture_clouds.Visible = true;
                picture_sun.Visible = false;
            }
            else if(statusName.Contains("sun") == true)
            {
                picture_sun.Visible = true;
                picture_clouds.Visible = false;
            }

            var city = weather.Descendants("city").ElementAt(0).Attribute("name").Value;
            label_location.Text = city.ToString();
        }

        

        
    }
}
