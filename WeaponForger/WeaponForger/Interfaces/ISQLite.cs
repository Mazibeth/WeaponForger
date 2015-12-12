using SQLite;

namespace WeaponForger.Interfaces
{
    public interface ISQLite
    {
        SQLiteConnection GetConnection();
    }
}