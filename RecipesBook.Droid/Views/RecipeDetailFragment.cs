
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Util;
using Android.Views;
using Android.Widget;
using MvvmCross.Binding.BindingContext;
using MvvmCross.Droid.Support.V4;
using MvvmCross.Platforms.Android.Binding.BindingContext;
using MvvmCross.Platforms.Android.Presenters.Attributes;
using RecipesBook.Core.ViewModel;
namespace RecipesBook.Droid.Views
{
    [MvxFragmentPresentation(typeof(HomeViewModel),Resource.Id.detailview, AddToBackStack = true)]
    public class RecipeDetailFragment : MvxFragment<RecipeDetailViewModel>
    {
        public override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

        }

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            var ignored = base.OnCreateView(inflater, container, savedInstanceState);

            var view = this.BindingInflate(Resource.Layout.RecipeDetailLayout, container, false);

            Activity.Title = ViewModel.Name;

            return view;
        }
        public override void OnDestroy()
        {
            base.OnDestroy();
            Activity.Title = "Recipes";
        }
    }
}
