using HelloWorld.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HelloWorld.Samples.Navigation
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ContactsPage : ContentPage
    {
        public ContactsPage()
        {
            InitializeComponent();

            var contacts = new List<Contact>
            {
                   new Contact { Name = "Mosh", ImageUrl="https://lorempixel.com/100/100/people/1", Status=""},
                   new Contact { Name = "Josh", ImageUrl="https://lorempixel.com/100/100/people/1", Status=""},
                   new Contact { Name = "Bob", ImageUrl="https://lorempixel.com/100/100/people/1", Status="Hey Let's Talk"}
            };
            listView.ItemsSource = contacts;
            
        }

        private async void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem == null)
                return;
            var contact = e.SelectedItem as Contact;
            await Navigation.PushAsync(new ContactDetailPage(contact));
            listView.SelectedItem = null;
        }
    }
}