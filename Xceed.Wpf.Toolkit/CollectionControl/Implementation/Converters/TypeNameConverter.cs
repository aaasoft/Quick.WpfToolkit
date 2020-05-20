using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Reflection;
using System.Linq;
using System.Text;
using System.Windows.Data;

namespace Xceed.Wpf.Toolkit.Converters
{
    public class TypeNameConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var type = value as Type;
            if (type == null)
                return null;
            var typeName = string.Join(" - ", type.GetCustomAttributes(typeof(DisplayNameAttribute), true)
                .Select(t => (DisplayNameAttribute)t)
                .Select(t => t.DisplayName));
            if (string.IsNullOrEmpty(typeName))
                typeName = type.Name;
            return typeName;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
