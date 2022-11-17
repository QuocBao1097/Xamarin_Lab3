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
    public partial class UltrabookLaptopPage : ContentPage
    {
        public int favouriteTapcount = 0;
        ObservableCollection<Product> Listproduct;
        public UltrabookLaptopPage()
        {
            InitializeComponent();
            Listproduct = new ObservableCollection<Product>
            {
                new Product {ProductImageUrl="Asus_Zenbook_14_OLED.jpg",ProductName="Asus Zenbook 14",ProductRating=4, ProductPrice=10000000, ProductTypeId=1},
                new Product {ProductImageUrl="Dell_Inspiron_15_5515.jpg",ProductName="Dell Inspiron",ProductRating=4.5, ProductPrice=10000000, ProductTypeId=1},
                new Product {ProductImageUrl="Lenovo_ThinkBook_14_G2.jpg",ProductName="Lenovo ThinkBook",ProductRating=1, ProductPrice=10000000, ProductTypeId = 1},
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