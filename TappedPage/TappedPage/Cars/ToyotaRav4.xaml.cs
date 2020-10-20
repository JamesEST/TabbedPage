using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TappedPage.Cars
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ToyotaRav4 : ContentPage
    {
        public List<Car> Phones { get; set; }
        private bool status;
        public ToyotaRav4()
        {
            InitializeComponent();
            Phones = new List<Car>
            {
                new Car {Title="Тип кузова" , CarInfo="Внедорожник", ImagePath = "CarInfoImage6.png"},
                new Car {Title="Мощность", CarInfo="149 л.с", ImagePath = "CarInfoImage3.png"},
                new Car {Title="Кол-во мест" , CarInfo="5 мест", ImagePath = "CarInfoImage4.png"},
                new Car {Title="Кол-во дверей", CarInfo="5 дверей", ImagePath = "CarInfoImage2.png"},
                new Car {Title="Тип топлива Бензин" , CarInfo="АИ-92", ImagePath="CarInfoImage5.png"},
                new Car {Title="Расход топлива л/100 км", CarInfo="6,6л/100км", ImagePath="CarInfoImage1.png"}
            };
            this.BindingContext = this;
            animationbtn(5000);
        }
        public async void OnItemTapped(object sender, ItemTappedEventArgs e)
        {
            Car selectedPhone = e.Item as Car;
            if (selectedPhone != null)
                await DisplayAlert("Выбранная модель", $"{selectedPhone.CarInfo}  {selectedPhone.Title}", "OK");
        }
        private async void animationbtn(uint duration)
        {
            _btn.TranslateTo(-600, 0, 1);
            await Task.WhenAll(
                _btn.TranslateTo(0, 0, duration),
                _btn.FadeTo(1 , duration+500)
            );
        } 
        private void _btn_OnClicked(object sender, EventArgs e)
        {
            if (status == false)
            {
                _ImageLogo.Source = "ToyotaLogo.gif";
                _ImageLogo.IsAnimationPlaying = true;
                status = true;
            }
            else if (status == true)
            {
                _ImageLogo.Source = "ToyotaRav4.jpg";
                _ImageLogo.IsAnimationPlaying = false;
                status = false;
            }
       
        }
    }
}