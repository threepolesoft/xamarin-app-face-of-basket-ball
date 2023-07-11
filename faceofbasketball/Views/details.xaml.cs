using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using faceofbasketball.Models;
using faceofbasketball.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using faceofbasketball.Views;

namespace faceofbasketball.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]

    public partial class details : ContentPage
    {
        public Item Item { get; set; }

        public data data = new data();

        public details(string title)
        {

            InitializeComponent();

            Item = data.Items.Where(m => m.Title == title).ToList()[0];

            _title.Text = Item.Title;
            _img.Source = Item.Img;
            Position.Text = Item.Position;
            Shoots.Text = Item.Shoots;
            Born.Text = Item.Born;
            College.Text = Item.College;
            High_School.Text = Item.High_School;
            Draft.Text = Item.Draft;
            NBA_Debut.Text = Item.NBA_Debut;
            Career_Length.Text = Item.Career_Length;
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();
            
        }

    }
}