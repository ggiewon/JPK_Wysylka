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
    public class DocumentTypeFormCode
    {
        private string systemCodeField;

        private string schemaVersionField;

        private string valueField;

        /// <remarks/>
        [XmlAttribute]
        public string systemCode
        {
            get { return systemCodeField; }
            set { systemCodeField = value; }
        }

        /// <remarks/>
        [XmlAttribute]
        public string schemaVersion
        {
            get { return schemaVersionField; }
            set { schemaVersionField = value; }
        }

        /// <remarks/>
        [XmlText]
        public string Value
        {
            get { return valueField; }
            set { valueField = value; }
        }
    }
}