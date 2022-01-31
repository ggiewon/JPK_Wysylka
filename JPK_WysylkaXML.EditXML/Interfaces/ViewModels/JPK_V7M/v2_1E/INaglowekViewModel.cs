using System;
using System.Collections.Generic;
using JPK_WysylkaXML.EditXML.XmlTypes.Version3_v7m.v2_1E;

namespace JPK_WysylkaXML.EditXML.Interfaces.ViewModels.JPK_V7M.v2_1E
{
    public interface INaglowekViewModel
    {
        sbyte WariantFormularza { get; set; }
        
        DateTime DataWytworzeniaJPK { get; set; }

        string NazwaSystemu { get; set; }

        TKodUS KodUrzedu { get; set; }

        string Rok { get; set; }

        sbyte Miesiac { get; set; }

        IEnumerable<Tuple<TKodUS, string>> KodUSItemList { get; }

        IEnumerable<sbyte> WariantFormularzaItemList { get; }
    }
}