namespace Animal_Welfare;

public partial class DashBoard : ContentPage
{
    
	public DashBoard()
	{
        
        InitializeComponent();
        //AccLabel.Text = $"Welcome";

    }
    private void searchBar_SearchButtonPressed(object sender, EventArgs e)
    {
        InfoLabel.Text = $"searching for {searchBar.Text}";
    }
    private void RadioButton_checked(object sender,
        CheckedChangedEventArgs e)
    {
        RadioButton sexBtn = sender as RadioButton;
        InfoLabel.Text = $"Showing results for {sexBtn.Content}";
    }
    private void SwipeItems_in(object sender, EventArgs e)
    {
        InfoLabel.Text = $"Added";
    }
    private void SwipeItems_out(object sender, EventArgs e)
    {
        InfoLabel.Text = $"Removed";
    }
    private void CartBtn(object sender, EventArgs e)
    {
       Navigation.PushAsync(new CartPage());
    }
}