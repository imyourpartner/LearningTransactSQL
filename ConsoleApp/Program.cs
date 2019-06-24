using System;
using System.Collections.Generic; // Collecciones genericas
using System.Linq; // LinQ

namespace ConsoleApp
{
    class Recipe
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
    class Review
    {
        public int RecipeId { get; set; }
        public string ReviewText { get; set; }
    }
    class Program
    {
        static void Main()
        {
            Recipe[] recipes = 
            {
                new Recipe { Id = 1, Name = "Mashed Potato" },
                new Recipe { Id = 2, Name = "Crispy Duck" },
                new Recipe { Id = 3, Name = "Sachertorte" }
            };

            Review[] reviews = 
            {
                new Review { RecipeId = 1, ReviewText = "Tasty!" },
                new Review { RecipeId = 1, ReviewText = "Not nice :(" },
                new Review { RecipeId = 1, ReviewText = "Pretty good" },
                new Review { RecipeId = 2, ReviewText = "Too hard" },
                new Review { RecipeId = 2, ReviewText = "Loved it" }
            };

            var query = from recipe in recipes
                        join review in reviews on recipe.Id equals review.RecipeId into reviewGroup
                        select new // anonymous type 
                        {
                            RecipeName = recipe.Name, Reviews = reviewGroup // collection of related reviews 
                        };

            foreach (var item in query)
            {
                Console.WriteLine("Reviews for {0}", item.RecipeName);

                foreach (var review in item.Reviews)
                {
                    Console.WriteLine(" - {0}", review.ReviewText);
                }
            }
        }
    }
}