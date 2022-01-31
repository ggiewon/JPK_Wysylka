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
    public class FileSignatureType
    {

        private int ordinalNumberField;

        private string fileNameField;

        private int contentLengthField;

        private FileSignatureTypeHashValue hashValueField;

        /// <remarks/>
        public int OrdinalNumber
        {
            get { return ordinalNumberField; }
            set { ordinalNumberField = value; }
        }

        /// <remarks/>
        public string FileName
        {
            get { return fileNameField; }
            set { fileNameField = value; }
        }

        /// <remarks/>
        public int ContentLength
        {
            get { return contentLengthField; }
            set { contentLengthField = value; }
        }

        /// <remarks/>
        public FileSignatureTypeHashValue HashValue
        {
            get { return hashValueField; }
            set { hashValueField = value; }
        }
    }
}