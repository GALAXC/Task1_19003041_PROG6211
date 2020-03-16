using System;
using System.Collections;
using System.Windows.Forms;

namespace Task1_19003041_PROG6211
{
    public class Weather : Form
    {
        private ArrayList cityNames = new ArrayList();
        private ArrayList weatherDates = new ArrayList();
        private ArrayList minTemps = new ArrayList();
        private ArrayList maxTemps = new ArrayList();
        private ArrayList precips = new ArrayList();
        private ArrayList humidities = new ArrayList();
        private ArrayList windSpeeds = new ArrayList();

        public void addWeatherDate(object value)
        {
            weatherDates.Add(value);
        }

        public DateTime getWeatherDate(int value)
        {
            return Convert.ToDateTime(weatherDates[value]);
        }

        public void addMinTemp(object value)
        {
            minTemps.Add(value);
        }

        public string getMinTemp(int value)
        {
            return Convert.ToString(minTemps[value]);
        }

        public void addMaxTemp(object value)
        {
            maxTemps.Add(value);
        }

        public string getMaxTemp(int value)
        {
            return Convert.ToString(maxTemps[value]);
        }

        public void addPrecipitation(object value)
        {
            precips.Add(value);
        }

        public string getPrecipitation(int value)
        {
            return Convert.ToString(precips[value]);
        }

        public void addHumidity(object value)
        {
            humidities.Add(value);
        }

        public string getHumidity(int value)
        {
            return Convert.ToString(humidities[value]);
        }

        public void addWindSpeed(object value)
        {
            windSpeeds.Add(value);
        }

        public string getWindSpeed(int value)
        {
            return Convert.ToString(windSpeeds[value]);
        }

        public void addCityName(object value)
        {
            cityNames.Add(value);
        }

        public string getCityName(int value)
        {
            return Convert.ToString(cityNames[value]);
        }

        public int getCityNameCount()
        {
            return cityNames.Count;
        }

        public void populateArrayLists()
        {
            cityNames.Add("Cape Town");
            cityNames.Add("Cape Town");
            cityNames.Add("Johannesburg");
            cityNames.Add("Johannesburg");
            cityNames.Add("Durban");

            weatherDates.Add("2020/03/06 19:38:30");
            weatherDates.Add("2020/05/19 19:38:30");
            weatherDates.Add("2020/01/07 19:38:30");
            weatherDates.Add("2020/09/21 19:38:30");
            weatherDates.Add("2020/04/15 19:38:30");

            minTemps.Add(76);
            minTemps.Add(59);
            minTemps.Add(28);
            minTemps.Add(17);
            minTemps.Add(21);

            maxTemps.Add(96);
            maxTemps.Add(79);
            maxTemps.Add(48);
            maxTemps.Add(37);
            maxTemps.Add(67);

            precips.Add(12);
            precips.Add(14);
            precips.Add(16);
            precips.Add(19);
            precips.Add(24);

            humidities.Add(50);
            humidities.Add(60);
            humidities.Add(70);
            humidities.Add(80);
            humidities.Add(40);

            windSpeeds.Add(25);
            windSpeeds.Add(35);
            windSpeeds.Add(45);
            windSpeeds.Add(55);
            windSpeeds.Add(40);
        }
    }
}