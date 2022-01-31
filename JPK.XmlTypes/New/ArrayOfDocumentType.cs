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
    public class ArrayOfDocumentType
    {
        private ArrayOfDocumentTypeDocument documentField;

        /// <remarks/>
        public ArrayOfDocumentTypeDocument Document
        {
            get { return documentField; }
            set { documentField = value; }
        }
    }
}