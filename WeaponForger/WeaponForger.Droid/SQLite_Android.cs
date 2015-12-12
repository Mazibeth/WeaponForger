// ///////////////////////////////
// // Author: Derick Rhodes     //
// // Creation Date: 10/31/2015 //
// // Last Updated: 12/12/2015  //
// ///////////////////////////////

using System;
using System.IO;
using SQLite;
using WeaponForger.Droid;
using WeaponForger.Interfaces;
using Xamarin.Forms;

[assembly: Dependency(typeof (SQLite_Android))]

namespace WeaponForger.Droid
{
    public class SQLite_Android : ISQLite
    {
        public SQLiteConnection GetConnection()
        {
            var sqliteFilename = "WeaponForgerSQLite.db3";
            var documentsPath = Environment.GetFolderPath(Environment.SpecialFolder.Personal); // Documents folder
            var path = Path.Combine(documentsPath, sqliteFilename);
            // Create the connection
            var conn = new SQLiteConnection(path);
            // Return the database connection
            return conn;
        }
    }
}