using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace JPK.XmlTypes
{
    /// <remarks/>
    [GeneratedCode("xsd", "4.0.30319.33440")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true, Namespace = "http://e-dokumenty.mf.gov.pl")]
    public class ArrayOfFileSignatureTypeEncryptionAES
    {
        private ArrayOfFileSignatureTypeEncryptionAESIV ivField;

        private int sizeField;

        private int blockField;

        private string modeField;

        private string paddingField;

        public ArrayOfFileSignatureTypeEncryptionAES()
        {
            sizeField = 256;
            blockField = 16;
            modeField = "CBC";
            paddingField = "PKCS#7";
        }

        /// <remarks/>
        public ArrayOfFileSignatureTypeEncryptionAESIV IV
        {
            get { return ivField; }
            set { ivField = value; }
        }

        /// <remarks/>
        [XmlAttribute]
        public int size
        {
            get { return sizeField; }
            set { sizeField = value; }
        }

        /// <remarks/>
        [XmlAttribute]
        public int block
        {
            get { return blockField; }
            set { blockField = value; }
        }

        /// <remarks/>
        [XmlAttribute]
        public string mode
        {
            get { return modeField; }
            set { modeField = value; }
        }

        /// <remarks/>
        [XmlAttribute]
        public string padding
        {
            get { return paddingField; }
            set { paddingField = value; }
        }
    }
}