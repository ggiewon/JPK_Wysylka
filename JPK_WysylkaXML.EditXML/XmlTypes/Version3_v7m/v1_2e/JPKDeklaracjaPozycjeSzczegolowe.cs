namespace JPK_WysylkaXML.EditXML.XmlTypes.Version3_v7m.v1_2E
{
    public partial class JPKDeklaracjaPozycjeSzczegolowe
    {
        private bool itemFieldSpecified;

        private bool p_59FieldSpecified;

        [System.Xml.Serialization.XmlIgnore]
        public bool ItemSpecified
        {
            get { return this.itemFieldSpecified; }
            set { this.itemFieldSpecified = value; }
        }

        [System.Xml.Serialization.XmlIgnore]
        public bool P_59Specified
        {
            get { return this.p_59FieldSpecified; }
            set { this.p_59FieldSpecified = value; }
        }
    }
}