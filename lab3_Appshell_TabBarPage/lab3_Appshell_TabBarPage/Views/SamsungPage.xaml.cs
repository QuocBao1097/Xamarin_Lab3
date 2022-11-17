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
    public partial class SamsungPage : ContentPage
    {
        public int favouriteTapcount = 0;
        ObservableCollection<Product> Listproduct;
        public SamsungPage()
        {
            InitializeComponent();
            Listproduct = new ObservableCollection<Product>
            {
                new Product {ProductImageUrl="Samsung_Galaxy_S22_Ultra.jpg",ProductName="Samsung Galaxy S22",ProductRating=3, ProductPrice=10000000, ProductTypeId = 2},
                new Product {ProductImageUrl="Samsung_Galaxy_S22_Ultra.jpg",ProductName="Samsung Galaxy Note 8",ProductRating=3, ProductPrice=10000000, ProductTypeId = 2},
                new Product {ProductImageUrl="Samsung_Galaxy_S22_Ultra.jpg",ProductName="Samsung Galaxy Note 8",ProductRating=3, ProductPrice=10000000, ProductTypeId = 2},
                new Product {ProductImageUrl="Samsung_Galaxy_S22_Ultra.jpg",ProductName="Samsung Galaxy Note 8",ProductRating=3, ProductPrice=10000000, ProductTypeId = 2},
                new Product {ProductImageUrl="Samsung_Galaxy_S22_Ultra.jpg",ProductName="Samsung Galaxy A8",ProductRating=3, ProductPrice=10000000, ProductTypeId = 2}
            };
            CVSamsungPhones.ItemsSource = Listproduct;
        }

        //DELETE
        private async void SwipeItem_Invoked(object sender, EventArgs e)
        {
            bool answer = await DisplayAlert("Warning", "Do you really want delete it?", "YES", "NO");

            if (answer)
            {
                SwipeItem swipeItem = (SwipeItem)sender;
                Product product = swipeItem.CommandParameter as Product;
                _ = Listproduct.Remove(product);
            }
        }

        //Buy Now
        private void SwipeItem_Invoked_1(object sender, EventArgs e)
        {
            DisplayAlert("Thông báo", "Bạn đã mua sản phẩm này?", "Hủy");
        }

        private void RVISamsungPhones_Refreshing(object sender, EventArgs e)
        {
            CVSamsungPhones.ItemsSource = null;
            CVSamsungPhones.ItemsSource = Listproduct;
            RVSamsungPhones.IsRefreshing = false;
        }
        private void ImgAddToWishlist_Tapped(object sender, EventArgs e)
        {
            favouriteTapcount++;
            Image img = (Image)sender;
            img.Source = favouriteTapcount % 2 == 0 ? "FavouriteBlackIcon.png" : (ImageSource)"FavouriteRedIcon.png";
        }
        private void ToolbarSearch_Clicked(object sender, EventArgs e)
        {

        }
    }

}