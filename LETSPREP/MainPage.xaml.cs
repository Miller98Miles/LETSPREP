﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace LETSPREP
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void Button_Clicked(object sender, EventArgs e) => await Navigation.PushAsync(new Page1(), true);
        private async void Button_Clicked2(object sender, EventArgs e) => await Navigation.PushAsync(new Page2(), true);

    }
}
