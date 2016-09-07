using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace Hello
{
    public partial class ScaryColorList : ContentPage
    {
        public ScaryColorList()
        {
            Padding = new OnPlatform<Thickness>
            {
                iOS = new Thickness(0, 20, 0, 0),
                Android = new Thickness(0),
                WinPhone = new Thickness(0, 20, 0, 0)
                
            };

            InitializeComponent();
        }
    }
}
