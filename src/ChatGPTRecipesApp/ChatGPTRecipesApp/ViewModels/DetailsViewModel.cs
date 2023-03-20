using ChatGPTRecipesApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatGPTRecipesApp.ViewModels
{
    internal class DetailsViewModel : BindableObject
    {
        private Recipe _recipe;

        public Recipe Recipe
        {
            get => _recipe;
            set
            {
                _recipe = value;
                OnPropertyChanged();
            }
        }

        public DetailsViewModel()
        {
            Recipe = new Recipe(); // create a new recipe object
        }

        public DetailsViewModel(Recipe recipe)
        {
            Recipe = recipe;
        }
    }
}