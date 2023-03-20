using ChatGPTRecipesApp.Models;
using ChatGPTRecipesApp.Services;
using ChatGPTRecipesApp.Views;
using System.Windows.Input;

namespace ChatGPTRecipesApp.ViewModels
{
    public class MainViewModel : BindableObject
    {
        readonly RecipeService _recipeService;

        public ICommand ViewRecipeCommand { get; }

        public MainViewModel()
        {
            _recipeService = new RecipeService();

            ViewRecipeCommand = new Command<Recipe>(async recipe =>
            {
                await Application.Current.MainPage.Navigation.PushAsync(new DetailsView(recipe));
            });

            LoadRecipes();
        }

        void LoadRecipes()
        {
            var recipes = _recipeService.GetRecipes();
            Recipes = new List<Recipe>(recipes);
        }

        List<Recipe> _recipes;
        public List<Recipe> Recipes
        {
            get => _recipes;
            set
            {
                _recipes = value;
                OnPropertyChanged();
            }
        }
    }
}