using ChatGPTRecipesApp.Models;

namespace ChatGPTRecipesApp.Services
{
    public class RecipeService
    {
        readonly List<Recipe> _recipes;

        public RecipeService()
        {
            // Initialize the list of recipes
            _recipes = new List<Recipe>
            {
                new Recipe
                {
                    Id = 1,
                    Name = "Classic Cheeseburger",
                    Description = "A classic cheeseburger with all the fixings.",
                    Ingredients = new List<string> { "ground beef", "cheddar cheese", "lettuce", "tomato", "onion", "ketchup", "mustard", "mayonnaise", "salt", "pepper", "hamburger buns" },
                    Directions = new List<string> { "Preheat grill to medium-high heat.", "Form beef into patties and season with salt and pepper.", "Grill patties for 3-4 minutes per side.", "Top with cheese and cook until melted.", "Serve on buns with lettuce, tomato, onion, and condiments of your choice." },
                    ImageUrl = "https://iambaker.net/wp-content/uploads/2019/05/cheeseburger-4-e1558391861585.jpg",
                    Rating = 4.5,
                    Category = "Main Dish",
                    IsFavorite = false
                },
                new Recipe
                {
                    Id = 2,
                    Name = "Spaghetti with Meat Sauce",
                    Description = "A classic pasta dish with a hearty meat sauce.",
                    Ingredients = new List<string> { "spaghetti", "ground beef", "onion", "garlic", "tomato sauce", "canned diced tomatoes", "Italian seasoning", "salt", "pepper" },
                    Directions = new List<string> { "Cook spaghetti according to package instructions.", "Brown beef in a large skillet over medium heat.", "Add onion and garlic and cook until softened.", "Add tomato sauce, diced tomatoes, Italian seasoning, salt, and pepper.", "Simmer for 15-20 minutes.", "Serve sauce over spaghetti." },
                    ImageUrl = "https://tmbidigitalassetsazure.blob.core.windows.net/rms3-prod/attachments/37/1200x1200/Meat-Sauce-for-Spaghetti_exps30680_SD2856494B12_11_5bC_RMS.jpg",
                    Rating = 4.2,
                    Category = "Main Dish",
                    IsFavorite = false
                },
                new Recipe
                {
                    Id = 3,
                    Name = "Chicken Fajitas",
                    Description = "A Tex-Mex favorite with seasoned chicken and peppers.",
                    Ingredients = new List<string> { "boneless chicken breasts", "red bell pepper", "green bell pepper", "onion", "fajita seasoning", "salt", "pepper", "tortillas", "sour cream", "guacamole", "salsa" },
                    Directions = new List<string> { "Season chicken with fajita seasoning, salt, and pepper.", "Cook chicken in a large skillet over medium-high heat.", "Add peppers and onion and cook until softened.", "Serve on tortillas with sour cream, guacamole, and salsa." },
                    ImageUrl = "https://www.foodandwine.com/thmb/ja3nlw1Mxefbc9ZcTFxJMgqaw54=/1500x0/filters:no_upscale():max_bytes(150000):strip_icc()/Easy-Chicken-Fajitas-FT-BLOG0822-2000-edc7c46e33e9444a81d60fc24bbbd69f.jpg",
                    Rating = 4.7,
                    Category = "Main Dish",
                    IsFavorite = true
                },
            };
        }

        public List<Recipe> GetRecipes()
        {
            // Return the first 10 recipes
            return _recipes.Take(10).ToList();
        }
    }

}
