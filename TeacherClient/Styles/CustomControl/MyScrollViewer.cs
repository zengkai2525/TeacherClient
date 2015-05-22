using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace TeacherClient.Styles.CustomControl
{
    public class MyScrollViewer : ScrollViewer
    {
        private bool IsMouseDown = false;
        private bool IsFirstDown = false;
        private Point customPoint;
        private Point point;
        private double d1;
        private double d2;
        protected override void OnPreviewMouseLeftButtonDown(MouseButtonEventArgs e)
        {
            IsMouseDown = true;
            IsFirstDown = true;
            customPoint = e.GetPosition(this);
            base.OnPreviewMouseLeftButtonDown(e);
        }


        protected override void OnPreviewMouseLeftButtonUp(MouseButtonEventArgs e)
        {
            IsMouseDown = false;
            IsFirstDown = false;
            base.OnPreviewMouseLeftButtonUp(e);
        }

        protected override void OnPreviewMouseMove(MouseEventArgs e)
        {

            if (IsMouseDown)
            {
                point = e.GetPosition(this);
                MoveX = point.Y;
            }
            base.OnPreviewMouseMove(e);
        }

        public double MoveX
        {
            get { return (double)GetValue(MoveXProperty); }
            set { SetValue(MoveXProperty, value); }
        }

        // Using a DependencyProperty as the backing store for MoveX.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty MoveXProperty =
            DependencyProperty.Register("MoveX", typeof(double), typeof(MyScrollViewer), new PropertyMetadata(OnScrollChanged));

        /// <summary>
        /// 鼠标拖动
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        static void OnScrollChanged(DependencyObject sender, DependencyPropertyChangedEventArgs e)
        {
            MyScrollViewer view = sender as MyScrollViewer;
            if (view != null)
            {
                if (view.IsFirstDown)
                {
                    view.d1 = (double)e.NewValue;
                    view.d2 = view.customPoint.Y;
                    double d3 = view.d2 - view.d1;
                    if (d3 != 0)
                    {

                        if (view.d2 > view.d1)
                        {
                            view.ScrollToVerticalOffset(view.VerticalOffset + 8);
                        }
                        else
                        {
                            view.ScrollToVerticalOffset(view.VerticalOffset - 8);
                        }
                    }
                    view.IsFirstDown = false;
                }
                else
                {
                    view.d1 = (double)e.NewValue;
                    view.d2 = (double)e.OldValue;
                    double d3 = view.d2 - view.d1;
                    if (d3 != 0)
                    {

                        if (view.d2 > view.d1)
                        {
                            view.ScrollToVerticalOffset(view.VerticalOffset + 8);
                        }
                        else
                        {
                            view.ScrollToVerticalOffset(view.VerticalOffset - 8);
                        }
                    }
                }
            }

        }

        protected override void OnManipulationBoundaryFeedback(ManipulationBoundaryFeedbackEventArgs e)
        {
            e.Handled = true;
        }



    }
}
