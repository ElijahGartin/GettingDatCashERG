using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using Microsoft.Phone.Controls;

namespace GettingDatCashERG
{
    public partial class MainPage : PhoneApplicationPage
    {
        double hours;
        double rate;
        double overtimerate;
        double overtimehours;
        double grosspay;
        string hoursString;
        string rateString;


        // Constructor
        public MainPage()
        {
            InitializeComponent();
        }

        private void moneyBtn_Click(object sender, RoutedEventArgs e)
        {
            //readin Hours
            hoursString = hoursTextBox.Text;
            hours = double.Parse(hoursString);

            //readin Wage Rate
            rateString = rateTextBox.Text;
            rate = double.Parse(rateString);
            //kalc overtime rate
            overtimerate = rate * 1.5;

            if (hours > 40)
            {
                overtimehours = hours - 40;
            }

            //GET MONEY!
            grosspay = (hours * rate) + (overtimehours * overtimerate);
            moneyTextBlock.Text = "Your Gross Pay = $" + grosspay;
        }
    }
}