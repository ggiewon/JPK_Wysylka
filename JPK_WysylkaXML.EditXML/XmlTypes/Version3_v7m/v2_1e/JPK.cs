namespace JPK_WysylkaXML.EditXML.XmlTypes.Version3_v7m.v2_1E
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://crd.gov.pl/wzor/2021/12/27/11148/")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://crd.gov.pl/wzor/2021/12/27/11148/", IsNullable = false)]
    public partial class JPK
    {

        private JPKNaglowek naglowekField;

        private JPKPodmiot1 podmiot1Field;

        private JPKDeklaracja deklaracjaField;

        private JPKEwidencja ewidencjaField;

        /// <remarks/>
        public JPKNaglowek Naglowek
        {
            get { return this.naglowekField; }
            set { this.naglowekField = value; }
        }

        /// <remarks/>
        public JPKPodmiot1 Podmiot1
        {
            get { return this.podmiot1Field; }
            set { this.podmiot1Field = value; }
        }

        /// <remarks/>
        public JPKDeklaracja Deklaracja
        {
            get { return this.deklaracjaField; }
            set { this.deklaracjaField = value; }
        }

        /// <remarks/>
        public JPKEwidencja Ewidencja
        {
            get { return this.ewidencjaField; }
            set { this.ewidencjaField = value; }
        }
    }
}