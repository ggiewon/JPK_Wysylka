namespace JPK.XmlTypes
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://e-dokumenty.mf.gov.pl")]
    public partial class ArrayOfFileSignatureType
    {

        private ArrayOfFileSignatureTypePackaging packagingField;

        private ArrayOfFileSignatureTypeEncryption encryptionField;

        private FileSignatureType[] fileSignatureField;

        /// <remarks/>
        public ArrayOfFileSignatureTypePackaging Packaging
        {
            get { return this.packagingField; }
            set { this.packagingField = value; }
        }

        /// <remarks/>
        public ArrayOfFileSignatureTypeEncryption Encryption
        {
            get { return this.encryptionField; }
            set { this.encryptionField = value; }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("FileSignature")]
        public FileSignatureType[] FileSignature
        {
            get { return this.fileSignatureField; }
            set { this.fileSignatureField = value; }
        }
    }
}