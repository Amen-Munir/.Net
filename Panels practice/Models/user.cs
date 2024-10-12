using System.ComponentModel;  

internal class user : INotifyPropertyChanged
{
    private string name;
    private string password;

    
    public event PropertyChangedEventHandler PropertyChanged;

    public string Name
    {
        get { return name; }
        set
        {
            if (name != value)
            {
                name = value;
                
                OnPropertyChanged("Name");
            }
        }
    }

    public string Password
    {
        get { return password; }
        set
        {
            if (password != value)
            {
                password = value;
               
                OnPropertyChanged("Password");
            }
        }
    }

    public user(string name, string password)
    {
        Name = name;
        Password = password;
    }

    
    protected void OnPropertyChanged(string propertyName)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}
