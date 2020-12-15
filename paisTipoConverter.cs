using System;
using System.Globalization;
using System.Windows.Data;

namespace Comida_UT5_DINT
{
    class paisTipoConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            string pathImage = "";
            switch (value)
            {
                case "Americana":
                    pathImage = "united_states.png";
                    break;
                case "China":
                    pathImage = "china.png";
                    break;
                case "Mexicana":
                    pathImage = "mexico.png";
                    break;
            }
            return pathImage;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
