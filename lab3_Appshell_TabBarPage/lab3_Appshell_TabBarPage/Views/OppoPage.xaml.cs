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
    public partial class OppoPage : ContentPage
    {
        public int favouriteTapcount = 0;
        ObservableCollection<Product> Listproduct;
        public OppoPage()
        {
            InitializeComponent();
            Listproduct = new ObservableCollection<Product>
            {
                 new Product {ProductImageUrl="OPPO_Find_X5_Pro_5G.jpg",ProductName="OPPO X5 Pro",ProductRating=3.5, ProductPrice=11232433, ProductTypeId = 2},
                 new Product {ProductImageUrl="OPPO_Find_X5_Pro_5G.jpg",ProductName="OPPO X3 Pro",ProductRating=3.5, ProductPrice=11232433, ProductTypeId = 2},
                 new Product {ProductImageUrl="OPPO_Find_X5_Pro_5G.jpg",ProductName="OPPO X2 Pro",ProductRating=3.5, ProductPrice=11232433, ProductTypeId = 2},
                 new Product {ProductImageUrl="OPPO_Find_X5_Pro_5G.jpg",ProductName="OPPO X2 Pro",ProductRating=3.5, ProductPrice=11232433, ProductTypeId = 2},
                 new Product {ProductImageUrl="OPPO_Find_X5_Pro_5G.jpg",ProductName="OPPO X2 Pro",ProductRating=3.5, ProductPrice=11232433, ProductTypeId = 2}

            };
            CVOppoPhones.ItemsSource = Listproduct;
        }

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

        private void SwipeItem_Invoked_1(object sender, EventArgs e)
        {
            DisplayAlert("Thông báo", "Bạn đã mua sản phẩm này?", "Hủy");
        }
        private void ImgAddToWishlist_Tapped(object sender, EventArgs e)
        {
            favouriteTapcount++;
            Image img = (Image)sender;
            img.Source = favouriteTapcount % 2 == 0 ? "FavouriteBlackIcon.png" : (ImageSource)"FavouriteRedIcon.png";
        }

        private void RVOppoPhones_Refreshing(object sender, EventArgs e)
        {
            CVOppoPhones.ItemsSource = null;
            CVOppoPhones.ItemsSource = Listproduct;
            RVOppoPhones.IsRefreshing = false;
        }
        private void ToolbarSearch_Clicked(object sender, EventArgs e)
        {

        }
    }
}