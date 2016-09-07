using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;

using Xamarin.Forms;

namespace Hello
{
    public class ButtonLambdasPage : ContentPage
    {

        // Number to manipulate.
        double number = 1;

        public ButtonLambdasPage()
        {
            IDictionary<string, object> properties = Application.Current.Properties;
            if (properties.ContainsKey("displayLabelText"))
            {
                bool aDouble = false;
                aDouble = Double.TryParse(properties["displayLabelText"].ToString(), out number);
                if (!aDouble)
                {
                    number = 1;
                }

            }

            // Create the Label for display.
            Label label = new Label
            {
                Text = number.ToString(),
                FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)),
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.CenterAndExpand
            };

            // Create the first Button and attach Clicked handler.
            Button timesButton = new Button
            {
                Text = "Double",
                FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Button)),
                HorizontalOptions = LayoutOptions.CenterAndExpand
            };
            timesButton.Clicked += (sender, args) =>
            {
                number *= 2;
                label.Text = number.ToString();
            };

            // Create the second Button and attach Clicked handler.
            Button divideButton = new Button
            {
                Text = "Half",
                FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Button)),
                HorizontalOptions = LayoutOptions.CenterAndExpand
            };
            divideButton.Clicked += (sender, args) =>
            {
                number /= 2;
                label.Text = number.ToString();
            };

            // Assemble the page.
            this.Content = new StackLayout
            {
                 Children =
                 {
                     label,
                     new StackLayout
                     {
                         Orientation = StackOrientation.Horizontal,
                         VerticalOptions = LayoutOptions.CenterAndExpand,
                         Children =
                        {
                            timesButton,
                            divideButton
                        }
                    }
                }
            };

            Application.Current.Properties["displayLabelText"] = number;
        }
    }
}
