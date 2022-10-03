using Interfaces;

namespace LoginAdapters
{
    public class AlwaysLoginAdapter : ILogin
    {
        public bool Login(string username, string password)
        {
            return true;
        }
    }
}
