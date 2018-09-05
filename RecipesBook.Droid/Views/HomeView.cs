
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.OS;
using Android.Runtime;
using Android.Support.V7.Widget;
using MvvmCross.Droid.Support.V7.AppCompat;
using MvvmCross.Droid.Support.V7.RecyclerView;
using MvvmCross.Platforms.Android.Views;
using RecipesBook.Core.ViewModel;

namespace RecipesBook.Droid.Views
{
    [Activity(Label = "Recipes",Theme ="@style/AppTheme")]
    public class HomeView : MvxAppCompatActivity<HomeViewModel>
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.HomeLayout);

            var recyclerView = this.FindViewById<MvxRecyclerView>(Resource.Id.recycler_view);
            recyclerView.SetLayoutManager(new GridLayoutManager(this, 2));
        }
    }
}
