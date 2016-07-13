using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Customer
{
    public class Customer: IFormattable
    {
        public string Name;
        public string ContactPhone;
        public decimal Revenue;

        public Customer(string name, string contactPhone, decimal revenue)
        {
            Name = name;
            ContactPhone = contactPhone;
            Revenue = revenue;
        }

        public string ToString(string format, IFormatProvider formatProvider)
        {
            if (String.IsNullOrEmpty(format)) format = "G";
            if (formatProvider == null) formatProvider = CultureInfo.InvariantCulture;
            if (format.Length == 1 && format != "G")
                throw new FormatException();
            if (format == "G")
                format = "NPR";
            if (format.Length > 3)
                throw new FormatException();

            StringBuilder result = new StringBuilder("Customer record: ");
            format.ToUpperInvariant();
            for (int i = 0; i < format.Length; i++)
            {
                if (!(format[i] == 'N' || format[i] == 'P' || format[i] == 'R'))
                {
                    throw new FormatException();
                }
                switch (format[i])
                {
                    case 'N':
                        result.AppendFormat(formatProvider, "{0:N}", Name);
                        result.Append(", ");
                        break;
                    case 'P':
                        result.AppendFormat(formatProvider, "{0:P}", ContactPhone);
                        result.Append(", ");
                        break;
                    case 'R':
                        result.AppendFormat(formatProvider, "{0}", Revenue);
                        result.Append(", ");
                        break;
                }
            }
            return result.Remove(result.Length - 2, 2).ToString();
        }

        public override string ToString()
        {
            return ToString("G", null);
        }
    }
}
