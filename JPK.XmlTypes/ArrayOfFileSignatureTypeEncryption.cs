namespace JPK.XmlTypes
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://e-dokumenty.mf.gov.pl")]
    public partial class ArrayOfFileSignatureTypeEncryption
    {

        private ArrayOfFileSignatureTypeEncryptionAES itemField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("AES")]
        public ArrayOfFileSignatureTypeEncryptionAES Item
        {
            get { return this.itemField; }
            set { this.itemField = value; }
        }
    }
}