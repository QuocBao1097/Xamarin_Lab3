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
    public partial class HeadPhonePage : ContentPage
    {
        public int favouriteTapcount = 0;
        ObservableCollection<Product> Listproduct;
        public HeadPhonePage()
        {
            InitializeComponent();
            Listproduct = new ObservableCollection<Product>
            {
                new Product {ProductImageUrl="https://m.media-amazon.com/images/I/61FFlMkOxhL.jpg",ProductName="BTH03 Kids HeadPhone",ProductRating=3, ProductPrice=1000000},
                new Product {ProductImageUrl="https://antien.vn/uploads/product/Bose-Headphone-700_1589538843.jpg",ProductName="BOSE HeadPhone 700",ProductRating=3, ProductPrice=890000},
                new Product {ProductImageUrl="https://i5.walmartimages.com/asr/c732d5be-1d99-4727-8732-be1ca8613067_1.c0269b03bc43e926a9696cf34af9e5ec.jpeg",ProductName="W1 HeadPhone",ProductRating=3, ProductPrice=770000},
                new Product {ProductImageUrl="https://images.philips.com/is/image/PhilipsConsumer/TAKH402PK_00-IMS-en_SG?$jpglarge$&wid=1250",ProductName="HeadPhone TAKH402PK",ProductRating=4.5, ProductPrice=786000},
            };
            CVHeadPhone.ItemsSource = Listproduct;
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

        private void RVHeadPhone_Refreshing(object sender, EventArgs e)
        {
            CVHeadPhone.ItemsSource = null;
            CVHeadPhone.ItemsSource = Listproduct;
            RVHeadPhone.IsRefreshing = false;
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