namespace JPK.XmlTypes
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://e-dokumenty.mf.gov.pl")]
    public partial class ArrayOfFileSignatureTypePackaging
    {

        private ArrayOfFileSignatureTypePackagingSplitZip itemField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("SplitZip")]
        public ArrayOfFileSignatureTypePackagingSplitZip Item
        {
            get { return this.itemField; }
            set { this.itemField = value; }
        }
    }
}