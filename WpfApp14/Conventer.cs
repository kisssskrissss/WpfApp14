using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Data;

namespace WpfApp14
{
    class Conventer:IValueConverter
    {
      

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if ((ProdCathegorys)value == ProdCathegorys.Gena)
            {
                return "Гена";
            }
            return "Лена";
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return DependencyProperty.UnsetValue;
        }
    }
}
