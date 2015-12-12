using WeaponForger.ViewModels;
using Xamarin.Forms;

namespace WeaponForger.Views
{
    public partial class MenuView : ContentPage
    {
        public MenuView()
        {
            InitializeComponent();
            BindingContext = new MenuViewModel(Navigation);
        }
    }
}