// ///////////////////////////////
// // Author: Derick Rhodes     //
// // Creation Date: 09/14/2015 //
// // Last Updated: 12/12/2015  //
// ///////////////////////////////

using WeaponForger.WinPhone.Resources;

namespace WeaponForger.WinPhone
{
    /// <summary>
    ///     Provides access to string resources.
    /// </summary>
    public class LocalizedStrings
    {
        private static readonly AppResources _localizedResources = new AppResources();

        public AppResources LocalizedResources
        {
            get { return _localizedResources; }
        }
    }
}