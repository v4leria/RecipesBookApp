// WARNING
//
// This file has been generated automatically by Visual Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using FFImageLoading.Cross;
using Foundation;
using System;
using System.CodeDom.Compiler;

namespace RecipesBook.iOS
{
    [Register ("CollectionViewCell")]
    partial class CollectionViewCell
    {
        [Outlet]
        MvxCachedImageView imageView { get; set; }

        [Outlet]
        UIKit.UILabel titleLabel { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (imageView != null) {
                imageView.Dispose ();
                imageView = null;
            }

            if (titleLabel != null) {
                titleLabel.Dispose ();
                titleLabel = null;
            }
        }
    }
}