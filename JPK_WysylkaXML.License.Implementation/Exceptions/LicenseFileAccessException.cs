using System;
using UnitSoftware.Helpers.Implementation.UnitTests;

namespace JPK_WysylkaXML.License.Exceptions
{
    [UnitTestExclude("Simple typed exception")]
    public class LicenseFileAccessException : Exception
    {
        public LicenseFileAccessException(string message)
            : base(message)
        {
        }
    }
}