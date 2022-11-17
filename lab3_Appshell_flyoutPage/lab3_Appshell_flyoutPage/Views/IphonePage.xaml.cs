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
    public partial class IphonePage : ContentPage
    {
        public int favouriteTapcount = 0;
        ObservableCollection<Product> Listproduct;
        public IphonePage()
        {
            InitializeComponent();
            Listproduct = new ObservableCollection<Product>
            {
                new Product {ProductImageUrl="iphone_13_Pro_Max.jpg",ProductName="Iphone 13 Pro Max",ProductRating=5, ProductPrice=10000000, ProductTypeId=2},
                new Product {ProductImageUrl="iphone_13_Pro_Max.jpg",ProductName="Iphone 13 Pro Max",ProductRating=5, ProductPrice=10000000, ProductTypeId=2},
                new Product {ProductImageUrl="iphone_13_Pro_Max.jpg",ProductName="Iphone 13 Pro Max",ProductRating=5, ProductPrice=10000000, ProductTypeId=2},
                new Product {ProductImageUrl="iphone_13_Pro_Max.jpg",ProductName="Iphone 13 Pro Max",ProductRating=5, ProductPrice=10000000, ProductTypeId=2},
                new Product {ProductImageUrl="iphone_13_Pro_Max.jpg",ProductName="Iphone 13 Pro Max",ProductRating=5, ProductPrice=10000000, ProductTypeId=2},
            };
            CVIphonePhones.ItemsSource = Listproduct;
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

        private void RVIphonePhones_Refreshing(object sender, EventArgs e)
        {
            CVIphonePhones.ItemsSource = null;
            CVIphonePhones.ItemsSource = Listproduct;
            RVIphonePhones.IsRefreshing = false;
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