namespace JPK_WysylkaXML.EditXML.XmlTypes.Version3_v7m.v1_1
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://crd.gov.pl/wzor/2020/03/06/9196/")]
    public partial class TNaglowek
    {

        private TNaglowekKodFormularza kodFormularzaField;

        private sbyte wariantFormularzaField;

        private System.DateTime dataWytworzeniaJPKField;

        private string nazwaSystemuField;

        private TNaglowekCelZlozenia celZlozeniaField;

        private TKodUS kodUrzeduField;

        private string rokField;

        private sbyte miesiacField;

        private TNaglowekKodFormularzaDekl kodFormularzaDeklField;

        private sbyte wariantFormularzaDeklField;

        /// <remarks/>
        public TNaglowekKodFormularza KodFormularza
        {
            get { return this.kodFormularzaField; }
            set { this.kodFormularzaField = value; }
        }

        /// <remarks/>
        public sbyte WariantFormularza
        {
            get { return this.wariantFormularzaField; }
            set { this.wariantFormularzaField = value; }
        }

        /// <remarks/>
        public System.DateTime DataWytworzeniaJPK
        {
            get { return this.dataWytworzeniaJPKField; }
            set { this.dataWytworzeniaJPKField = value; }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "token")]
        public string NazwaSystemu
        {
            get { return this.nazwaSystemuField; }
            set { this.nazwaSystemuField = value; }
        }

        /// <remarks/>
        public TNaglowekCelZlozenia CelZlozenia
        {
            get { return this.celZlozeniaField; }
            set { this.celZlozeniaField = value; }
        }

        /// <remarks/>
        public TKodUS KodUrzedu
        {
            get { return this.kodUrzeduField; }
            set { this.kodUrzeduField = value; }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "gYear")]
        public string Rok
        {
            get { return this.rokField; }
            set { this.rokField = value; }
        }

        /// <remarks/>
        public sbyte Miesiac
        {
            get { return this.miesiacField; }
            set { this.miesiacField = value; }
        }

        /// <remarks/>
        public TNaglowekKodFormularzaDekl KodFormularzaDekl
        {
            get { return this.kodFormularzaDeklField; }
            set { this.kodFormularzaDeklField = value; }
        }

        /// <remarks/>
        public sbyte WariantFormularzaDekl
        {
            get { return this.wariantFormularzaDeklField; }
            set { this.wariantFormularzaDeklField = value; }
        }
    }
}