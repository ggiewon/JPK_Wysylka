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
    public class ArrayOfFileSignatureType
    {

        private ArrayOfFileSignatureTypePackaging packagingField;

        private ArrayOfFileSignatureTypeEncryption encryptionField;

        private FileSignatureType[] fileSignatureField;

        /// <remarks/>
        public ArrayOfFileSignatureTypePackaging Packaging
        {
            get { return packagingField; }
            set { packagingField = value; }
        }

        /// <remarks/>
        public ArrayOfFileSignatureTypeEncryption Encryption
        {
            get { return encryptionField; }
            set { encryptionField = value; }
        }

        /// <remarks/>
        [XmlElement("FileSignature")]
        public FileSignatureType[] FileSignature
        {
            get { return fileSignatureField; }
            set { fileSignatureField = value; }
        }
    }
}