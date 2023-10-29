namespace Finance.Pages;

public partial class HomePage : ContentPage
{
	public HomePage(HomePageViewModel Model)
	{
		InitializeComponent();
        NavigationPage.SetHasNavigationBar(this, false);
		BindingContext = Model;
    }
}