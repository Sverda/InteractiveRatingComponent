namespace InteractiveRatingComponent.Pages;

public partial class RatingPage : ContentPage
{
	public RatingPage()
	{
		InitializeComponent();
	}

	private async void Button_Clicked(object sender, EventArgs e)
	{
		await Navigation.PushAsync(new SubmittedRatingPage());
	}
}