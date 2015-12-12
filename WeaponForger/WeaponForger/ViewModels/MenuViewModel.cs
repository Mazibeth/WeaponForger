using System.Collections.ObjectModel;
using WeaponForger.Models;
using WeaponForger.Views;
using Xamarin.Forms;

namespace WeaponForger.ViewModels
{
    public class MenuViewModel
    {
        public MenuViewModel(INavigation navigation)
        {
            Navigation = navigation;
            NewCommand = new Command(NewButton);
            ReforgeCommand = new Command(ReforgeButton);
            TestCommand = new Command(TestButton);
        }

        public Command NewCommand { get; set; }
        public Command ReforgeCommand { get; set; }
        public Command TestCommand { get; set; }
        public INavigation Navigation { get; set; }

        private async void NewButton()
        {
            await Navigation.PushAsync(new WeaponForge());
        }

        private async void ReforgeButton()
        {
            await Navigation.PushAsync(new ReforgeSelectView());
        }

        private async void TestButton()
        {
            await Navigation.PushAsync(new TestingSelectView());
        }
    }
}