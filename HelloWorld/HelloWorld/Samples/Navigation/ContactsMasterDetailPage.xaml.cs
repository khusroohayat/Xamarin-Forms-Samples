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
    public partial class ContactsMasterDetailPage : MasterDetailPage
    {
        public ContactsMasterDetailPage()
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

        private void listView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var contact = e.SelectedItem as Contact;
            Detail = new NavigationPage(new ContactDetailPage(contact));
            IsPresented = false; //IsMasterPresented
        }
    }
}