using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeaponForger.ViewModels;
using Xamarin.Forms;

namespace WeaponForger.Views
{
    public partial class TestingSelectView : ContentPage
    {
        public TestingSelectView()
        {
            InitializeComponent();
            BindingContext = new TestingSelectViewModel(Navigation);
        }
    }
}
