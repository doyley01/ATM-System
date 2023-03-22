using AAS_System;

class BankEmployee
{
    private string username;
    private string password;

    public BankEmployee(string username, string password)
    {
        this.username = username;
        this.password = password;
    }

    public BankEmployee()
    {

    }
    
    public string SetUsername(string user)
    {
        this.username = user;
        return user;
    }

    public string SetPassword(string pass)
    {
        this.password = pass;
        return pass;
    }

    public string GetUsername()
    {
        return username;
    }

    public string GetPassword()
    {
        return password;
    }


   
    
}