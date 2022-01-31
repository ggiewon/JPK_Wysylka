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
    public class EncryptionKeyRSAType
    {

        private string algorithmField;

        private string modeField;

        private string paddingField;

        private string encodingField;

        private string valueField;

        public EncryptionKeyRSAType()
        {
            algorithmField = "RSA";
            modeField = "ECB";
            paddingField = "PKCS#1";
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
        public string mode
        {
            get { return modeField; }
            set { modeField = value; }
        }

        /// <remarks/>
        [XmlAttribute]
        public string padding
        {
            get { return paddingField; }
            set { paddingField = value; }
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