using ChatGPTRecipesApp.Models;
using ChatGPTRecipesApp.ViewModels;

namespace ChatGPTRecipesApp.Views;

public partial class DetailsView : ContentPage
{
	public DetailsView(Recipe recipe)
	{
		InitializeComponent();

		BindingContext = new DetailsViewModel(recipe);
	}
}