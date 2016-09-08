using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace Hello.Chapter15
{
    public partial class SetTimerPage : ContentPage
    {
        DateTime triggerTime;

        public SetTimerPage()
        {
            InitializeComponent();
        }

        bool OnTimerTick()
        {
            if (@switch.IsToggled && DateTime.Now >= triggerTime)
            {
                @switch.IsToggled = false;
                DisplayAlert("Timer Alert",
                "The '" + entry.Text + "' timer has elapsed",
                "OK");
            }
            return true;
        }
        void OnTimePickerPropertyChanged(object obj, PropertyChangedEventArgs args)
        {
            if (args.PropertyName == "Time")
            {
                SetTriggerTime();
            }
        }
        void OnSwitchToggled(object obj, ToggledEventArgs args)
        {
            SetTriggerTime();
        }
        void SetTriggerTime()
        {
            if (@switch.IsToggled)
            {
                triggerTime = DateTime.Today + timePicker.Time;
                if (triggerTime < DateTime.Now)
                {
                    triggerTime += TimeSpan.FromDays(1);
                }
            }
        }
    }
}
