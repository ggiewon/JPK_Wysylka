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
    [XmlType(AnonymousType = true, Namespace = "http://e-dokumenty.mf.gov.pl")]
    public class ArrayOfFileSignatureTypePackaging
    {

        private ArrayOfFileSignatureTypePackagingSplitZip itemField;

        /// <remarks/>
        [XmlElement("SplitZip")]
        public ArrayOfFileSignatureTypePackagingSplitZip Item
        {
            get { return itemField; }
            set { itemField = value; }
        }
    }
}