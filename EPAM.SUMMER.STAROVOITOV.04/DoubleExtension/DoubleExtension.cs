using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extensions
{
    /// <summary>
    /// Contains static method that convert double-precision floating point value to binary format.
    /// </summary>
    public static class DoubleExtension
    {
        /// <summary>
        /// Convert double-precision floating point value to IEEE 754 binary format.
        /// </summary>
        /// <param name="value">The number to convert.</param>
        /// <returns>String with number in IEEE 754 binary format.</returns>
        public static String ToIEEE754Format(this double value)
        {
            String result = String.Empty;
            byte[] bytes = BitConverter.GetBytes(value);
            for (int i = 7; i > -1; i--)
            {
                for (int j = 0; j < 8; j++)
                {
                    result += (bytes[i] & (128 >> j)) > 0 ? "1" : "0";
                }
            }
            return result;
        }
    }
}
