﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace Hello.XAML
{
    public partial class ColourView : ContentView
    {

        string colorName;
        ColorTypeConverter colorTypeConv = new ColorTypeConverter();

        public ColourView()
        {
            InitializeComponent();
        }

        public string ColorName
        {
            set
            {
                // Set the name.
                colorName = value;
                colorNameLabel.Text = value;
                // Get the actual Color and set the other views.
                Color color = (Color)colorTypeConv.ConvertFrom(colorName);
                boxView.Color = color;
                colorValueLabel.Text = String.Format("{0:X2}-{1:X2}-{2:X2}",
                (int)(255 * color.R),
               (int)(255 * color.G),
                (int)(255 * color.B));
            }
            get
            {
                return colorName;
            }
        }
    }
}
