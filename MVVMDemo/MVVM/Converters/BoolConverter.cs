using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVMDemo.MVVM.Converters
{
     public class BoolConverter : IValueConverter
     {
          public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
          {
               var answer = value.ToString();
               if(answer == "YES")
               {
                    return true;
               }
               return false;
          }

          public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
          {
               var boolean = (bool)value;
               if(boolean)
               {
                    return "YES";
               }
               return "NO";
          }
     }
}
