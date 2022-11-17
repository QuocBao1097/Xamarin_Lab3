using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace lab3
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PickerCountryPage : ContentPage
    {
        private List<Country> countries = new List<Country>();
        private List<City> cities = new List<City>();

        public PickerCountryPage()
        {
            InitializeComponent();
            CityInit();
            CountryCity();
            ListViewInit("");
        }

        private void CityInit()
        {
            //Viet nam
            cities.Add(new City { CityName = "Hà Nội", CityImg = "https://goeco.link/AjIHG", CountryName = "Việt Nam" });
            cities.Add(new City { CityName = "Tp.Hồ Chí Minh", CityImg = "https://goeco.link/rgkWR", CountryName = "Việt Nam" });
            cities.Add(new City { CityName = "Thái Bình", CityImg = "https://goeco.link/kLAay", CountryName = "Việt Nam" });

            // Nhat ban
            cities.Add(new City { CityName = "Tokyo", CityImg = "https://goeco.link/Zculg", CountryName = "Nhật Bản" });
            cities.Add(new City { CityName = "Osaka", CityImg = "https://goeco.link/sBBRe", CountryName = "Nhật Bản" });
            cities.Add(new City { CityName = "Yokohama", CityImg = "https://goeco.link/jpelC", CountryName = "Nhật Bản" });
            
            //Anh
            cities.Add(new City { CityName = "London", CityImg = "https://goeco.link/awnzS", CountryName = "Anh" });
            cities.Add(new City { CityName = "Leed", CityImg = "https://goeco.link/ssZab", CountryName = "Anh" });
            cities.Add(new City { CityName = "Manchester", CityImg = "https://goeco.link/XHJnL", CountryName = "Anh" });
            
            //Thai Lan
            cities.Add(new City { CityName = "Bangkok", CityImg = "https://goeco.link/kYfNB", CountryName = "Thái Lan" });
            cities.Add(new City { CityName = "Phuket", CityImg = "https://goeco.link/GyxtM", CountryName = "Thái Lan" });
            cities.Add(new City { CityName = "Pattaya", CityImg = "https://goeco.link/HRfJr", CountryName = "Thái Lan" });

        }

        private void CountryCity()
        {
            // Country List
            Country all = new Country("Tất cả");
            Country Vietnam = new Country("Việt Nam");
            Country Nhatban = new Country("Nhật Bản") ;
            Country Anh = new Country("Anh") ;
            Country Thailan = new Country("Thái Lan");

            foreach(City city in cities)
            {
                if(city.CountryName == "Việt Nam")
                {
                    Vietnam.Add(city);
                }

                if (city.CountryName == "Nhật Bản")
                {
                    Nhatban.Add(city);
                }

                if (city.CountryName == "Anh")
                {
                    Anh.Add(city);
                }

                if (city.CountryName == "Thái Lan")
                {
                    Thailan.Add(city);
                }
            }

            //add country to list
            countries.Add(all);
            countries.Add(Vietnam);
            countries.Add(Nhatban);
            countries.Add(Anh);
            countries.Add(Thailan);

            PkrCountry.ItemsSource = countries;
        }

        private void ListViewInit(string countryName)
        {
            LstSelectedCountry.ItemsSource = countryName == "" || countryName == "Tất cả" 
                ? cities : cities.Where(c => c.CountryName == countryName);


            // Method 2: Tạo ra 1 danh sách mới...
            //List<City> selectedcities = new List<City>();

            //foreach(City city in cities)
            //{
            //    if(city.CountryName == countryName)
            //    {
            //        selectedcities.Add(city);
            //    }
            //}
            //    LstSelectedCountry.ItemsSource = selectedcities;

        }
        private void PrkCountry_SelectedIndexChanged(object sender, EventArgs e)
        {
            Picker picker = (Picker)sender;
            Country selectedCountry = picker.SelectedItem as Country;
            if (selectedCountry != null)
            {
                ListViewInit(selectedCountry.CountryName);
            }
        }
     
    }
}