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
    public class ArrayOfFileSignatureTypePackagingSplitZip
    {

        private string typeField;

        private string modeField;

        public ArrayOfFileSignatureTypePackagingSplitZip()
        {
            typeField = "split";
            modeField = "zip";
        }

        /// <remarks/>
        [XmlAttribute]
        public string type
        {
            get { return typeField; }
            set { typeField = value; }
        }

        /// <remarks/>
        [XmlAttribute]
        public string mode
        {
            get { return modeField; }
            set { modeField = value; }
        }
    }
}