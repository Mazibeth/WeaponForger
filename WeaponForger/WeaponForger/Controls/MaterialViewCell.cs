// ///////////////////////////////
// // Author: Derick Rhodes     //
// // Creation Date: 12/06/2015 //
// // Last Updated: 12/12/2015  //
// ///////////////////////////////

// This control is not yet complete, but eventually it will be needed.

using Xamarin.Forms;

namespace WeaponForger.Controls
{
    public class MaterialViewCell : ViewCell
    {
        #region Fields

        public static readonly BindableProperty NameProperty = BindableProperty.Create("Name", typeof (string),
            typeof (MaterialViewCell), "");

        #endregion

        #region Properties

        public string Name
        {
            get { return (string) GetValue(NameProperty); }
            set { SetValue(NameProperty, value); }
        }

        #endregion

        #region Methods

        #endregion
    }
}