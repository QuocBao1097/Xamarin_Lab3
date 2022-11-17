using lab3_Appshell_flyoutPage.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace lab3_Appshell_flyoutPage.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MacbookLaptopPage : ContentPage
    {
        public int favouriteTapcount = 0;
        ObservableCollection<Product> Listproduct;
        public MacbookLaptopPage()
        {
            InitializeComponent();
            Listproduct = new ObservableCollection<Product>
            {
                new Product {ProductImageUrl="Macbook_Pro_M2_2022.jpg",ProductName="Macbook Pro M2",ProductRating=4, ProductPrice=10000000, ProductTypeId = 1},

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