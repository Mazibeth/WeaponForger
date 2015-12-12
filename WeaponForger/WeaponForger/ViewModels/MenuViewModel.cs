// ///////////////////////////////
// // Author: Derick Rhodes     //
// // Creation Date: 12/08/2015 //
// // Last Updated: 12/12/2015  //
// ///////////////////////////////

using WeaponForger.Views;
using Xamarin.Forms;

namespace WeaponForger.ViewModels
{
    public class MenuViewModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MenuViewModel"/> class.
        /// </summary>
        /// <param name="navigation">The navigation.</param>
        public MenuViewModel(INavigation navigation)
        {
            Navigation = navigation;
            NewCommand = new Command(NewButton);
            ReforgeCommand = new Command(ReforgeButton);
            TestCommand = new Command(TestButton);
        }

        #region Properties

        /// <summary>
        /// Gets or sets the new command.
        /// </summary>
        /// <value>
        /// The new command.
        /// </value>
        public Command NewCommand { get; set; }

        /// <summary>
        /// Gets or sets the reforge command.
        /// </summary>
        /// <value>
        /// The reforge command.
        /// </value>
        public Command ReforgeCommand { get; set; }

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

        #endregion

        #region Methods

        /// <summary>
        /// News the button.
        /// </summary>
        private async void NewButton()
        {
            await Navigation.PushAsync(new WeaponForge());
        }

        /// <summary>
        /// Reforges the button.
        /// </summary>
        private async void ReforgeButton()
        {
            await Navigation.PushAsync(new ReforgeSelectView());
        }

        /// <summary>
        /// Tests the button.
        /// </summary>
        private async void TestButton()
        {
            await Navigation.PushAsync(new TestingSelectView());
        }

        #endregion
    }
}