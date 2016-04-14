using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace TwitchViewer_WPF.Converter
{
    class DetailGridVisibilityConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            WelcomeGridVisibilityConverter converter = new WelcomeGridVisibilityConverter();

            object res = converter.Convert(value, targetType, parameter, culture);
            if (res is System.Windows.Visibility)
            {
                switch ((System.Windows.Visibility)res)
                {
                    case System.Windows.Visibility.Visible:
                        return System.Windows.Visibility.Hidden;
                    case System.Windows.Visibility.Hidden:
                        return System.Windows.Visibility.Visible;
                }
            }

            return System.Windows.Visibility.Visible;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
