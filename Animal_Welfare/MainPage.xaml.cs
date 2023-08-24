namespace Animal_Welfare;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();
	}

    //private async void OnLoginButtonClicked(object sender, EventArgs e)
    //{
    //    string email = emailEntry.Text;
    //    string password = passwordEntry.Text;

    //    if (!email.Contains("@") || !email.EndsWith(".com"))
    //    {
    //        await DisplayAlert("Invalid Email", "Please enter a valid email.", "OK");
    //    }
    //    else if (IsValidLogin(email, password))
    //    {
    //        // Navigate to the dashboard page after successful login
    //        await Navigation.PushAsync(new DashBoard());
    //    }
    //    else
    //    {
    //        await DisplayAlert("Login Failed", "Invalid email or password.", "OK");
    //    }
    //}
    private void OnLoginButtonClicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new DashBoard());
        string email = emailEntry.Text;
    }

    // Replace this with your actual login validation logic
    //private bool IsValidLogin(string email, string password)
    //{
    //    if (!email.Contains("@") || !email.EndsWith(".com"))
    //    {
    //        Navigation.PushAsync(DashBoard());
    //    }
    //    return true;
    //    // Example: Check against a database or authentication service
    //    // For this example, let's assume a valid login for "user" with password "password"
    //    //return email == "user" && password == "password";
    //}



    private bool IsValidLogin(string email, string password)
    {
        return true;
    }

    private void SwitchToggle(object sender,
        ToggledEventArgs e)
    {
        InfoLabel.Text = $"Login Credentials are Saved";
    }
    private void OnCreateAccountTapped(object sender, EventArgs e)
    {
        // Navigate to the create account page
        // Example: await Navigation.PushAsync(new CreateAccountPage());
        Navigation.PushAsync(new CreateAccount());
    }

    private void OnForgetPassword(object sender, EventArgs e)
    {
        // Navigate to the create account page
        // Example: await Navigation.PushAsync(new CreateAccountPage());
        Navigation.PushAsync(new RecoverAccount());
    }
    public void Usersname(object sender, EventArgs e)
    {
        string email = emailEntry.Text;

    }
}

