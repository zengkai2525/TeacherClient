using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;
using System.Windows.Media.Animation;

namespace TeacherClient.Utilities.Helper
{
    public class AnimationHelper
    {
        #region 单例

        private static AnimationHelper _instance;

        public static AnimationHelper Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new AnimationHelper();
                }
                return _instance;
            }
        }
        #endregion

        public void XMoveAnimation(UIElement element, double from, double to)
        {
            element.Visibility = Visibility.Visible;
            TranslateTransform translateTransform = new TranslateTransform();
            element.RenderTransform = translateTransform;

            Storyboard storyboard = new Storyboard();

            DoubleAnimation animationx = new DoubleAnimation { From = from, To = to, Duration = TimeSpan.FromMilliseconds(600) };

            Storyboard.SetTarget(animationx, element);
            Storyboard.SetTargetProperty(animationx, new PropertyPath("(UIElement.RenderTransform).(TranslateTransform.X)"));
            storyboard.Children.Add(animationx);

            storyboard.Begin();
        }

        public void PopScaleAnimation(UIElement element, double from, double to)
        {
            element.Visibility = Visibility.Visible;
            TransformGroup translateTransform = new TransformGroup();
            element.RenderTransform = translateTransform;
            translateTransform.Children.Add(new ScaleTransform());
            Storyboard storyboard = new Storyboard();

            DoubleAnimation animationx1 = new DoubleAnimation { From = from, To = to, Duration = TimeSpan.FromSeconds(1) };

            Storyboard.SetTarget(animationx1, element);
            Storyboard.SetTargetProperty(animationx1, new PropertyPath("(UIElement.RenderTransform).(TransformGroup.Children)[0].(ScaleTransform.ScaleX)"));
            storyboard.Children.Add(animationx1);
            DoubleAnimation animationx2 = new DoubleAnimation { From = from, To = to, Duration = TimeSpan.FromSeconds(1) };
            Storyboard.SetTarget(animationx2, element);
            Storyboard.SetTargetProperty(animationx2,
                new PropertyPath("(UIElement.RenderTransform).(TransformGroup.Children)[0].(ScaleTransform.ScaleY)"));
            storyboard.Children.Add(animationx2);

            storyboard.Begin();

        }

        //private void HideOtherWin()
        //{
        //    TestingView.Testing.Visibility = Visibility.Hidden;
        //    TestResultView.TestResult.Visibility = Visibility.Hidden;
        //    HistoryView.history.Visibility = Visibility.Hidden;
        //    TestMainView.TestMain.Visibility = Visibility.Hidden;
        //}
    }
}
