using System;
using UnitSoftware.Helpers.Implementation.UnitTests;

namespace JPK_WysylkaXML.UI.Configuration.Exceptions
{
    [UnitTestExclude("This is only typed exception, nothing to test here")]
    public class InvalidConfigurationException : Exception
    {
        public InvalidConfigurationException(string message):  base(message)
        {            
        }
    }
}