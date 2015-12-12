// ///////////////////////////////
// // Author: Derick Rhodes     //
// // Creation Date: 12/11/2015 //
// // Last Updated: 12/12/2015  //
// ///////////////////////////////

using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using WeaponForger.Annotations;
using WeaponForger.Models;
using Xamarin.Forms;

namespace WeaponForger.ViewModels
{
    public class WeaponTestingViewModel : INotifyPropertyChanged
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WeaponTestingViewModel"/> class.
        /// </summary>
        /// <param name="navigation">The navigation.</param>
        /// <param name="weapon">The weapon.</param>
        public WeaponTestingViewModel(INavigation navigation, Weapon weapon)
        {
            Navigation = navigation;
            Weapon = weapon;

            AttackCommand = new Command(Attack);
        }

        #region Fields

        private string _combo;
        private double _totalDamage;

        #endregion

        #region Properties

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
        public event PropertyChangedEventHandler PropertyChanged;

        #endregion

        #region Methods

        private void Attack()
        {
            var rand = new Random();

            Combo = string.Empty;
            TotalDamage = 0;

            for (var i = 0; i < (Weapon.Speed / 1); i++)
            {
                var damage = Weapon.Damage + rand.Next(10);
                ;

                if (i != 0)
                {
                    Combo += " + ";
                }
                Combo += damage;

                TotalDamage += damage;
            }
        }

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        #endregion

    }
}