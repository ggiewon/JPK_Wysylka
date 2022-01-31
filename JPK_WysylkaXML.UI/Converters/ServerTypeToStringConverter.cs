using System;
using System.Globalization;
using System.Windows.Data;
using JPK.Interfaces;

namespace JPK_WysylkaXML.UI.Converters
{
    [ValueConversion(typeof(ServerType), typeof(string))]
    public class ServerTypeToStringConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var serverType = (ServerType)value;

            switch (serverType)
            {
                case ServerType.Production:
                    return "Produkcja";
                case ServerType.Test:
                    return "Test";
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}