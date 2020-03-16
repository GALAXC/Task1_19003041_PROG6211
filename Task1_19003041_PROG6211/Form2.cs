using System;
using System.Collections;
using System.Windows.Forms;

namespace Task1_19003041_PROG6211
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private Weather vars = new Weather();
        private ArrayList citiesSelected = new ArrayList();

        private void populateCityComboBox()
        {
            cityComboBox.Items.Clear();
            for (int i = 0; i < (vars.getCityNameCount()); i++)
            {
                if (cityComboBox.Items.Contains(vars.getCityName(i)))
                {
                }
                else
                {
                    cityComboBox.Items.Add(vars.getCityName(i));
                }
            }
        }

        private void cityComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (citiesSelected.Contains(cityComboBox.SelectedItem))
            {
                citiesSelected.Remove(cityComboBox.SelectedItem);
            }
            else
            {
                citiesSelected.Add(cityComboBox.SelectedItem);
            }
            cityReportBox.Clear();
            for (int j = 0; j < citiesSelected.Count; j++)
            {
                if (j == 0)
                {
                    cityReportBox.Text += citiesSelected[j];
                }
                else
                {
                    cityReportBox.Text += ", " + citiesSelected[j];
                }
            }
            if (cityReportBox.Text == "")
            {
                cityReportBox.Text = "None";
            }
        }

        private void startDateBox_ValueChanged(object sender, EventArgs e)
        {
            datesSelected.Text = startDateBox.Value.ToString("dd/MM/yyyy") + " - " + endDateBox.Value.ToString("dd/MM/yyyy");
        }

        private void endDateBox_ValueChanged(object sender, EventArgs e)
        {
            datesSelected.Text = startDateBox.Value.ToString("dd/MM/yyyy") + " - " + endDateBox.Value.ToString("dd/MM/yyyy");
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            cityComboBox.Text = "Select City...";
            populateReportTable();
        }

        private void populateReportTable()
        {
            int lowMinTemp = 0;
            int highMinTemp = 0;
            int lowMaxTemp = 0;
            int highMaxTemp = 0;
            int lowPrecip = 0;
            int highPrecip = 0;
            int lowHumid = 0;
            int highHumid = 0;
            int lowSpeed = 0;
            int highSpeed = 0;
            reportTable.Rows.Clear();
            if (citiesSelected.Count != 0)
            {
                for (int i = 0; i < citiesSelected.Count; i++)
                {
                    for (int j = 0; j < vars.getCityNameCount(); j++)
                    {
                        if (vars.getCityName(j) == Convert.ToString(citiesSelected[i]))
                        {
                            if (vars.getWeatherDate(j) >= startDateBox.Value && vars.getWeatherDate(j) <= endDateBox.Value)
                            {
                                if (reportTable.Rows.Count == 0)
                                {
                                    lowMinTemp = Convert.ToInt32(vars.getMinTemp(j));
                                    highMinTemp = Convert.ToInt32(vars.getMinTemp(j));
                                    lowMaxTemp = Convert.ToInt32(vars.getMaxTemp(j));
                                    highMaxTemp = Convert.ToInt32(vars.getMaxTemp(j));
                                    lowPrecip = Convert.ToInt32(vars.getPrecipitation(j));
                                    highPrecip = Convert.ToInt32(vars.getPrecipitation(j));
                                    lowHumid = Convert.ToInt32(vars.getHumidity(j));
                                    highHumid = Convert.ToInt32(vars.getHumidity(j));
                                    lowSpeed = Convert.ToInt32(vars.getWindSpeed(j));
                                    highSpeed = Convert.ToInt32(vars.getWindSpeed(j));
                                }
                                else
                                {
                                    if (Convert.ToInt32(vars.getMinTemp(j)) < lowMinTemp)
                                    {
                                        lowMinTemp = Convert.ToInt32(vars.getMinTemp(j));
                                    }

                                    if (Convert.ToInt32(vars.getMinTemp(j)) > highMinTemp)
                                    {
                                        highMinTemp = Convert.ToInt32(vars.getMinTemp(j));
                                    }

                                    if (Convert.ToInt32(vars.getMaxTemp(j)) < lowMaxTemp)
                                    {
                                        lowMaxTemp = Convert.ToInt32(vars.getMaxTemp(j));
                                    }

                                    if (Convert.ToInt32(vars.getMaxTemp(j)) > highMaxTemp)
                                    {
                                        highMaxTemp = Convert.ToInt32(vars.getMaxTemp(j));
                                    }

                                    if (Convert.ToInt32(vars.getPrecipitation(j)) < lowPrecip)
                                    {
                                        lowPrecip = Convert.ToInt32(vars.getPrecipitation(j));
                                    }

                                    if (Convert.ToInt32(vars.getPrecipitation(j)) > highPrecip)
                                    {
                                        highPrecip = Convert.ToInt32(vars.getPrecipitation(j));
                                    }

                                    if (Convert.ToInt32(vars.getHumidity(j)) < lowHumid)
                                    {
                                        lowHumid = Convert.ToInt32(vars.getHumidity(j));
                                    }

                                    if (Convert.ToInt32(vars.getHumidity(j)) > highHumid)
                                    {
                                        highHumid = Convert.ToInt32(vars.getHumidity(j));
                                    }

                                    if (Convert.ToInt32(vars.getWindSpeed(j)) < lowSpeed)
                                    {
                                        lowSpeed = Convert.ToInt32(vars.getWindSpeed(j));
                                    }

                                    if (Convert.ToInt32(vars.getWindSpeed(j)) > highSpeed)
                                    {
                                        highSpeed = Convert.ToInt32(vars.getWindSpeed(j));
                                    }
                                }
                                reportTable.Rows.Add(vars.getCityName(j), vars.getWeatherDate(j).ToShortDateString(), vars.getMinTemp(j), vars.getMaxTemp(j), vars.getPrecipitation(j), vars.getHumidity(j), vars.getWindSpeed(j));

                                lowestMinTemp.Text = Convert.ToString(lowMinTemp) + " °C";
                                highestMinTemp.Text = Convert.ToString(highMinTemp) + " °C";

                                lowestMaxTemp.Text = Convert.ToString(lowMaxTemp) + " °C";
                                highestMaxTemp.Text = Convert.ToString(highMaxTemp) + " °C";

                                lowestPrecip.Text = Convert.ToString(lowPrecip) + " %";
                                highestPrecip.Text = Convert.ToString(highPrecip) + " %";

                                lowestHumid.Text = Convert.ToString(lowHumid) + " %";
                                highestHumid.Text = Convert.ToString(highHumid) + " %";

                                lowestWind.Text = Convert.ToString(lowSpeed) + " km/h";
                                highestWind.Text = Convert.ToString(highSpeed) + " km/h";
                            }
                        }
                    }
                }
                if (reportTable.Rows.Count == 0)
                {
                    MessageBox.Show("No Results Found.");
                }
            }
            else
            {
                MessageBox.Show("You have not selected any cities. \nTo obtain results, please select one or more cities.");
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            populateCityComboBox();
        }
    }
}