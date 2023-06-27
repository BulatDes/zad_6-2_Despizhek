using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Zad6_2_Des
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ThreePage :ContentPage
    {
        private Label label1;
        private Label label2;
        private Entry entry;
        double price = 1;
        private Button button;
        private int number = 0;
        private string name;
        public ThreePage (Hotel hotel)
        {
            InitializeComponent();
            label1 = new Label();
            label2 = new Label();
            entry = new Entry();
            button = new Button();
            price = hotel.Price;
            label1.Text = $"Гостиница: {hotel.Name}";
            name = hotel.Name;
            hotel.Number = hotel.Number - number;
            number = hotel.Number;
            label2.Text = $"Свободных номеров: {number}";
            entry.Placeholder = "Введите сколько мест будете арендовывать";
            button.Text = "Арендовать";
            var stackLayout = new StackLayout();
            button.Clicked += OnSaveButtonClicked;
            stackLayout.Children.Add(label1);
            stackLayout.Children.Add(label2);
            stackLayout.Children.Add(entry);
            stackLayout.Children.Add(button);
            Content = stackLayout;
        }
        private async void OnSaveButtonClicked (object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToInt32(entry.Text) <= 4 && Convert.ToInt32(entry.Text) >= 1)
                {
                    number = number - Convert.ToInt32(entry.Text);
                    label2.Text = $"Свободных номеров: {number}";
                    DisplayAlert("Сообщение", $"Вы успешно арендовали {entry.Text} номер(ов)", "Хорошо");
                    await Navigation.PushModalAsync(new TwoPage(name, int.Parse(entry.Text), price));
                    entry.Text = "";
                } else if (Convert.ToInt32(entry.Text) > 4)
                    DisplayAlert("Ошибка", "Нельзя брать на одного человека больше 4 номеров в гостинице", "ОК");
                else
                    DisplayAlert("Ошибка", "Неправильный ввод", "ОК");
            } catch { DisplayAlert("Ошибка", "Непредвиденная ошибка", "ОК"); }

        }
    }
}