using System;
using System.Collections;
using System.Windows.Forms;

namespace Task1_19003041_PROG6211
{
    public partial class WeatherForecaster : Form
    {
        public WeatherForecaster()
        {
            InitializeComponent();
        }

        private Weather vars = new Weather();
        private bool valuesGood = true;
        private ArrayList citiesSelected = new ArrayList();

        private void WeatherForecaster_Load(object sender, EventArgs e)
        {
            vars.populateArrayLists(); //Add Test Values
            populateCityComboBox(); //Populate Combo box with Test Values
            citiesSelected.Add("Cape Town"); //Test cities selected
            citiesSelected.Add("Johannesburg"); //Test cities selected
        }

        //
        //Capture section Code
        //
        private void submitButton_Click(object sender, EventArgs e)
        {
            //Check if any incorrect values have been copy pasted into capture boxes
            valuesGood = true;
            valueCheckText(cityBox.Text, 0);
            valueCheck(minTempBox.Text, 0);
            valueCheck(maxTempBox.Text, 0);
            valueCheck(precipBox.Text, 0);
            valueCheck(humidBox.Text, 0);
            valueCheck(windBox.Text, 0);
            if (valuesGood == true && cityBox.Text != "")
            {
                //Add values to relevant arrays if data is input correctly
                vars.addMinTemp(minTempBox.Text);
                vars.addMaxTemp(maxTempBox.Text);
                vars.addPrecipitation(precipBox.Text);
                vars.addHumidity(humidBox.Text);
                vars.addWindSpeed(windBox.Text);
                if (cityBox.Items.Contains(cityBox.Text))
                {
                    vars.addCityName(cityBox.Items[cityBox.Items.IndexOf(cityBox.Text)]);
                }
                else
                {
                    vars.addCityName(cityBox.Text);
                }
                vars.addWeatherDate(dateInputBox.Value);
                populateCityComboBox();
                reportTable.Rows.Clear();
                MessageBox.Show("Data Captured Successfully.");
            }
            else
            {
                MessageBox.Show("The data you have entered is incorrect. \nPlease make sure that: \n- No fields are empty.\n- There are no numbers in the city input field.\n- There are no letters in the in the number fields.");
            }
        }

        //Clear the values from the capture section
        private void ClearButton_Click(object sender, EventArgs e)
        {
            cityBox.Text = "";
            minTempBox.Text = "0";
            maxTempBox.Text = "0";
            precipBox.Text = "0";
            humidBox.Text = "0";
            windBox.Text = "0";
        }

        //Check numeric values are entered correctly
        private void valueCheck(string tempVar1, int tempOut1)
        {
            if ((int.TryParse(tempVar1, out tempOut1)) && valuesGood == true)
            {
            }
            else
            {
                valuesGood = false;
            }
        }

        //Check text values are entered correctly
        private void valueCheckText(string tempVar1, int tempOut1)
        {
            if ((int.TryParse(tempVar1, out tempOut1)) && valuesGood == true)
            {
                valuesGood = false;
            }
            else
            {
            }
        }

        /*
        Prevent incorrect intial input
        */

        //For city box
        private void CityBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("You may only enter alphabetical letters into this box.");
            }
        }

        //For min temp box
        private void MinTempBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '-')
            {
                e.Handled = true;
                MessageBox.Show("You may only enter a temperature into this box.");
            }
            if (e.KeyChar == '-')
            {
                if (minTempBox.Text.StartsWith("-"))
                {
                    e.Handled = true;
                }
            }
        }

        private void minTempBox_TextChanged(object sender, EventArgs e)
        {
            if (minTempBox.Text == "")
            {
                minTempBox.Text = "0";
            }
            if (minTempBox.Text.IndexOf("-") > 0)
            {
                minTempBox.Text = minTempBox.Text.Remove(minTempBox.Text.IndexOf("-"), 1);
                minTempBox.Text = "-" + minTempBox.Text;
            }
        }

        //For max temp box
        private void MaxTempBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '-')
            {
                e.Handled = true;
                MessageBox.Show("You may only enter a temperature into this box.");
            }
            if (e.KeyChar == '-')
            {
                if (maxTempBox.Text.StartsWith("-"))
                {
                    e.Handled = true;
                }
            }
        }

        private void maxTempBox_TextChanged(object sender, EventArgs e)
        {
            if (maxTempBox.Text == "")
            {
                maxTempBox.Text = "0";
            }
            if (maxTempBox.Text.IndexOf("-") > 0)
            {
                maxTempBox.Text = maxTempBox.Text.Remove(maxTempBox.Text.IndexOf("-"), 1);
                maxTempBox.Text = "-" + maxTempBox.Text;
            }
        }

        //For precipitation box
        private void PrecipBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("You may only enter a number into this box.");
            }
        }

        private void PrecipBox_TextChanged(object sender, EventArgs e)
        {
            if (precipBox.Text == "")
            {
                precipBox.Text = "0";
            }
            int successInt;
            if (int.TryParse(precipBox.Text, out successInt))
            {
                if (successInt > 100)
                {
                    precipBox.Text = "100";
                }
            }
        }

        //For humidity box
        private void HumidBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("You may only enter a number into this box.");
            }
        }

        private void humidBox_TextChanged(object sender, EventArgs e)
        {
            if (humidBox.Text == "")
            {
                humidBox.Text = "0";
            }
            int successInt;
            if (int.TryParse(humidBox.Text, out successInt))
            {
                if (successInt > 100)
                {
                    humidBox.Text = "100";
                }
            }
        }

        //For wind speed box
        private void WindBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("You may only enter a number into this box.");
            }
        }

        private void windBox_TextChanged(object sender, EventArgs e)
        {
            if (windBox.Text == "")
            {
                windBox.Text = "0";
            }
        }

        //
        //End of preventing intial incorrect input
        //

        //
        //Code for Report section
        //

        //Populate the report city selection combo box
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

        //Update selected cities
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

        //Button to clear cities selected
        private void clearCitiesSelected_Click(object sender, EventArgs e)
        {
            citiesSelected.Clear();
            cityReportBox.Text = "None";
        }

        //Update start date selected
        private void startDateBox_ValueChanged(object sender, EventArgs e)
        {
            datesSelected.Text = startDateBox.Value.ToString("yyyy/MM/dd") + " - " + endDateBox.Value.ToString("yyyy/MM/dd");
        }

        //Update end date selected
        private void endDateBox_ValueChanged(object sender, EventArgs e)
        {
            datesSelected.Text = startDateBox.Value.ToString("yyyy/MM/dd") + " - " + endDateBox.Value.ToString("yyyy/MM/dd");
        }

        //Initiate process to retrieve report results
        private void searchButton_Click(object sender, EventArgs e)
        {
            cityComboBox.Text = "Select City...";
            populateReportTable();
        }

        //Retrieve and compare the results for the weather report
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
                                    //Initiate values in the lowest and highest section
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
                                    //Update values if lowest and highest section not empty
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
                                //Populate the table with the report
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
                //Reset report and display error
                if (reportTable.Rows.Count == 0)
                {
                    lowestMinTemp.Text = "";
                    highestMinTemp.Text = "";
                    lowestMaxTemp.Text = "";
                    highestMaxTemp.Text = "";
                    lowestPrecip.Text = "";
                    highestPrecip.Text = "";
                    lowestHumid.Text = "";
                    highestHumid.Text = "";
                    lowestWind.Text = "";
                    highestWind.Text = "";
                    MessageBox.Show("No Results Found.");
                }
            }
            else
            {
                MessageBox.Show("You have not selected any cities. \nTo obtain results, please select one or more cities.");
            }
        }
    }
}