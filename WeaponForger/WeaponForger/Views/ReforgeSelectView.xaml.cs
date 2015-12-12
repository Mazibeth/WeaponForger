using WeaponForger.ViewModels;
using Xamarin.Forms;

namespace WeaponForger.Views
{
    public partial class ReforgeSelectView : ContentPage
    {
        public ReforgeSelectView()
        {
            InitializeComponent();
            BindingContext = new ReforgeSelectViewModel(Navigation);
        }
    }
}