// ///////////////////////////////
// // Author: Derick Rhodes     //
// // Creation Date: 12/12/2015 //
// // Last Updated: 12/12/2015  //
// ///////////////////////////////

using WeaponForger.Models;
using Xamarin.Forms;

namespace WeaponForger.ViewModels
{
    public class ForgedViewModel
    {
        public ForgedViewModel(INavigation navigation, Weapon weapon)
        {
            Navigation = navigation;
            Weapon = weapon;

            ReturnCommand = new Command(ReturnButton);
        }

        #region Methods

        /// <summary>
        ///     Returns the button.
        /// </summary>
        private async void ReturnButton()
        {
            await Navigation.PopToRootAsync();
        }

        #endregion

        #region Properties

        /// <summary>
        ///     Gets or sets the navigation.
        /// </summary>
        /// <value>
        ///     The navigation.
        /// </value>
        public INavigation Navigation { get; set; }

        /// <summary>
        ///     Gets or sets the weapon.
        /// </summary>
        /// <value>
        ///     The weapon.
        /// </value>
        public Weapon Weapon { get; set; }

        /// <summary>
        ///     Gets or sets the return command.
        /// </summary>
        /// <value>
        ///     The return command.
        /// </value>
        public Command ReturnCommand { get; set; }

        #endregion
    }
}