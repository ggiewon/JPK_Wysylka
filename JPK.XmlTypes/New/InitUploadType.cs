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
    [XmlRoot("InitUpload", Namespace = "http://e-dokumenty.mf.gov.pl", IsNullable = false)]
    public class InitUploadType
    {
        private InitUploadTypeDocumentType documentTypeField;

        private string versionField;

        private InitUploadTypeEncryptionKey encryptionKeyField;

        private ArrayOfDocumentType documentListField;

        public InitUploadType()
        {
            versionField = "01.02.01.20160617";
        }

        /// <remarks/>
        public InitUploadTypeDocumentType DocumentType
        {
            get { return documentTypeField; }
            set { documentTypeField = value; }
        }

        /// <remarks/>
        public string Version
        {
            get { return versionField; }
            set { versionField = value; }
        }

        /// <remarks/>
        public InitUploadTypeEncryptionKey EncryptionKey
        {
            get { return encryptionKeyField; }
            set { encryptionKeyField = value; }
        }

        /// <remarks/>
        public ArrayOfDocumentType DocumentList
        {
            get { return documentListField; }
            set { documentListField = value; }
        }
    }
}