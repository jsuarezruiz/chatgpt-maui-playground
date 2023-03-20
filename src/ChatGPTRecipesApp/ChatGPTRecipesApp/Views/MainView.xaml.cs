using ChatGPTRecipesApp.ViewModels;

namespace ChatGPTRecipesApp.Views;

public partial class MainView : ContentPage
{
	public MainView()
	{
		InitializeComponent();

		BindingContext = new MainViewModel();
	}
}