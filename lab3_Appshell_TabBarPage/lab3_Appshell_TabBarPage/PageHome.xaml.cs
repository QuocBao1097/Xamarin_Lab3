using lab3_Appshell_TabBarPage.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace lab3_Appshell_TabBarPage
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PageHome : ContentPage
    {
        public int favouriteTapcount = 0;
        ObservableCollection<Product> Listproduct;
        public PageHome()
        {
            InitializeComponent();
            Listproduct = new ObservableCollection<Product>
            {
                new Product {ProductImageUrl="Acer_Nitro_5_Eagle_AN515_57_54MV.jpg",ProductName="Acer Nitro 5",ProductRating=4.7, ProductPrice=3000000},
                new Product {ProductImageUrl="Asus_Zenbook_14_OLED.jpg",ProductName="Asus Zenbook 14",ProductRating=3.2, ProductPrice=16000000},
                new Product {ProductImageUrl="ASUS_TUF_A15_FA507RC_HN051W.jpg",ProductName="Asus TUF A15",ProductRating=4, ProductPrice=11200000},
                new Product {ProductImageUrl="Dell_Inspiron_15_5515.jpg",ProductName="Dell Inspiron",ProductRating=4.5, ProductPrice=19000000},
                new Product {ProductImageUrl="iphone_13_Pro_Max.jpg",ProductName="Iphone 13 Pro Max",ProductRating=5, ProductPrice=22000000},
                new Product {ProductImageUrl="Lenovo_ThinkBook_14_G2.jpg",ProductName="Lenovo ThinkBook",ProductRating=1, ProductPrice=32000000},
                new Product {ProductImageUrl="Macbook_Pro_M2_2022.jpg",ProductName="Macbook Pro M2",ProductRating=4.1, ProductPrice=21000000},
                new Product {ProductImageUrl="Samsung_Galaxy_S22_Ultra.jpg",ProductName="Samsung Galaxy S22",ProductRating=3.8, ProductPrice=18500000},
                new Product {ProductImageUrl="https://cdn2.cellphones.com.vn/358x/media/catalog/product/u/s/usb-3-0-sandisk-cz73-ultra-flair-32gb-1_1.jpeg",ProductName="USB SanDisk TH23",ProductRating=3, ProductPrice=50000},
                new Product {ProductImageUrl="https://cdn.tgdd.vn/Products/Images/75/218168/usb-otg-31-32gb-sandisk-sdddc3-den-230822-040743-600x600.jpg",ProductName="USB SanDisk",ProductRating=3, ProductPrice=100000},
                new Product {ProductImageUrl="https://vietadsgroup.vn/Uploads/files/usb-la-gi.jpg",ProductName="USB Kingston",ProductRating=3, ProductPrice=87000},
                new Product {ProductImageUrl="https://vietadsgroup.vn/Uploads/files/usb-la-gi.jpg",ProductName="USB Kingston",ProductRating=3, ProductPrice=87000},
                new Product {ProductImageUrl="https://m.media-amazon.com/images/I/61FFlMkOxhL.jpg",ProductName="BTH03 Kids HeadPhone",ProductRating=3, ProductPrice=1000000},
                new Product {ProductImageUrl="https://antien.vn/uploads/product/Bose-Headphone-700_1589538843.jpg",ProductName="BOSE HeadPhone 700",ProductRating=3, ProductPrice=890000},
                new Product {ProductImageUrl="https://i5.walmartimages.com/asr/c732d5be-1d99-4727-8732-be1ca8613067_1.c0269b03bc43e926a9696cf34af9e5ec.jpeg",ProductName="W1 HeadPhone",ProductRating=3, ProductPrice=770000},
                new Product {ProductImageUrl="https://images.philips.com/is/image/PhilipsConsumer/TAKH402PK_00-IMS-en_SG?$jpglarge$&wid=1250",ProductName="HeadPhone TAKH402PK",ProductRating=4.5, ProductPrice=786000},
                new Product {ProductImageUrl="Xiaomi_11T_Pro_5G.jpg",ProductName="Xiaomi",ProductRating=4, ProductPrice=10000000, ProductTypeId = 2},
                new Product {ProductImageUrl="Acer_Nitro_5_Eagle_AN515_57_54MV.jpg",ProductName="Acer Nitro 5",ProductRating=2.4, ProductPrice=10000000},
                new Product {ProductImageUrl="OPPO_Find_X5_Pro_5G.jpg",ProductName="OPPO X5 Pro",ProductRating=3.5, ProductPrice=11232433}
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