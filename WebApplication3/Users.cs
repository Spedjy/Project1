namespace WebApplication3;
public enum Roles
{
    Admin,
    User
    
}

public class Users
{
    public string Login { get; set; }
    public string Password { get; set; }
    private Roles Role { get; set; }
}

