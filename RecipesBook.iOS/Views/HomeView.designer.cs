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
    [Register ("HomeView")]
    partial class HomeView
    {
        [Outlet]
        UIKit.UICollectionView collectionView { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (collectionView != null) {
                collectionView.Dispose ();
                collectionView = null;
            }
        }
    }
}