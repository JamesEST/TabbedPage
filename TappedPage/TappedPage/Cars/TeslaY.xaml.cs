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
    public partial class TeslaY : ContentPage
    {
        public List<Car> Phones { get; set; }
        public TeslaY()
        {
            InitializeComponent();
            Phones = new List<Car>
            {
                new Car {Title="Тип кузова" , CarInfo="Внедорожник", ImagePath = "CarInfoImage6.png"},
                new Car {Title="Мощность", CarInfo="450 л.с. / 336 кВт", ImagePath = "CarInfoImage3.png"},
                new Car {Title="Кол-во мест" , CarInfo="7 мест", ImagePath = "CarInfoImage4.png"},
                new Car {Title="Кол-во дверей", CarInfo="5 дверей", ImagePath = "CarInfoImage2.png"},
                new Car {Title="Запас хода" , CarInfo="480 км", ImagePath="CarInfoImage5.png"},
                new Car {Title="Расход Электричество кВт⋅ч/100 км", CarInfo="16 кВт⋅ч/100 км", ImagePath="CarInfoImage1.png"}
            };
            this.BindingContext = this;
        }
        public async void OnItemTapped(object sender, ItemTappedEventArgs e)
        {
            Car selectedPhone = e.Item as Car;
            if (selectedPhone != null)
                await DisplayAlert("Выбранная модель", $"{selectedPhone.CarInfo}  {selectedPhone.Title}", "OK");
        }
    }
}