using System;
using MvvmCross;
using MvvmCross.IoC;
using MvvmCross.ViewModels;
using RecipesBook.Core.ViewModel;

namespace RecipesBook.Core
{
    public class App :  MvxApplication
    {
        public App()
        {
        }

        public override void Initialize()
        {
            CreatableTypes()
               .EndingWith("Service")
               .AsInterfaces()
               .RegisterAsLazySingleton();

            Mvx.LazyConstructAndRegisterSingleton<IRecipesManager, RecipesManager>();

            RegisterAppStart<HomeViewModel>();
        }
    }
}
