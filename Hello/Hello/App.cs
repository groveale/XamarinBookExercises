using Hello.XAML;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Hello.Chapter10;
using Hello.Chapter12Syles;
using Hello.Chapter13BitMaps;
using Hello.Chapter15;

using Xamarin.Forms;
using Hello.Chapter14AbsolouteLayouts;

namespace Hello
{
    public class App : Application
    {

        const string displayLabelText = "displayLabelText";
        public string DisplayLabelText { set; get; }

        public App()
        {
            //Chapter10.Toolkit.Toolkit.Init();

            // gThe root page of your application
            MainPage = new SetTimerPage();
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
            Properties[displayLabelText] = DisplayLabelText;
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
