namespace Client
{
    public class User
    {
        private string name;
        private string password;

        public void SetPassword(string _password)
        {
            password = _password;
        }

        public void SetName(string _name)
        {
            name = _name;
        }

        public string GetName()
        {
            return name;
        }

        public string GetPassword()
        {
            return password;
        }
    }
}
