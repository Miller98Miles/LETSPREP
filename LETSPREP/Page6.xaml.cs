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
    public partial class Page6 : ContentPage
    {
        public Page6()
        {
            InitializeComponent();
        }

        private async void Button_Clicked6(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Page7(), true);
        }

        private async void Button_Clicked7(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Page8(), true);
        }
    }
}