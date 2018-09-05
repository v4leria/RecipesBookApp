using Android.Content;
using Android.Widget;
using FFImageLoading.Cross;

namespace RecipesBook.Droid.Views
{
    public class SquareItem : FrameLayout
    {
        public SquareItem(Context context) : base(context)
        {
        }

        public SquareItem(Context context, Android.Util.IAttributeSet attrs) : base(context, attrs)
        {
        }
        protected override void OnMeasure(int widthMeasureSpec, int heightMeasureSpec)
        {
            base.OnMeasure(widthMeasureSpec, widthMeasureSpec);
        }
    }
}
