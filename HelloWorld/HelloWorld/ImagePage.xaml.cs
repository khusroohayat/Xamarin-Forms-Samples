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
    public partial class ImagePage : ContentPage
    {
        public ImagePage()
        {
            InitializeComponent();
            //image.Source = ImageSource.FromResource("HelloWorld.Images.background.jpg");
            //var imageSource = ImageSource.FromResource("HelloWorld.Images.background.jpg"); // new UriImageSource { Uri = new Uri("http://lorempixel.com/1920/1080/sports/7") };
            //imageSource.CachingEnabled = false;
            //image.Source = imageSource;
        }
    }
}