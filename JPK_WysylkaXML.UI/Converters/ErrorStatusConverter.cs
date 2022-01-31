using System;
using System.Globalization;
using System.Windows.Data;
using System.Windows.Markup;
using JPK_WysylkaXML.UI.Providers;

namespace JPK_WysylkaXML.UI.Converters
{
    public class ErrorStatusConverter : MarkupExtension, IValueConverter
    {
        private readonly StatusProvider _statusProvider;

        private static ErrorStatusConverter _converter;

        public ErrorStatusConverter()
        {
            _statusProvider = new StatusProvider();
        }

        private ErrorStatusConverter(StatusProvider statusProvider)
        {
            _statusProvider = statusProvider;
        }

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var status = value as int? ?? 0;

            return _statusProvider.ErrorStatusList().Contains(status);
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }

        public override object ProvideValue(IServiceProvider serviceProvider)
        {
            return _converter ?? (_converter = new ErrorStatusConverter(new StatusProvider()));
        }
    }
}