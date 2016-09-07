using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;

using Xamarin.Forms;

namespace Hello.Chapter13BitMaps
{
    public class WebBitMapCode : ContentPage
    {
        public WebBitMapCode()
        {
            string uri = "https://developer.xamarin.com/demo/IMG_1415.JPG?width=25";
            Content = new Image
            {
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Center,
                Source = ImageSource.FromUri(new Uri(uri))
            };

        }
    }
}
