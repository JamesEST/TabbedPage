using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TappedPage.Company
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Tesla : TabbedPage
    {
        public Tesla()
        {
            InitializeComponent();
        }
    }
}