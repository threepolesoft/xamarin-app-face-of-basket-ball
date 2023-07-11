using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace faceofbasketball.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class loading : ContentPage
	{
		public loading ()
		{
			InitializeComponent ();

             
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();

            await image.ScaleTo(1, 100);
            await image.ScaleTo(0.9, 100, Easing.Linear);
            await image.ScaleTo(1, 100, Easing.Linear);

            await image.ScaleTo(1, 100);
            await image.ScaleTo(0.9, 100, Easing.Linear);
            await image.ScaleTo(1, 100, Easing.Linear);

            await image.ScaleTo(1, 100);
            await image.ScaleTo(0.9, 100, Easing.Linear);
            await image.ScaleTo(1, 100, Easing.Linear);


            await image.TranslateTo(-100, 0, 100);    // Move image left
            await image.TranslateTo(-100, -100, 100); // Move image diagonally up and left
            await image.TranslateTo(100, 100, 200);   // Move image diagonally down and right
            await image.TranslateTo(0, 100, 100);     // Move image left
            await image.TranslateTo(0, 0, 100);       // Move image up

           //await Application.Current.MainPage.Navigation.PopAsync();

            /*await Task.WhenAny<bool>
            (
                image.ScaleTo(1, 2000),
                image.ScaleTo(0.9, 1500, Easing.Linear),
                image.ScaleTo(150, 1200, Easing.Linear)
            );*/
        }
    }
}