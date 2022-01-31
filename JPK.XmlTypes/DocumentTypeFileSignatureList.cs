namespace JPK.XmlTypes
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://e-dokumenty.mf.gov.pl")]
    public partial class DocumentTypeFileSignatureList : ArrayOfFileSignatureType
    {

        private int filesNumberField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int filesNumber
        {
            get { return this.filesNumberField; }
            set { this.filesNumberField = value; }
        }
    }
}