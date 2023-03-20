namespace ChatGPTRecipesApp.Models
{
    public class Recipe
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public List<string> Ingredients { get; set; }
        public List<string> Directions { get; set; }
        public string ImageUrl { get; set; }
        public double Rating { get; set; }
        public string Category { get; set; }
        public bool IsFavorite { get; set; }
    }

}
