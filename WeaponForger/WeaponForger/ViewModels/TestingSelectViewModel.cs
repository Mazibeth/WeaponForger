using System;
using System.Collections.ObjectModel;
using System.Diagnostics;
using WeaponForger.Data;
using WeaponForger.Models;
using WeaponForger.Views;
using Xamarin.Forms;

namespace WeaponForger.ViewModels
{
    public class TestingSelectViewModel
    {
        private Weapon _weapon;

        public TestingSelectViewModel(INavigation navigation)
        {
            Navigation = navigation;
            DBContext = new WeaponForgerDatabase();

            TestCommand = new Command(Test, TestEnabled);

            Weapons = DBContext.GetWeapons() != null
                ? new ObservableCollection<Weapon>(DBContext.GetWeapons())
                : new ObservableCollection<Weapon>();
        }

        public Command TestCommand { get; set; }
        public INavigation Navigation { get; set; }
        public WeaponForgerDatabase DBContext { get; set; }
        public ObservableCollection<Weapon> Weapons { get; set; }

        public Weapon Weapon
        {
            get { return _weapon; }
            set
            {
                _weapon = value;
                TestCommand.ChangeCanExecute();
            }
        }

        private async void Test()
        {
            await Navigation.PushAsync(new WeaponTestingView(Weapon));
        }

        private bool TestEnabled()
        {
            return Weapon != null;
        }
    }
}