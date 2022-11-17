using lab3_Appshell_TabBarPage.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace lab3_Appshell_TabBarPage.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class GamingLaptopPage : ContentPage
    {
        public int favouriteTapcount = 0;
        ObservableCollection<Product> Listproduct;
        public GamingLaptopPage()
        {
            InitializeComponent();
            Listproduct = new ObservableCollection<Product>
            {
                new Product {ProductImageUrl="Acer_Nitro_5_Eagle_AN515_57_54MV.jpg",ProductName="Acer Nitro 5",ProductRating=4, ProductPrice=1000000, ProductTypeId=1},
                new Product {ProductImageUrl="ASUS_TUF_A15_FA507RC_HN051W.jpg",ProductName="Asus TUF A15",ProductRating=4, ProductPrice=11200000, ProductTypeId=1},
            };
            CVProducts.ItemsSource = Listproduct;
        }


        private void ToolbarSearch_Clicked(object sender, EventArgs e)
        {

        }

        private async void CVProducts_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string previous = (e.PreviousSelection.FirstOrDefault() as Product)?.ProductName;
            string current = (e.CurrentSelection.FirstOrDefault() as Product)?.ProductName;
            await DisplayAlert("Message", "previous: " + previous + "\nCurrent: " + current, "OK");
        }

        private void ImgAddToWishlist_Tapped(object sender, EventArgs e)
        {
            favouriteTapcount++;
            Image img = (Image)sender;
            img.Source = favouriteTapcount % 2 == 0 ? "FavouriteBlackIcon.png" : (ImageSource)"FavouriteRedIcon.png";
        }
    }
}