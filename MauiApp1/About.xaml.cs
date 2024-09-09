namespace MauiApp1;

public partial class About : ContentPage
{
	public About()
	{
        InitializeComponent();
    }

    private async void OnNavigationClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new MainPage());
    }
    private void OnBtnClicked(object sender, EventArgs e)
    {
        var button = (Button)sender;
        if (button.BackgroundColor == Colors.Red)
        {
            button.BackgroundColor = Colors.Blue;
            button.Text = "Blue";
        }
        else
        {
            button.BackgroundColor = Colors.Red;
            button.Text = "Red";
        }
    }
}