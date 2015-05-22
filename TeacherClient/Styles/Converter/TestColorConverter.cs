using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Data;
using System.Windows.Media;

namespace TeacherClient.Styles.Converter
{
    public class TestColorConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            string str = (string)value;
            if (str != null)
            {
                int i = int.Parse(str);
                if (i > 60)
                {
                    return new SolidColorBrush(Color.FromRgb(215, 255, 0));
                }
                else
                {
                    return new SolidColorBrush(Color.FromRgb(173, 37, 39));
                }
            }
            return new SolidColorBrush(Color.FromRgb(173, 37, 39)); ;
        }

        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            return null;
        }
    }
}
