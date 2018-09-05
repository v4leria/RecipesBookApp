using Foundation;
using UIKit;
using MvvmCross.Platforms.Ios.Core;

namespace RecipesBook.iOS
{
    // The UIApplicationDelegate for the application. This class is responsible for launching the
    // User Interface of the application, as well as listening (and optionally responding) to application events from iOS.
    [Register("AppDelegate")]
    public class AppDelegate : MvxApplicationDelegate<MvxIosSetup<RecipesBook.Core.App>,Core.App>
    {
       
        public override bool FinishedLaunching(UIApplication application, NSDictionary launchOptions)
        {
            base.FinishedLaunching(application, launchOptions);
            UINavigationBar.Appearance.BarTintColor = UIColor.FromRGB(224, 147, 30);
            UINavigationBar.Appearance.TintColor = UIColor.White;
            UINavigationBar.Appearance.TitleTextAttributes = new UIStringAttributes() { ForegroundColor = UIColor.White, Font = UIFont.BoldSystemFontOfSize(19f) };
            UINavigationBar.Appearance.Translucent = false;
            return true;
        }
    }
}

