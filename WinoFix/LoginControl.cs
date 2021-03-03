using MySql.Data.MySqlClient;


namespace WinoFix
{
    public class Login
    {
        private static string usuario;  // field
        public static string Usuario    // property
        {
            get { return usuario; }
            set { usuario = value; }
        }
    }
}
