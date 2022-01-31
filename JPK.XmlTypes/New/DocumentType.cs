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
    public class DocumentType
    {

        private DocumentTypeFormCode formCodeField;

        private string fileNameField;

        private long contentLengthField;

        private DocumentTypeHashValue hashValueField;

        private DocumentTypeFileSignatureList fileSignatureListField;

        /// <remarks/>
        public DocumentTypeFormCode FormCode
        {
            get { return formCodeField; }
            set { formCodeField = value; }
        }

        /// <remarks/>
        public string FileName
        {
            get { return fileNameField; }
            set { fileNameField = value; }
        }

        /// <remarks/>
        public long ContentLength
        {
            get { return contentLengthField; }
            set { contentLengthField = value; }
        }

        /// <remarks/>
        public DocumentTypeHashValue HashValue
        {
            get { return hashValueField; }
            set { hashValueField = value; }
        }

        /// <remarks/>
        public DocumentTypeFileSignatureList FileSignatureList
        {
            get { return fileSignatureListField; }
            set { fileSignatureListField = value; }
        }
    }
}