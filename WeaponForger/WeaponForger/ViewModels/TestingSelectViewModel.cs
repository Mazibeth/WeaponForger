// ///////////////////////////////
// // Author: Derick Rhodes     //
// // Creation Date: 12/11/2015 //
// // Last Updated: 12/12/2015  //
// ///////////////////////////////

using System.Collections.ObjectModel;
using WeaponForger.Data;
using WeaponForger.Models;
using WeaponForger.Views;
using Xamarin.Forms;

namespace WeaponForger.ViewModels
{
    public class TestingSelectViewModel
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="TestingSelectViewModel"/> class.
        /// </summary>
        /// <param name="navigation">The navigation.</param>
        public TestingSelectViewModel(INavigation navigation)
        {
            Navigation = navigation;
            DBContext = new WeaponForgerDatabase();

            TestCommand = new Command(Test, TestEnabled);

            Weapons = DBContext.GetWeapons() != null
                ? new ObservableCollection<Weapon>(DBContext.GetWeapons())
                : new ObservableCollection<Weapon>();
        }

        #region Fields

        private Weapon _weapon;

        #endregion

        #region Properties

        /// <summary>
        /// Gets or sets the test command.
        /// </summary>
        /// <value>
        /// The test command.
        /// </value>
        public Command TestCommand { get; set; }

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

        #endregion

        #region Methods

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
                TestCommand.ChangeCanExecute();
            }
        }

        /// <summary>
        /// Tests this instance.
        /// </summary>
        private async void Test()
        {
            await Navigation.PushAsync(new WeaponTestingView(Weapon));
        }

        /// <summary>
        /// Tests the enabled.
        /// </summary>
        /// <returns></returns>
        private bool TestEnabled()
        {
            return Weapon != null;
        }

        #endregion

    }
}