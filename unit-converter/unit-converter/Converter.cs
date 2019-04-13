using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace unit_converter
{
    public abstract class Converter
    {
        public Converter()
        {
        }
        public abstract double convert(String from, String to, double value);
    }
}
