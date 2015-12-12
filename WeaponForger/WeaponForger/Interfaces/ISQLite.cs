// ///////////////////////////////
// // Author: Derick Rhodes     //
// // Creation Date: 10/31/2015 //
// // Last Updated: 12/12/2015  //
// ///////////////////////////////

using SQLite;

namespace WeaponForger.Interfaces
{
    public interface ISQLite
    {
        /// <summary>
        /// Gets the connection.
        /// </summary>
        /// <returns></returns>
        SQLiteConnection GetConnection();
    }
}