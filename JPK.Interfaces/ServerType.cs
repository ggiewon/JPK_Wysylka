using System.ComponentModel;
using UnitSoftware.Common.Interfaces.Helpers.Attributes;

namespace JPK.Interfaces
{
    [System.SerializableAttribute()]
    public enum ServerType
    {
        [StringValue("P")]
        [Description("Produkcyjny")]
        Production,

        [StringValue("T")]
        [Description("Testowy")]
        Test
    }
}
