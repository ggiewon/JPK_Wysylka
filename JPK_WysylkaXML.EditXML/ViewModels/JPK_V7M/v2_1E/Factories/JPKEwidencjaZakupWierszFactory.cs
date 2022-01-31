using System;
using System.Globalization;
using JPK_WysylkaXML.EditXML.XmlTypes.Version3_v7m.v2_1E;

namespace JPK_WysylkaXML.EditXML.ViewModels.JPK_V7M.v2_1E.Factories
{
    public class JPKEwidencjaZakupWierszFactory
    {
        private int kodKrajuNadaniaTINFieldIndex = 0;
        private int nrDostawcyFieldIndex = 1;
        private int nazwaDostawcyFieldIndex = 2;
        private int dowodZakupuFieldIndex = 3;
        private int dataZakupuFieldIndex = 4;
        private int dataWplywuFieldIndex = 5;
        private int dokumentZakupuFieldIndex = 6;
        private int mPPFieldIndex = 7;
        private int iMPFieldIndex = 8;
        private int k_40FieldIndex = 9;
        private int k_41FieldIndex = 10;
        private int k_42FieldIndex = 11;
        private int k_43FieldIndex = 12;
        private int k_44FieldIndex = 13;
        private int k_45FieldIndex = 14;
        private int k_46FieldIndex = 15;
        private int k_47FieldIndex = 16;
        private int zakupVAT_MarzaFieldIndex = 17;

        public JPKEwidencjaZakupWiersz Create(string line)
        {
            var singleValues = line.Split(';');

            for (var i = 0; i < singleValues.Length; i++)
            {
                singleValues[i] = singleValues[i].Trim();
            }

            var ewidencjaZakupWiersz = new JPKEwidencjaZakupWiersz
            {
                KodKrajuNadaniaTIN = singleValues[kodKrajuNadaniaTINFieldIndex],
                NrDostawcy = singleValues[nrDostawcyFieldIndex],
                NazwaDostawcy = singleValues[nazwaDostawcyFieldIndex],
                DowodZakupu = singleValues[dowodZakupuFieldIndex],
                DataZakupu = DateTime.ParseExact(singleValues[dataZakupuFieldIndex], "yyyyMMdd", new DateTimeFormatInfo()),
                K_40 = singleValues[k_40FieldIndex] != string.Empty ? decimal.Parse(singleValues[k_40FieldIndex]) : 0,
                K_41 = singleValues[k_41FieldIndex] != string.Empty ? decimal.Parse(singleValues[k_41FieldIndex]) : 0,
                K_42 = singleValues[k_42FieldIndex] != string.Empty ? decimal.Parse(singleValues[k_42FieldIndex]) : 0,
                K_43 = singleValues[k_43FieldIndex] != string.Empty ? decimal.Parse(singleValues[k_43FieldIndex]) : 0,
            };

            if (singleValues[dataWplywuFieldIndex] != string.Empty)
            {
                ewidencjaZakupWiersz.DataWplywu = DateTime.ParseExact(singleValues[dataWplywuFieldIndex], "yyyyMMdd", new DateTimeFormatInfo());
                ewidencjaZakupWiersz.DataWplywuSpecified = true;
            }

            if (singleValues[dokumentZakupuFieldIndex] != string.Empty)
            {
                ewidencjaZakupWiersz.DokumentZakupu = (TDowoduZakupu)int.Parse(singleValues[dokumentZakupuFieldIndex]);
                ewidencjaZakupWiersz.DokumentZakupuSpecified = true;
            }

            if (singleValues[iMPFieldIndex] != string.Empty)
            {
                ewidencjaZakupWiersz.IMP = sbyte.Parse(singleValues[iMPFieldIndex]);
                ewidencjaZakupWiersz.IMPSpecified = true;
            }

            if (singleValues[k_44FieldIndex] != string.Empty)
            {
                ewidencjaZakupWiersz.K_44 = decimal.Parse(singleValues[k_44FieldIndex]);
                ewidencjaZakupWiersz.K_44Specified = true;
            }

            if (singleValues[k_45FieldIndex] != string.Empty)
            {
                ewidencjaZakupWiersz.K_45 = decimal.Parse(singleValues[k_45FieldIndex]);
                ewidencjaZakupWiersz.K_45Specified = true;
            }
            
            if (singleValues[k_46FieldIndex] != string.Empty)
            {
                ewidencjaZakupWiersz.K_46 = decimal.Parse(singleValues[k_46FieldIndex]);
                ewidencjaZakupWiersz.K_46Specified = true;
            }

            if (singleValues[k_47FieldIndex] != string.Empty)
            {
                ewidencjaZakupWiersz.K_47 = decimal.Parse(singleValues[k_47FieldIndex]);
                ewidencjaZakupWiersz.K_47Specified = true;
            }

            if (singleValues[zakupVAT_MarzaFieldIndex] != string.Empty)
            {
                ewidencjaZakupWiersz.ZakupVAT_Marza = decimal.Parse(singleValues[zakupVAT_MarzaFieldIndex]);
                ewidencjaZakupWiersz.ZakupVAT_MarzaSpecified = true;
            }

            return ewidencjaZakupWiersz;
        }
    }
}