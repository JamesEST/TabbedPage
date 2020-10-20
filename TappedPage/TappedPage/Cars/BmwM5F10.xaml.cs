﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TappedPage.Cars
{
    
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class BmwM5F10 : ContentPage
    {
        public List<Car> Phones { get; set; }
        public BmwM5F10()
        {
            InitializeComponent();
            Phones = new List<Car>
            {
                new Car {Title="Тип кузова" , CarInfo="Седан", ImagePath = "CarInfoImage6.png"},
                new Car {Title="Мощность", CarInfo="560 л.с", ImagePath = "CarInfoImage3.png"},
                new Car {Title="Кол-во мест" , CarInfo="5 мест", ImagePath = "CarInfoImage4.png"},
                new Car {Title="Кол-во дверей", CarInfo="4 дверей", ImagePath = "CarInfoImage2.png"},
                new Car {Title="Тип топлива Бензин" , CarInfo="АИ-98", ImagePath="CarInfoImage5.png"},
                new Car {Title="Расход топлива л/100 км", CarInfo="9,9л/100км", ImagePath="CarInfoImage1.png"}
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