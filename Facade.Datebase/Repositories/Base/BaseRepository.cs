using System.Data.SqlClient;
using static Facade.Datebase.Program;

namespace Facade.Datebase.Repositories.Base
{
    public abstract class BaseRepository
    {
        protected SqlConnection connection = new SqlConnection(Configuration.ConnectionString);
        protected SqlCommand CreateCommand(string query)
        {
            connection.Close();
            connection.Open();

            return new SqlCommand(query, connection);
        }
    }
}
