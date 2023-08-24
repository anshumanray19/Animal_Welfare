namespace Animal_Welfare;

public partial class CreateAccount : ContentPage
{
	public CreateAccount()
	{
		InitializeComponent();
	}
    private void CheckBox_checked(object sender,
       CheckedChangedEventArgs e)
    {
        InfoLabel.Text = $"its checked toggle {e.Value}";
    }
    private void AccountCreated(object sender, EventArgs e)
    {
        DisplayAlert("Congratulations", "Your Account Has Been Created", "OK");
    }
}