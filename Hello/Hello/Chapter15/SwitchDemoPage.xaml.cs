using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace Hello.Chapter15
{
    public partial class SwitchDemoPage : ContentPage
    {
        public SwitchDemoPage()
        {
            InitializeComponent();
        }

        void OnItalicSwitchToggled(object sender, ToggledEventArgs args)
        {
            if (args.Value)
            {
                label.FontAttributes |= FontAttributes.Italic;
            }
            else
            {
                label.FontAttributes &= ~FontAttributes.Italic;
            }
        }
        void OnBoldSwitchToggled(object sender, ToggledEventArgs args)
        {
            if (args.Value)
            {
                label.FontAttributes |= FontAttributes.Bold;
            }
            else
            {
                label.FontAttributes &= ~FontAttributes.Bold;
            }
        }
    }
}
