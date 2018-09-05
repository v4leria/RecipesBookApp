using System;
using MvvmCross.ViewModels;
using System.Collections.Generic;
using RecipesBook.Core.DataModel;
using MvvmCross.Commands;
using MvvmCross.Navigation;
using System.Threading.Tasks;

namespace RecipesBook.Core.ViewModel
{
    public class HomeViewModel : MvxViewModel
    {
        public IMvxNavigationService MvxNavigationService { get; set; }
        public IRecipesManager _manager { get; set; }

        public HomeViewModel(IMvxNavigationService mvxNavigationService, IRecipesManager manager)
        {
            MvxNavigationService = mvxNavigationService;
            _manager = manager;
        }

        List<Recipe> recipes;
        public List<Recipe> Recipes
        {
            get => recipes;

            set
            {
                SetProperty(ref recipes, value);
            }
        }

        private MvxAsyncCommand<Recipe> showRecipeDetailCommand;
        public MvxAsyncCommand<Recipe> ShowRecipeDetailCommand
        {
            get
            {
                return showRecipeDetailCommand ?? new MvxAsyncCommand<Recipe>(async (Recipe arg) =>
                {

                    await MvxNavigationService.Navigate(typeof(RecipeDetailViewModel), arg);
                });
            }

         
        }

        public override void Prepare()
        {

            Task.Run(async () =>
            {
                Recipes = await _manager.GetRecipesAsync();
            });

        }
    }
}
