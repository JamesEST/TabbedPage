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
    public partial class MercedesE350 : ContentPage
    {
        public List<Car> Phones { get; set; }
        public MercedesE350()
        {
            InitializeComponent();
            Phones = new List<Car>
            {
                new Car {Title="" , Company="Тип кузова: купе"},
                new Car {Title="", Company="Мощность: 431 л.с" },
                new Car {Title="", Company="Рабочий объём: 2979 см3"  }
            };
            this.BindingContext = this;
        }
        public async void OnItemTapped(object sender, ItemTappedEventArgs e)
        {
            Car selectedPhone = e.Item as Car;
            if (selectedPhone != null)
                await DisplayAlert("Выбранная модель", $"{selectedPhone.Company}  {selectedPhone.Title}", "OK");
        }
    }
}