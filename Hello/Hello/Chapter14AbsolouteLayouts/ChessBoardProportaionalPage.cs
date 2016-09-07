using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;

using Xamarin.Forms;

namespace Hello.Chapter14AbsolouteLayouts
{
    public class ChessBoardProportaionalPage : ContentPage
    {
        AbsoluteLayout absoluteLayout;
        public ChessBoardProportaionalPage()
        {
            absoluteLayout = new AbsoluteLayout
            {
                BackgroundColor = Color.FromRgb(240, 220, 130),
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Center
            };

            for (int row = 0; row < 8; row++)
            {
                for (int col = 0; col < 8; col++)
                {
                    // Skip every other square.
                    if (((row ^ col) & 1) == 0)
                        continue;

                    BoxView boxView = new BoxView
                    {
                        Color = Color.FromRgb(0, 64, 0)
                    };

                    Rectangle rect = new Rectangle(col / 7.0, // x
                                                    row / 7.0, // y
                                                    1 / 8.0, // width
                                                    1 / 8.0); // height

                    absoluteLayout.Children.Add(boxView, rect, AbsoluteLayoutFlags.All);
                }
            }

            ContentView contentView = new ContentView
            {
                Content = absoluteLayout
            };

            contentView.SizeChanged += OnContentViewSizeChanged;

            this.Padding = new Thickness(5, Device.OnPlatform(25, 5, 5), 5, 5);
            this.Content = contentView;
        }

        void OnContentViewSizeChanged(object sender, EventArgs args)
        {
            ContentView contentView = (ContentView)sender;
            double boardSize = Math.Min(contentView.Width, contentView.Height);
            absoluteLayout.WidthRequest = boardSize;
            absoluteLayout.HeightRequest = boardSize;
        }

    }
}

