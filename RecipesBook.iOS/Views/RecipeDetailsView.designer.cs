// WARNING
//
// This file has been generated automatically by Visual Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;

namespace RecipesBook.iOS
{
    [Register ("RecipeDetailsView")]
    partial class RecipeDetailsView
    {
        [Outlet]
        UIKit.UILabel difficultyLabel { get; set; }

        [Outlet]
        UIKit.UILabel durationLabel { get; set; }

        [Outlet]
        FFImageLoading.Cross.MvxCachedImageView imageRecipe { get; set; }

        [Outlet]
        UIKit.UILabel ingredientsList { get; set; }

        [Outlet]
        UIKit.UILabel methodLabel { get; set; }

        [Outlet]
        UIKit.UIScrollView scrollView { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (difficultyLabel != null) {
                difficultyLabel.Dispose ();
                difficultyLabel = null;
            }

            if (durationLabel != null) {
                durationLabel.Dispose ();
                durationLabel = null;
            }

            if (imageRecipe != null) {
                imageRecipe.Dispose ();
                imageRecipe = null;
            }

            if (ingredientsList != null) {
                ingredientsList.Dispose ();
                ingredientsList = null;
            }

            if (methodLabel != null) {
                methodLabel.Dispose ();
                methodLabel = null;
            }

            if (scrollView != null) {
                scrollView.Dispose ();
                scrollView = null;
            }
        }
    }
}