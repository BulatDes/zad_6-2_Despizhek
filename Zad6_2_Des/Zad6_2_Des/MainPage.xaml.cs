using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Zad6_2_Des
{
    public partial class MainPage :ContentPage
    {
        public Hotel shtl = new Hotel();
        private List<Hotel> hotels = new List<Hotel>
        {
            new Hotel
                {
                    Name = "Буян-Бадыргы",
                    Number = 151,
                    Director = "Бадыргы",
                    Phone = "98246434",
                    Category = 1,
                    Capacity = 50,
                    Price = 100,
                    Surname = "Кара",
                    Address = "Улица Добровольцев 2",
                    Age = 30,
                    CheckInDate = DateTime.Now,
                    StayDuration = 3,
                    IsPaymentCash = true
                },
                new Hotel
                {
                    Name = "Чалама",
                    Number = 97,
                    Director = "Комаадыр",
                    Phone = "67863748",
                    Category = 2,
                    Capacity = 1,
                    Price = 75,
                    Surname = "Ак",
                    Address = "Улица Ленина 10",
                    Age = 25,
                    CheckInDate = DateTime.Now.AddDays(1),
                    StayDuration = 2,
                    IsPaymentCash = false
                },
                new Hotel
                {
                    Name = "Азимут",
                    Number = 76,
                    Director = "Азиат",
                    Phone = "37867947",
                    Category = 5,
                    Capacity = 3,
                    Price = 130,
                    Surname = "Кок",
                    Address = "Улица Кочетова 29",
                    Age = 40,
                    CheckInDate = DateTime.Now.AddDays(1),
                    StayDuration = 2,
                    IsPaymentCash = false
                }
        };
        public MainPage ()
        {
            InitializeComponent();
           
        }

        private void rad1_CheckedChanged (object sender, CheckedChangedEventArgs e)
        {
            if (rd1.IsChecked)
            {
                rd2.IsChecked = false;
                rd3.IsChecked = false;
                foreach (var selectedHotel in hotels)
                {
                    if (selectedHotel.Name == "Чалама")
                    {
                        var message = $"Название: {selectedHotel.Name}\n" +
                   $"Свободных номеров: {selectedHotel.Number}\n" +
                   $"Директор: {selectedHotel.Director}\n" +
                   $"Телефон: {selectedHotel.Phone}\n" +
                   $"Категория: {selectedHotel.Category}\n" +
                   $"Стоимость за один день: {selectedHotel.Price}\n" +
                   $"Адрес: {selectedHotel.Address}\n" +
                   $"Возраст: {selectedHotel.Age}\n";
                        DisplayAlert("Выбран отель", message, "ОК");
                        shtl = selectedHotel;
                    }
                    

                }
            }
          
        }

        private void rd3_CheckedChanged (object sender, CheckedChangedEventArgs e)
        {
            if (rd3.IsChecked)
            {
                rd1.IsChecked = false;
                rd2.IsChecked = false;
                foreach (var selectedHotel in hotels)
                {
                    if (selectedHotel.Name == "Азимут")
                    {
                        var message = $"Название: {selectedHotel.Name}\n" +
                   $"Свободных номеров: {selectedHotel.Number}\n" +
                   $"Директор: {selectedHotel.Director}\n" +
                   $"Телефон: {selectedHotel.Phone}\n" +
                   $"Категория: {selectedHotel.Category}\n" +
                   $"Стоимость за один день: {selectedHotel.Price}\n" +
                   $"Адрес: {selectedHotel.Address}\n" +
                   $"Возраст: {selectedHotel.Age}\n";
                        DisplayAlert("Выбран отель", message, "ОК");
                        shtl = selectedHotel;
                    }


                }
            }
        }

        private void rd2_CheckedChanged (object sender, CheckedChangedEventArgs e)
        {
            if (rd2.IsChecked)
            {
                rd3.IsChecked = false;
                rd1.IsChecked = false;
                foreach (var selectedHotel in hotels)
                {
                    if (selectedHotel.Name == "Буян-Бадыргы")
                    {
                        var message = $"Название: {selectedHotel.Name}\n" +
                   $"Свободных номеров: {selectedHotel.Number}\n" +
                   $"Директор: {selectedHotel.Director}\n" +
                   $"Телефон: {selectedHotel.Phone}\n" +
                   $"Категория: {selectedHotel.Category}\n" +
                   $"Стоимость за один день: {selectedHotel.Price}\n" +
                   $"Адрес: {selectedHotel.Address}\n" +
                   $"Возраст: {selectedHotel.Age}\n";
                        DisplayAlert("Выбран отель", message, "ОК");
                        shtl = selectedHotel;
                    }


                }
            }
        }

        private async void Button_Clicked (object sender, EventArgs e)
        {
            if (shtl.Name == null)
            {
                DisplayAlert("Attention","Please, Select hotel", "ОК");
                return;
            }
            await Navigation.PushModalAsync(new ThreePage(shtl));
        }

        private async void Button_Clicked_1 (object sender, EventArgs e)
        {
            if (shtl.Name == null)
            {
                DisplayAlert("Attention", "Please, Select hotel", "ОК");
                return;
            }
            await Navigation.PushModalAsync(new TwoPage(shtl));
        }
    }
}
