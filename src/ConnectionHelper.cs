using System.Net;
using static System.Console;

namespace Helper
{
    class ConnectionHelper
    {

        public static void CheckConnectionMain()
        {
            if (CheckConnection() == false)
            {
                WriteLine("\nNo internet connection...\n");
                ReadKey(true);
            }
        }
        
        private static bool CheckConnection()
        {
            try
            {
                var client = new WebClient();
                client.OpenRead("http://google.com/generate_204");
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
