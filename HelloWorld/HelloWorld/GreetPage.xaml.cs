using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HelloWorld
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class GreetPage : ContentPage
    {
        public GreetPage()
        {
            InitializeComponent();

            slider.Value = 0.5;

            //Padding = Device.OnPlatform(
            //  iOS: new Thickness(0, 20, 0, 0),
            //  Android: new Thickness(10, 20, 0, 0),
            //  WinPhone: new Thickness(30, 20, 0, 0)
            //  );

            //var x = new OnPlatform<Thickness>
            //{
            //    Android = new Thickness(0),
            //    iOS = new Thickness(0, 20, 0, 0)
            //};
            //Padding = x;
        }

        private void Slider_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            label.Text = String.Format("Value is {0:F2}", e.NewValue);
        }
    }
}