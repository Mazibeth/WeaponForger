// ///////////////////////////////
// // Author: Derick Rhodes     //
// // Creation Date: 09/14/2015 //
// // Last Updated: 12/12/2015  //
// ///////////////////////////////

using UIKit;

namespace WeaponForger.iOS
{
    public class Application
    {
        // This is the main entry point of the application.
        private static void Main(string[] args)
        {
            // if you want to use a different Application Delegate class from "AppDelegate"
            // you can specify it here.
            UIApplication.Main(args, null, "AppDelegate");
        }
    }
}