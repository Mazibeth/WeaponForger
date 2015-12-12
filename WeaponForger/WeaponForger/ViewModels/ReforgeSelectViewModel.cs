using System;
using System.Collections.ObjectModel;
using System.Diagnostics;
using WeaponForger.Data;
using WeaponForger.Models;
using WeaponForger.Views;
using Xamarin.Forms;

namespace WeaponForger.ViewModels
{
    public class ReforgeSelectViewModel
    {
        private Weapon _weapon;

        public ReforgeSelectViewModel(INavigation navigation)
        {
            Navigation = navigation;
            DBContext = new WeaponForgerDatabase();

            ReforgeCommand = new Command(Reforge, ReforgeEnabled);
            DestroyCommand = new Command(Destroy, DestroyEnabled);

            Weapons = DBContext.GetWeapons() != null
                ? new ObservableCollection<Weapon>(DBContext.GetWeapons())
                : new ObservableCollection<Weapon>();
        }

        public Command ReforgeCommand { get; set; }
        public Command DestroyCommand { get; set; }
        public INavigation Navigation { get; set; }
        public WeaponForgerDatabase DBContext { get; set; }
        public ObservableCollection<Weapon> Weapons { get; set; }

        public Weapon Weapon
        {
            get { return _weapon; }
            set
            {
                _weapon = value;
                ReforgeCommand.ChangeCanExecute();
                DestroyCommand.ChangeCanExecute();
            }
        }

        private async void Reforge()
        {
            await Navigation.PushAsync(new WeaponForge(Weapon));
        }

        private bool ReforgeEnabled()
        {
            return Weapon != null;
        }

        private void Destroy()
        {
            try
            {
                DBContext.DeleteWeapon(Weapon.Id);
                Weapons.Remove(Weapon);
                Weapon = null;
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.Message);
                throw;
            }
        }

        private bool DestroyEnabled()
        {
            return Weapon != null;
        }
    }
}