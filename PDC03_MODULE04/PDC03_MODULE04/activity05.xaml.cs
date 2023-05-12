using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PDC03_MODULE04
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class activity05 : ContentPage
    {
        List<Contacts> contacts;
        public activity05()
        {
            InitializeComponent();

            SetupData();
            listView.ItemsSource = contacts;
        }

        async void onItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if(listView.SelectedItem != null) 
            {
                var detailPage = new DetailPage();
                detailPage.BindingContext = e.SelectedItem as Contacts;
                listView.SelectedItem = null;
                await Navigation.PushModalAsync(detailPage);
            }
        }

        void SetupData()
        {
            contacts = new List<Contacts>();
            contacts.Add(new Contacts
            {
                Name = "Juan Dela Cruz",
                    Age=30,
                    Occupation="Analyst",
                    Country="Philippines"


            });


            contacts.Add(new Contacts
            {
                Name = "John Doe",
                Age = 40,
                Occupation = "Programmer",
                Country = "Philippines"


            });

            contacts.Add(new Contacts
            {
                Name = "Jane Doe",
                Age = 25,
                Occupation = "Tester",
                Country = "Philippines"


            });

            contacts.Add(new Contacts
            {
                Name = "John Smith",
                Age = 30,
                Occupation = "Analyst",
                Country = "Philippines"


            });
        }
    }
}