// ///////////////////////////////
// // Author: Derick Rhodes     //
// // Creation Date: 12/08/2015 //
// // Last Updated: 12/12/2015  //
// ///////////////////////////////

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
        /// <summary>
        /// Initializes a new instance of the <see cref="ReforgeSelectViewModel"/> class.
        /// </summary>
        /// <param name="navigation">The navigation.</param>
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

        #region Fields

        private Weapon _weapon;

        #endregion

        #region Properties

        /// <summary>
        /// Gets or sets the reforge command.
        /// </summary>
        /// <value>
        /// The reforge command.
        /// </value>
        public Command ReforgeCommand { get; set; }

        /// <summary>
        /// Gets or sets the destroy command.
        /// </summary>
        /// <value>
        /// The destroy command.
        /// </value>
        public Command DestroyCommand { get; set; }

        /// <summary>
        /// Gets or sets the navigation.
        /// </summary>
        /// <value>
        /// The navigation.
        /// </value>
        public INavigation Navigation { get; set; }

        /// <summary>
        /// Gets or sets the database context.
        /// </summary>
        /// <value>
        /// The database context.
        /// </value>
        public WeaponForgerDatabase DBContext { get; set; }

        /// <summary>
        /// Gets or sets the weapons.
        /// </summary>
        /// <value>
        /// The weapons.
        /// </value>
        public ObservableCollection<Weapon> Weapons { get; set; }

        /// <summary>
        /// Gets or sets the weapon.
        /// </summary>
        /// <value>
        /// The weapon.
        /// </value>
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

        #endregion

        #region Methods

        /// <summary>
        /// Reforges this instance.
        /// </summary>
        private async void Reforge()
        {
            await Navigation.PushAsync(new WeaponForge(Weapon));
        }

        /// <summary>
        /// Reforges the enabled.
        /// </summary>
        /// <returns></returns>
        private bool ReforgeEnabled()
        {
            return Weapon != null;
        }

        /// <summary>
        /// Destroys this instance.
        /// </summary>
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

        /// <summary>
        /// Destroys the enabled.
        /// </summary>
        /// <returns></returns>
        private bool DestroyEnabled()
        {
            return Weapon != null;
        }

        #endregion

    }
}