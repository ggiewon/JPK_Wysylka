using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace JPK.XmlTypes.New
{
    /// <remarks/>
    [GeneratedCode("xsd", "4.0.30319.33440")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategory("code")]
    [XmlType(Namespace = "http://e-dokumenty.mf.gov.pl")]
    public class HashValueSHAType
    {
        private string algorithmField;

        private string encodingField;

        private string valueField;

        public HashValueSHAType()
        {
            algorithmField = "SHA-256";
            encodingField = "Base64";
        }

        /// <remarks/>
        [XmlAttribute]
        public string algorithm
        {
            get { return algorithmField; }
            set { algorithmField = value; }
        }

        /// <remarks/>
        [XmlAttribute]
        public string encoding
        {
            get { return encodingField; }
            set { encodingField = value; }
        }

        /// <remarks/>
        [XmlText(DataType = "token")]
        public string Value
        {
            get { return valueField; }
            set { valueField = value; }
        }
    }
}