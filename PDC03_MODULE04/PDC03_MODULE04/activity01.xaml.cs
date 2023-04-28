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
    public partial class activity01 : ContentPage
    {
        public activity01()
        {
            InitializeComponent();
        }
        private async void OpenActivity01(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new activity01());
        }

        private async void OpenActivity02(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new activity02());
        }
    }
}