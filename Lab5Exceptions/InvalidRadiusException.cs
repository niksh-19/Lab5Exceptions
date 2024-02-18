using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5Exceptions
{
    public class InvalidRadiusException : Exception
    {
        public InvalidRadiusException() : base("Radius must be greater than zero.") { }

        public InvalidRadiusException(double radius) : base($"Radius {radius} is not valid. It must be greater than zero.") { }
    }
}
