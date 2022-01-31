namespace JPK.XmlTypes
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://e-dokumenty.mf.gov.pl")]
    public partial class FileSignatureType
    {
        private int ordinalNumberField;

        private string fileNameField;

        private int contentLengthField;

        private FileSignatureTypeHashValue hashValueField;

        /// <remarks/>
        public int OrdinalNumber
        {
            get { return this.ordinalNumberField; }
            set { this.ordinalNumberField = value; }
        }

        /// <remarks/>
        public string FileName
        {
            get { return this.fileNameField; }
            set { this.fileNameField = value; }
        }

        /// <remarks/>
        public int ContentLength
        {
            get { return this.contentLengthField; }
            set { this.contentLengthField = value; }
        }

        /// <remarks/>
        public FileSignatureTypeHashValue HashValue
        {
            get { return this.hashValueField; }
            set { this.hashValueField = value; }
        }
    }
}