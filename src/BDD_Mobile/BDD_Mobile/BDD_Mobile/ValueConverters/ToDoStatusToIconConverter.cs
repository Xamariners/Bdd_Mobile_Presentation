using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BDDMobile.Shared.Enums;
using Xamarin.Forms;

namespace BDDMobile.ValueConverters
{
    public class TodoStatusToIconConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value != null)
            {
                if ((TodoStatus)value == TodoStatus.Open)
                {
                    return ImageSource.FromResource("BDDMobile.Resources.stateopen.png");
                }
                else if ((TodoStatus)value == TodoStatus.InProgress)
                {
                    return ImageSource.FromResource("BDDMobile.Resources.stateinprogress.png");
                }
                else if ((TodoStatus)value == TodoStatus.Closed)
                {
                    return ImageSource.FromResource("BDDMobile.Resources.stateclosed.png");
                }
            }

            return null;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
