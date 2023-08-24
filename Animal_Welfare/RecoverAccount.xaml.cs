namespace Animal_Welfare;

public partial class RecoverAccount : ContentPage
{
	public RecoverAccount()
	{
		InitializeComponent();
	}
    private void RecoverAccountBtn(object sender, EventArgs e)
    {
        DisplayAlert("Succussful", "A link has been send to your Mail id", "OK");
    }
}