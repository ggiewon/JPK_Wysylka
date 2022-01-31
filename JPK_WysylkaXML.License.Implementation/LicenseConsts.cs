using UnitSoftware.Helpers.Implementation.UnitTests;

namespace JPK_WysylkaXML.License
{
    [UnitTestExclude("This is simple class to store consts")]
    public class LicenseConsts
    {
        public static readonly string LicenseExtension = ".lic";

        public static readonly string LicenseFilter = "Pliki licencji (*.lic)|*.lic|Wszystkie pliki (*.*)|*.*";

        public static readonly string LicenseFolder = "License";

        public static readonly string JPK_WysylkaXMLType = "JPK_WysylkaXML";

        public static readonly string JPK_GeneratorXMLType = "JPK_GeneratorXML";
    }
}