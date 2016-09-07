﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Reflection.Emit;
using System.Text;

using Xamarin.Forms;

namespace Hello
{
    public class VerticleOptionsDemoPage : ContentPage
    {
        public VerticleOptionsDemoPage()
        {
            Color[] colors = { Color.Yellow, Color.Blue };
            int flipFlopper = 0;
            
            // Create Labels sorted by LayoutAlignment property.
            IEnumerable<Label> labels =
            from field in typeof(LayoutOptions).GetRuntimeFields()
            where field.IsPublic && field.IsStatic
            orderby ((LayoutOptions)field.GetValue(null)).Alignment
            select new Label
            {
                Text = "VerticalOptions = " + field.Name,
                VerticalOptions = (LayoutOptions)field.GetValue(null),
                HorizontalTextAlignment = TextAlignment.Center,
                FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Label)),
                TextColor = colors[flipFlopper],
                BackgroundColor = colors[flipFlopper = 1 - flipFlopper],
                VerticalTextAlignment = TextAlignment.Center
            };
            
            // Transfer to StackLayout.
            StackLayout stackLayout = new StackLayout();
            foreach (Label label in labels)
            {
                stackLayout.Children.Add(label);
            }
            Padding = new Thickness(0, Device.OnPlatform(20, 0, 0), 0, 0);
            Content = stackLayout;
        }
    }
}
