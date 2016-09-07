using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;

using Xamarin.Forms;

namespace Hello.Chapter13BitMaps
{
    public class ResourceBitMapCode : ContentPage
    {
        public ResourceBitMapCode()
        {
            Content = new Image
            {
                Source = ImageSource.FromResource(
                    "Hello.Chapter13BitMaps.Images.join.png"),
                VerticalOptions = LayoutOptions.Center,
                HorizontalOptions = LayoutOptions.Center
            };
        }
    }
}
