using MySql.Data.MySqlClient;
using System.Data.Common;

namespace Authentification
{
    public class AuthService
    {
        private const string SQL_CONNECTION = "Server=cours.cegep3r.info;Database=...;Uid=...;Pwd=...;";

        private static AuthService Instance
        {
            get
            {
                if (instance == null)
                    instance = new AuthService();

                return instance;
            }
        }

        private static AuthService instance;

        public event EventHandler OnAttemptLogin;
        public event EventHandler OnLoginFailed;
        public event EventHandler OnLoginSucceeded;
        public event EventHandler OnLoginCompleted;

        public static async Task<User> Authenticate(string matricule)
        {
            try
            {
                MySqlConnection connection = new MySqlConnection(SQL_CONNECTION);

                MySqlCommand cmd = new MySqlCommand
                (
                    "SELECT * FROM users WHERE matricule = @matricule LIMIT 1",
                    connection
                );

                await connection.OpenAsync();

                DbDataReader r = await cmd.ExecuteReaderAsync();

                if (r.Read())
                {
                    
                }

                await r.CloseAsync();
                await connection.CloseAsync();
            }
            catch (MySqlException ex)
            {
                Console.WriteLine($"Failed to connect: {ex.Message}");
            }
        }

        public static void Disconnect()
        {

        }
    }
}
