﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace PDC03Module3
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        private async void Activity01(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Activity1());   
        }
        private async void Activity02(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Activity2());
        }
        private async void Activity03(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Activity3());
        }
        private async void Activity04(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Activity4());
        }
    }
}
