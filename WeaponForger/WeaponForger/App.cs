// ///////////////////////////////
// // Author: Derick Rhodes     //
// // Creation Date: 09/14/2015 //
// // Last Updated: 12/12/2015  //
// ///////////////////////////////

using WeaponForger.Views;
using Xamarin.Forms;

namespace WeaponForger
{
    public class App : Application
    {
        public App()
        {
            // The root page of your application
            MainPage = new NavigationPage(new MenuView());
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}