using System.IO;
using Windows.Storage;
using SQLite;
using WeaponForger.Interfaces;
using WeaponForger.WinPhone;
using Xamarin.Forms;

[assembly: Dependency(typeof (SQLite_WinPhone))]

namespace WeaponForger.WinPhone
{
    public class SQLite_WinPhone : ISQLite
    {
        public SQLiteConnection GetConnection()
        {
            var sqliteFilename = "WeaponForgerSQLite.db3";
            var path = Path.Combine(ApplicationData.Current.LocalFolder.Path, sqliteFilename);
            // Create the connection
            var conn = new SQLiteConnection(path);
            // Return the database connection
            return conn;
        }
    }
}