using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace Hello.Chapter14AbsolouteLayouts
{
    public partial class BounchingText : ContentPage
    {

        const double period = 2000; // in milliseconds
        readonly DateTime startTime = DateTime.Now;

        public BounchingText()
        {
            InitializeComponent();
            Device.StartTimer(TimeSpan.FromMilliseconds(15), OnTimerTick);
        }


        bool OnTimerTick()
        {
            TimeSpan elapsed = DateTime.Now - startTime;
            double t = (elapsed.TotalMilliseconds % period) / period; // 0 to 1
            t = 2 * (t < 0.5 ? t : 1 - t); // 0 to 1 to 0
            AbsoluteLayout.SetLayoutBounds(label1,
            new Rectangle(t, 0.5, AbsoluteLayout.AutoSize, AbsoluteLayout.AutoSize));
            AbsoluteLayout.SetLayoutBounds(label2,
            new Rectangle(0.5, 1 - t, AbsoluteLayout.AutoSize, AbsoluteLayout.AutoSize));
            return true;
        }
    }
}
