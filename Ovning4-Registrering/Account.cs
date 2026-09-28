class Account
{
    public string Username { get; private set; } = "";
    public string Password { get; private set; } = "";

    public bool Register(string username, string password)
    {
        if (CheckPasswordStrength(password))
        {
            Username = username;
            Password = password;
            return true;
        }

        return false;
    }

    public bool Login(string username, string password)
    {
        if (username == Username && password == Password)
        {
            return true;
        }

        return false;
    }

    public bool CheckPasswordStrength(string password)
    {
        bool hasDigit = false;
        bool hasUpper = false;
        bool hasSpecial = false;

        foreach (char c in password)
        {
            if (char.IsDigit(c))
            {
                hasDigit = true;
            }
            else if (char.IsUpper(c))
            {
                hasUpper = true;
            }
            else if (!char.IsLetterOrDigit(c))
            {
                hasSpecial = true;
            }
        }

        return password.Length >= 6 &&
               hasDigit &&
               hasUpper &&
               hasSpecial;
    }
}