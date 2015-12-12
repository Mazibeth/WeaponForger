using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Dynamic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using WeaponForger.Annotations;
using WeaponForger.Models;
using Xamarin.Forms;

namespace WeaponForger.ViewModels
{
    public class WeaponTestingViewModel : INotifyPropertyChanged
    {
        private string _combo;
        private double _totalDamage;

        public WeaponTestingViewModel(INavigation navigation, Weapon weapon)
        {
            Navigation = navigation;
            Weapon = weapon;

            AttackCommand = new Command(Attack);
        }

        public Command AttackCommand { get; set; }

        public string Combo
        {
            get { return _combo; }
            set
            {
                _combo = value; 
                OnPropertyChanged("Combo");
            }
        }

        public double TotalDamage
        {
            get { return _totalDamage; }
            set
            {
                _totalDamage = value; 
                OnPropertyChanged("TotalDamage");
            }
        }

        public Weapon Weapon { get; set; }
        public INavigation Navigation { get; set; }

        private void Attack()
        {
            var rand = new Random();

            Combo = string.Empty;
            TotalDamage = 0;

            for (int i = 0; i < (Weapon.Speed / 1); i++)
            {
                var damage = Weapon.Damage + rand.Next(10); ;

                if (i != 0)
                {
                    Combo += " + ";
                }
                Combo += damage;

                TotalDamage += damage;
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
