using System;
using JPK_WysylkaXML.License.Interfaces;

namespace JPK_WysylkaXML.License
{
    [Serializable]
    public class License : ILicense
    {
        public string NIP { get; set; }

        public string Application { get; set; }

        public string Hash { get;  set; }
    }
}