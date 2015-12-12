// ///////////////////////////////
// // Author: Derick Rhodes     //
// // Creation Date: 09/14/2015 //
// // Last Updated: 12/12/2015  //
// ///////////////////////////////

using Android.App;
using Android.Content.PM;
using Android.OS;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

namespace WeaponForger.Droid
{
    [Activity(Label = "WeaponForger", Icon = "@drawable/icon", MainLauncher = true,
        ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation,
        ScreenOrientation = ScreenOrientation.Landscape)]
    public class MainActivity : FormsApplicationActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            Forms.Init(this, bundle);
            LoadApplication(new App());
        }
    }
}