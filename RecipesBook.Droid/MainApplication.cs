﻿using System;
using Android.App;
using Android.Runtime;
using MvvmCross.Droid.Support.V7.AppCompat;
using RecipesBook.Core;

namespace RecipesBook.Droid
{
    [Application]
    public class MainApplication : MvxAppCompatApplication<Setup, App>
    {
        public MainApplication()
        {
        }

        public MainApplication(IntPtr javaReference, JniHandleOwnership transfer)
            : base(javaReference, transfer)
        {
        }
    }
}
