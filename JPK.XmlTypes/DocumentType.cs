namespace JPK.XmlTypes
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://e-dokumenty.mf.gov.pl")]
    public partial class DocumentType
    {

        private DocumentTypeFormCode formCodeField;

        private string fileNameField;

        private long contentLengthField;

        private DocumentTypeHashValue hashValueField;

        private DocumentTypeFileSignatureList fileSignatureListField;

        /// <remarks/>
        public DocumentTypeFormCode FormCode
        {
            get { return this.formCodeField; }
            set { this.formCodeField = value; }
        }

        /// <remarks/>
        public string FileName
        {
            get { return this.fileNameField; }
            set { this.fileNameField = value; }
        }

        /// <remarks/>
        public long ContentLength
        {
            get { return this.contentLengthField; }
            set { this.contentLengthField = value; }
        }

        /// <remarks/>
        public DocumentTypeHashValue HashValue
        {
            get { return this.hashValueField; }
            set { this.hashValueField = value; }
        }

        /// <remarks/>
        public DocumentTypeFileSignatureList FileSignatureList
        {
            get { return this.fileSignatureListField; }
            set { this.fileSignatureListField = value; }
        }
    }
}