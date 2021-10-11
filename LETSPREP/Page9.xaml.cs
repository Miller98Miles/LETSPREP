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
    public partial class Page9 : ContentPage
    {
        public Page9()
        {
            InitializeComponent();
        }

        private async void Button_Clicked9(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Page10(), true);
        }
    }
}