using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace Hello.Chapter15
{
    public partial class DaysBetweenDates : ContentPage
    {
        public DaysBetweenDates()
        {
            InitializeComponent();

            // Initialize.
            OnDateSelected(null, null);
        }

        void OnDateSelected(object sender, DateChangedEventArgs args)
        {
            int days = (toDatePicker.Date - fromDatePicker.Date).Days;
            resultLabel.Text = String.Format("{0} day{1} between dates",
            days, days == 1 ? "" : "s");
        }
    }
}
