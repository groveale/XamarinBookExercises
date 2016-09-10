using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;

using Xamarin.Forms;

namespace Hello.Chapter16DataBinding
{
    public class BindingSourceCodePage : ContentPage
    {
        public BindingSourceCodePage()
        {
            Label label = new Label
            {
                Text = "Opacity Binding Demo",
                FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)),
                VerticalOptions = LayoutOptions.CenterAndExpand,
                HorizontalOptions = LayoutOptions.Center
            };

            Slider slider = new Slider
            {
                VerticalOptions = LayoutOptions.CenterAndExpand
            };

            // Define Binding object with source object and property.
            Binding binding = new Binding
            {
                Source = slider,
                Path = "Value"
            };

            // Bind the Opacity property of the Label to the source.
            label.SetBinding(Label.OpacityProperty, binding);

            // Construct the page.
            Padding = new Thickness(10, 0);
            Content = new StackLayout
            {
                Children = { label, slider }
            };


        }
    }
}
