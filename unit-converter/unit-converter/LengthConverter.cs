using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace unit_converter
{
    public class LengthConverter : Converter
    {
        public double convert(String from, String to, double value)
        {
            double baseValue = getBaseValue(from, value);
            double convertedValue = convertTo(to, baseValue);
            return convertedValue;

        }
        public double getBaseValue(String from, double value)
        {
            switch(from){
                case "meters":
                    return value;
                default:
                    return value;
            }

        }
        public double convertTo(String to, double baseValue)
        {
            switch (to)
            {
                case "meters":
                    return baseValue;
                default:
                    return baseValue;
            }
        }
    }
}
