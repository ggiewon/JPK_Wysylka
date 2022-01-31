using System;
using UnitSoftware.Helpers.Implementation.UnitTests;

namespace JPK_WysylkaXML.License.Exceptions
{
    [UnitTestExclude("Simple typed exception")]
    public class InvalidLicenseFileException : Exception
    {
        public InvalidLicenseFileException(string message) : base(message)
        {
        }
    }
}