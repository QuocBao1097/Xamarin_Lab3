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
    public partial class USBPage : ContentPage
    {
        public int favouriteTapcount = 0;
        ObservableCollection<Product> Listproduct;
        public USBPage()
        {
            InitializeComponent();
            Listproduct = new ObservableCollection<Product>
            {
                new Product {ProductImageUrl="https://cdn2.cellphones.com.vn/358x/media/catalog/product/u/s/usb-3-0-sandisk-cz73-ultra-flair-32gb-1_1.jpeg",ProductName="USB SanDisk TH23",ProductRating=3, ProductPrice=50000},
                new Product {ProductImageUrl="https://cdn.tgdd.vn/Products/Images/75/218168/usb-otg-31-32gb-sandisk-sdddc3-den-230822-040743-600x600.jpg",ProductName="USB SanDisk",ProductRating=3, ProductPrice=100000},
                new Product {ProductImageUrl="https://vietadsgroup.vn/Uploads/files/usb-la-gi.jpg",ProductName="USB Kingston",ProductRating=3, ProductPrice=87000},
                new Product {ProductImageUrl="https://vietadsgroup.vn/Uploads/files/usb-la-gi.jpg",ProductName="USB Kingston",ProductRating=3, ProductPrice=87000},
            };
            CVUSB.ItemsSource = Listproduct;
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
        private void ToolbarSearch_Clicked(object sender, EventArgs e)
        {

        }
        private void RVUSB_Refreshing(object sender, EventArgs e)
        {
            CVUSB.ItemsSource = null;
            CVUSB.ItemsSource = Listproduct;
            RVUSB.IsRefreshing = false;
        }
        private void ImgAddToWishlist_Tapped(object sender, EventArgs e)
        {
            favouriteTapcount++;
            Image img = (Image)sender;
            img.Source = favouriteTapcount % 2 == 0 ? "FavouriteBlackIcon.png" : (ImageSource)"FavouriteRedIcon.png";
        }
    }
}