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
    public class EncryptionAESIVType
    {

        private string bytesField;

        private string encodingField;

        private string valueField;

        public EncryptionAESIVType()
        {
            bytesField = "16";
            encodingField = "Base64";
        }

        /// <remarks/>
        [XmlAttribute]
        public string bytes
        {
            get { return bytesField; }
            set { bytesField = value; }
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