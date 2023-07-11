using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using faceofbasketball.Models;
using faceofbasketball.View;
using faceofbasketball.ViewModels;
using faceofbasketball.Views;
using Xamarin.Forms;

namespace faceofbasketball
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();

            BindingContext = new data();

            //Navigation.PushAsync(new loading());

        }


        private async void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            string title = ((TappedEventArgs)e).Parameter.ToString();

            await Navigation.PushModalAsync(new details(title));
        }
    }
}
