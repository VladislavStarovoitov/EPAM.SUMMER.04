using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Customer
{
    public class CustomeProvider : IFormatProvider, ICustomFormatter
    {
        public string Format(string format, object arg, IFormatProvider formatProvider)
        {
            if (!(format == "N" || format == "P" || format == "R"))
                return string.Format("{0:" + format + "}", arg);
            StringBuilder result = new StringBuilder();
            switch (format)
            {
                case "N":
                    result.AppendFormat("name: {0}", arg);
                    break;
                case "P":
                    result.AppendFormat("contact phone: {0}", arg);
                    break;
                case "R":
                    result.AppendFormat("revenue: {0}", arg);
                    break;
            }
            return result.ToString();
        }

        public object GetFormat(Type formatType)
        {
            if (formatType == typeof(ICustomFormatter)) return this;
            return null;
        }
    }
}
