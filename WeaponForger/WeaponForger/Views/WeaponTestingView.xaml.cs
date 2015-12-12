using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeaponForger.Models;
using WeaponForger.ViewModels;
using Xamarin.Forms;

namespace WeaponForger.Views
{
    public partial class WeaponTestingView : ContentPage
    {
        public WeaponTestingView(Weapon weapon)
        {
            InitializeComponent();
            BindingContext = new WeaponTestingViewModel(Navigation, weapon);
        }
    }
}
