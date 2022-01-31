using System;
using System.Globalization;
using System.Reflection;
using JPK_WysylkaXML.EditXML.XmlTypes.Version3_v7m.v2_1E;

namespace JPK_WysylkaXML.EditXML.ViewModels.JPK_V7M.v2_1E.Factories
{
    public class JPKEwidencjaSprzedazWierszFactory
    {
        private int kodKrajuNadaniaTINFieldIndex = 0;
        private int nrKontrahentaFieldIndex = 1;
        private int nazwaKontrahentaFieldIndex = 2;
        private int dowodSprzedazyFieldIndex = 3;
        private int dataWystawieniaFieldIndex = 4;
        private int dataSprzedazyFieldIndex = 5;
        private int typDokumentuFieldIndex = 6;

        private int gTU_01FieldIndex = 7;
        private int gTU_02FieldIndex = 8;
        private int gTU_03FieldIndex = 9;
        private int gTU_04FieldIndex = 10;
        private int gTU_05FieldIndex = 11;
        private int gTU_06FieldIndex = 12;
        private int gTU_07FieldIndex = 13;
        private int gTU_08FieldIndex = 14;
        private int gTU_09FieldIndex = 15;
        private int gTU_10FieldIndex = 16;
        private int gTU_11FieldIndex = 17;
        private int gTU_12FieldIndex = 18;
        private int gTU_13FieldIndex = 19;

        private int wsto_eeFieldIndex = 20;
        private int iedFieldIndex = 21;
        private int tpFieldIndex = 22;
        private int tT_WNTFieldIndex = 23;
        private int tT_DFieldIndex = 24;
        private int mR_TFieldIndex = 25;
        private int mR_UZFieldIndex = 26;


        private int i_42Field = 27;
        private int i_63Field = 28;
        private int b_SPVField = 29;
        private int b_SPV_DOSTAWAField =30;
        private int b_MPV_PROWIZJAField=31;
        
        private int korektaPodstawyOpodtField=32;

        private int rodzajDatyField = 33;
        private int dataField = 34;

        private int k_10FieldIndex = 35;
        private int k_11FieldIndex = 36;
        private int k_12FieldIndex = 37;
        private int k_13FieldIndex = 38;
        private int k_14FieldIndex = 39;
        private int k_15FieldIndex = 40;
        private int k_16FieldIndex = 41;
        private int k_17FieldIndex = 42;
        private int k_18FieldIndex = 43;
        private int k_19FieldIndex = 44;
        private int k_20FieldIndex = 45;
        private int k_21FieldIndex = 46;
        private int k_22FieldIndex = 47;
        private int k_23FieldIndex = 48;
        private int k_24FieldIndex = 49;
        private int k_25FieldIndex = 50;
        private int k_26FieldIndex = 51;
        private int k_27FieldIndex = 52;
        private int k_28FieldIndex = 53;
        private int k_29FieldIndex = 54;
        private int k_30FieldIndex = 55;
        private int k_31FieldIndex = 56;
        private int k_32FieldIndex = 57;
        private int k_33FieldIndex = 58;
        private int k_34FieldIndex = 59;
        private int k_35FieldIndex = 60;
        private int k_36FieldIndex = 61;
        private int sprzedazVAT_MarzaFieldIndex = 62;

        public JPKEwidencjaSprzedazWiersz Create(string line)
        {
            var singleValues = line.Split(';');

            for (var i = 0; i < singleValues.Length; i++)
            {
                singleValues[i] = singleValues[i].Trim();
            }

            var ewidencjaSprzedazWiersz = new JPKEwidencjaSprzedazWiersz()
            {
                KodKrajuNadaniaTIN = singleValues[kodKrajuNadaniaTINFieldIndex],
                NrKontrahenta = singleValues[nrKontrahentaFieldIndex],
                NazwaKontrahenta = singleValues[nazwaKontrahentaFieldIndex],
                DowodSprzedazy = singleValues[dowodSprzedazyFieldIndex],
                DataWystawienia = DateTime.ParseExact(singleValues[dataWystawieniaFieldIndex], "yyyyMMdd", new DateTimeFormatInfo()),
            };

            if (singleValues[dataSprzedazyFieldIndex] != string.Empty)
            {
                ewidencjaSprzedazWiersz.DataSprzedazy = DateTime.ParseExact(singleValues[dataSprzedazyFieldIndex], "yyyyMMdd", new DateTimeFormatInfo());
                ewidencjaSprzedazWiersz.DataSprzedazySpecified = true;
            }

            if (singleValues[typDokumentuFieldIndex] != string.Empty)
            {
                ewidencjaSprzedazWiersz.TypDokumentu = (TDowoduSprzedazy)int.Parse(singleValues[typDokumentuFieldIndex]);
                ewidencjaSprzedazWiersz.TypDokumentuSpecified = true;
            }
            
            SetSbyteValue(ewidencjaSprzedazWiersz, nameof(ewidencjaSprzedazWiersz.GTU_01), singleValues[gTU_01FieldIndex]);
            SetSbyteValue(ewidencjaSprzedazWiersz, nameof(ewidencjaSprzedazWiersz.GTU_02), singleValues[gTU_02FieldIndex]);
            SetSbyteValue(ewidencjaSprzedazWiersz, nameof(ewidencjaSprzedazWiersz.GTU_03), singleValues[gTU_03FieldIndex]);
            SetSbyteValue(ewidencjaSprzedazWiersz, nameof(ewidencjaSprzedazWiersz.GTU_04), singleValues[gTU_04FieldIndex]);
            SetSbyteValue(ewidencjaSprzedazWiersz, nameof(ewidencjaSprzedazWiersz.GTU_05), singleValues[gTU_05FieldIndex]);
            SetSbyteValue(ewidencjaSprzedazWiersz, nameof(ewidencjaSprzedazWiersz.GTU_06), singleValues[gTU_06FieldIndex]);
            SetSbyteValue(ewidencjaSprzedazWiersz, nameof(ewidencjaSprzedazWiersz.GTU_07), singleValues[gTU_07FieldIndex]);
            SetSbyteValue(ewidencjaSprzedazWiersz, nameof(ewidencjaSprzedazWiersz.GTU_08), singleValues[gTU_08FieldIndex]);
            SetSbyteValue(ewidencjaSprzedazWiersz, nameof(ewidencjaSprzedazWiersz.GTU_09), singleValues[gTU_09FieldIndex]);
            SetSbyteValue(ewidencjaSprzedazWiersz, nameof(ewidencjaSprzedazWiersz.GTU_10), singleValues[gTU_10FieldIndex]);
            SetSbyteValue(ewidencjaSprzedazWiersz, nameof(ewidencjaSprzedazWiersz.GTU_11), singleValues[gTU_11FieldIndex]);
            SetSbyteValue(ewidencjaSprzedazWiersz, nameof(ewidencjaSprzedazWiersz.GTU_12), singleValues[gTU_12FieldIndex]);
            SetSbyteValue(ewidencjaSprzedazWiersz, nameof(ewidencjaSprzedazWiersz.GTU_13), singleValues[gTU_13FieldIndex]);

            SetSbyteValue(ewidencjaSprzedazWiersz, nameof(ewidencjaSprzedazWiersz.WSTO_EE), singleValues[wsto_eeFieldIndex]);
            SetSbyteValue(ewidencjaSprzedazWiersz, nameof(ewidencjaSprzedazWiersz.IED), singleValues[iedFieldIndex]);
            SetSbyteValue(ewidencjaSprzedazWiersz, nameof(ewidencjaSprzedazWiersz.TP), singleValues[tpFieldIndex]);
            SetSbyteValue(ewidencjaSprzedazWiersz, nameof(ewidencjaSprzedazWiersz.TT_WNT), singleValues[tT_WNTFieldIndex]);
            SetSbyteValue(ewidencjaSprzedazWiersz, nameof(ewidencjaSprzedazWiersz.TT_D), singleValues[tT_DFieldIndex]);
            SetSbyteValue(ewidencjaSprzedazWiersz, nameof(ewidencjaSprzedazWiersz.MR_T), singleValues[mR_TFieldIndex]);
            SetSbyteValue(ewidencjaSprzedazWiersz, nameof(ewidencjaSprzedazWiersz.MR_UZ), singleValues[mR_UZFieldIndex]);
            
            SetSbyteValue(ewidencjaSprzedazWiersz, nameof(ewidencjaSprzedazWiersz.I_42), singleValues[i_42Field]);
            SetSbyteValue(ewidencjaSprzedazWiersz, nameof(ewidencjaSprzedazWiersz.I_63), singleValues[i_63Field]);
            SetSbyteValue(ewidencjaSprzedazWiersz, nameof(ewidencjaSprzedazWiersz.B_SPV), singleValues[b_SPVField]);
            SetSbyteValue(ewidencjaSprzedazWiersz, nameof(ewidencjaSprzedazWiersz.B_SPV_DOSTAWA), singleValues[b_SPV_DOSTAWAField]);
            SetSbyteValue(ewidencjaSprzedazWiersz, nameof(ewidencjaSprzedazWiersz.B_MPV_PROWIZJA), singleValues[b_MPV_PROWIZJAField]);
            SetSbyteValue(ewidencjaSprzedazWiersz, nameof(ewidencjaSprzedazWiersz.KorektaPodstawyOpodt), singleValues[korektaPodstawyOpodtField]);

            SetSbyteValue(ewidencjaSprzedazWiersz, nameof(ewidencjaSprzedazWiersz.ItemElementName), singleValues[rodzajDatyField]);
            SetDateTimeValue(ewidencjaSprzedazWiersz, nameof(ewidencjaSprzedazWiersz.Item), singleValues[dataField]);

            SetDecimalValue(ewidencjaSprzedazWiersz, nameof(ewidencjaSprzedazWiersz.K_10), singleValues[k_10FieldIndex]);
            SetDecimalValue(ewidencjaSprzedazWiersz, nameof(ewidencjaSprzedazWiersz.K_11), singleValues[k_11FieldIndex]);
            SetDecimalValue(ewidencjaSprzedazWiersz, nameof(ewidencjaSprzedazWiersz.K_12), singleValues[k_12FieldIndex]);
            SetDecimalValue(ewidencjaSprzedazWiersz, nameof(ewidencjaSprzedazWiersz.K_13), singleValues[k_13FieldIndex]);
            SetDecimalValue(ewidencjaSprzedazWiersz, nameof(ewidencjaSprzedazWiersz.K_14), singleValues[k_14FieldIndex]);
            SetDecimalValue(ewidencjaSprzedazWiersz, nameof(ewidencjaSprzedazWiersz.K_15), singleValues[k_15FieldIndex]);
            SetDecimalValue(ewidencjaSprzedazWiersz, nameof(ewidencjaSprzedazWiersz.K_16), singleValues[k_16FieldIndex]);
            SetDecimalValue(ewidencjaSprzedazWiersz, nameof(ewidencjaSprzedazWiersz.K_17), singleValues[k_17FieldIndex]);
            SetDecimalValue(ewidencjaSprzedazWiersz, nameof(ewidencjaSprzedazWiersz.K_18), singleValues[k_18FieldIndex]);
            SetDecimalValue(ewidencjaSprzedazWiersz, nameof(ewidencjaSprzedazWiersz.K_19), singleValues[k_19FieldIndex]);
            SetDecimalValue(ewidencjaSprzedazWiersz, nameof(ewidencjaSprzedazWiersz.K_20), singleValues[k_20FieldIndex]);
            SetDecimalValue(ewidencjaSprzedazWiersz, nameof(ewidencjaSprzedazWiersz.K_21), singleValues[k_21FieldIndex]);
            SetDecimalValue(ewidencjaSprzedazWiersz, nameof(ewidencjaSprzedazWiersz.K_22), singleValues[k_22FieldIndex]);
            SetDecimalValue(ewidencjaSprzedazWiersz, nameof(ewidencjaSprzedazWiersz.K_23), singleValues[k_23FieldIndex]);
            SetDecimalValue(ewidencjaSprzedazWiersz, nameof(ewidencjaSprzedazWiersz.K_24), singleValues[k_24FieldIndex]);
            SetDecimalValue(ewidencjaSprzedazWiersz, nameof(ewidencjaSprzedazWiersz.K_25), singleValues[k_25FieldIndex]);
            SetDecimalValue(ewidencjaSprzedazWiersz, nameof(ewidencjaSprzedazWiersz.K_26), singleValues[k_26FieldIndex]);
            SetDecimalValue(ewidencjaSprzedazWiersz, nameof(ewidencjaSprzedazWiersz.K_27), singleValues[k_27FieldIndex]);
            SetDecimalValue(ewidencjaSprzedazWiersz, nameof(ewidencjaSprzedazWiersz.K_28), singleValues[k_28FieldIndex]);
            SetDecimalValue(ewidencjaSprzedazWiersz, nameof(ewidencjaSprzedazWiersz.K_29), singleValues[k_29FieldIndex]);
            SetDecimalValue(ewidencjaSprzedazWiersz, nameof(ewidencjaSprzedazWiersz.K_30), singleValues[k_30FieldIndex]);
            SetDecimalValue(ewidencjaSprzedazWiersz, nameof(ewidencjaSprzedazWiersz.K_31), singleValues[k_31FieldIndex]);
            SetDecimalValue(ewidencjaSprzedazWiersz, nameof(ewidencjaSprzedazWiersz.K_32), singleValues[k_32FieldIndex]);
            SetDecimalValue(ewidencjaSprzedazWiersz, nameof(ewidencjaSprzedazWiersz.K_33), singleValues[k_33FieldIndex]);
            SetDecimalValue(ewidencjaSprzedazWiersz, nameof(ewidencjaSprzedazWiersz.K_34), singleValues[k_34FieldIndex]);
            SetDecimalValue(ewidencjaSprzedazWiersz, nameof(ewidencjaSprzedazWiersz.K_35), singleValues[k_35FieldIndex]);
            SetDecimalValue(ewidencjaSprzedazWiersz, nameof(ewidencjaSprzedazWiersz.K_36), singleValues[k_36FieldIndex]);

            SetDecimalValue(ewidencjaSprzedazWiersz, nameof(ewidencjaSprzedazWiersz.SprzedazVAT_Marza), singleValues[sprzedazVAT_MarzaFieldIndex]);
            
            return ewidencjaSprzedazWiersz;
        }

        private void SetSbyteValue(JPKEwidencjaSprzedazWiersz obj, string propertyName, string value)
        {
            if (value != string.Empty)
            {
                var prop = obj.GetType().GetProperty(propertyName, BindingFlags.Public | BindingFlags.Instance);
                
                if (null != prop && prop.CanWrite)
                {
                    prop.SetValue(obj, sbyte.Parse(value), null);
                }

                var propSpec = obj.GetType().GetProperty($"{propertyName}Specified", BindingFlags.Public | BindingFlags.Instance);

                if (null != propSpec && propSpec.CanWrite)
                {
                    propSpec.SetValue(obj, true, null);
                }
            }
        }

        private void SetDecimalValue(JPKEwidencjaSprzedazWiersz obj, string propertyName, string value)
        {
            if (value != string.Empty)
            {
                var prop = obj.GetType().GetProperty(propertyName, BindingFlags.Public | BindingFlags.Instance);

                if (null != prop && prop.CanWrite)
                {
                    prop.SetValue(obj, decimal.Parse(value), null);
                }

                var propSpec = obj.GetType().GetProperty($"{propertyName}Specified", BindingFlags.Public | BindingFlags.Instance);

                if (null != propSpec && propSpec.CanWrite)
                {
                    propSpec.SetValue(obj, true, null);
                }
            }
        }

        private void SetDateTimeValue(JPKEwidencjaSprzedazWiersz obj, string propertyName, string value)
        {
            if (value != string.Empty)
            {
                var prop = obj.GetType().GetProperty(propertyName, BindingFlags.Public | BindingFlags.Instance);

                if (null != prop && prop.CanWrite)
                {
                    prop.SetValue(obj, DateTime.ParseExact(value, "yyyyMMdd", CultureInfo.CurrentCulture), null);
                }

                var propSpec = obj.GetType().GetProperty($"{propertyName}Specified", BindingFlags.Public | BindingFlags.Instance);

                if (null != propSpec && propSpec.CanWrite)
                {
                    propSpec.SetValue(obj, true, null);
                }
            }
        }
    }
}