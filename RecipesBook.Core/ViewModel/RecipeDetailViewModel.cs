using System;
using MvvmCross.ViewModels;
using RecipesBook.Core.DataModel;

namespace RecipesBook.Core.ViewModel
{
    public class RecipeDetailViewModel : MvxViewModel<Recipe>
    {
        public RecipeDetailViewModel()
        {
            
        }

        public override void Prepare(Recipe parameter)
        {
            var recipe = parameter;
            Method = recipe.Method;
            Name = recipe.Name;
            Duration = recipe.Duration;
            ImageUrl = recipe.ImageUrl;
            Difficulty = recipe.Difficulty;
            IngredientsText = recipe.IngredientsText;
        }

        private string method;
        public string Method
        {
            get => method; 
            set
            {
                SetProperty(ref method, value);
            }
        }

        private string name;
        public string Name
        {
            get => name; 
            set
            {
                SetProperty(ref name, value);
            }
        }

        private string ingredientsText;
        public string IngredientsText
        {
            get => ingredientsText;
            set
            {
                SetProperty(ref ingredientsText, value);
            }
        }

        private string duration;
        public string Duration
        {
            get => duration; 
            set
            {
                SetProperty(ref duration, value);
            }
        }

        private string difficulty;
        public string Difficulty
        {
            get => difficulty; 
            set
            {
                SetProperty(ref difficulty, value);
            }
        }

        private string imageUrl;
        public string ImageUrl
        {
            get => imageUrl; 
            set
            {
                SetProperty(ref imageUrl, value);
            }
        }
    }
}


