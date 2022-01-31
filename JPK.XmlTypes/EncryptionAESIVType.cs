namespace JPK.XmlTypes
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://e-dokumenty.mf.gov.pl")]
    public partial class EncryptionAESIVType
    {

        private string bytesField;

        private string encodingField;

        private string valueField;

        public EncryptionAESIVType()
        {
            this.bytesField = "16";
            this.encodingField = "Base64";
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string bytes
        {
            get { return this.bytesField; }
            set { this.bytesField = value; }
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