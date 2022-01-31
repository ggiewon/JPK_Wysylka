namespace JPK.XmlTypes
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://e-dokumenty.mf.gov.pl")]
    public partial class EncryptionKeyRSAType
    {

        private string algorithmField;

        private string modeField;

        private string paddingField;

        private string encodingField;

        private string valueField;

        public EncryptionKeyRSAType()
        {
            this.algorithmField = "RSA";
            this.modeField = "ECB";
            this.paddingField = "PKCS#1";
            this.encodingField = "Base64";
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string algorithm
        {
            get { return this.algorithmField; }
            set { this.algorithmField = value; }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string mode
        {
            get { return this.modeField; }
            set { this.modeField = value; }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string padding
        {
            get { return this.paddingField; }
            set { this.paddingField = value; }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string encoding
        {
            get { return this.encodingField; }
            set { this.encodingField = value; }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute(DataType = "token")]
        public string Value
        {
            get { return this.valueField; }
            set { this.valueField = value; }
        }
    }
}