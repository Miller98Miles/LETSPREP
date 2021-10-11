using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace LETSPREP
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page10 : ContentPage
    {
        public Page10()
        {
            InitializeComponent();
        }

        private async void Button_Clicked10(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MainPage(), true);
        }
    }
}