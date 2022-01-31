using System;
using System.Collections.Generic;
using System.Linq;
using JPK_WysylkaXML.EditXML.Interfaces.ViewModels.JPK_V7M.v2_1E;
using JPK_WysylkaXML.EditXML.XmlTypes.Version3_v7m.v2_1E;

namespace JPK_WysylkaXML.EditXML.ViewModels.JPK_V7M.v2_1E
{
    public class DeklaracjeViewModel : IDeklaracjeViewModel
    {
        private readonly JPKDeklaracjaPozycjeSzczegolowe _pozycjeSzczegolowe;

        public IEnumerable<ItemChoiceType> ItemList => Enum.GetValues(typeof(ItemChoiceType)).OfType<ItemChoiceType>().ToList();

        public DeklaracjeViewModel(JPKDeklaracja jpkFileDeklaracja)
        {
            _pozycjeSzczegolowe = jpkFileDeklaracja.PozycjeSzczegolowe;
        }

        public string P_10
        {
            get { return _pozycjeSzczegolowe.P_10; }
            set { _pozycjeSzczegolowe.P_10 = value; }
        }

        
        public string P_11
        {
            get { return _pozycjeSzczegolowe.P_11; }
            set { _pozycjeSzczegolowe.P_11 = value; }
        }

        
        public string P_12
        {
            get { return _pozycjeSzczegolowe.P_12; }
            set { _pozycjeSzczegolowe.P_12 = value; }
        }

        
        public string P_13
        {
            get { return _pozycjeSzczegolowe.P_13; }
            set { _pozycjeSzczegolowe.P_13 = value; }
        }

        
        public string P_14
        {
            get { return _pozycjeSzczegolowe.P_14; }
            set { _pozycjeSzczegolowe.P_14 = value; }
        }

        
        public string P_15
        {
            get { return _pozycjeSzczegolowe.P_15; }
            set { _pozycjeSzczegolowe.P_15 = value; }
        }

        
        
        public string P_16
        {
            get { return _pozycjeSzczegolowe.P_16; }
            set { _pozycjeSzczegolowe.P_16 = value; }
        }

        
        
        public string P_17
        {
            get { return _pozycjeSzczegolowe.P_17; }
            set { _pozycjeSzczegolowe.P_17 = value; }
        }

        
        
        public string P_18
        {
            get => _pozycjeSzczegolowe.P_18;
            set => _pozycjeSzczegolowe.P_18 = value;
        }

        
        
        public string P_19
        {
            get { return _pozycjeSzczegolowe.P_19; }
            set { _pozycjeSzczegolowe.P_19 = value; }
        }

        
        
        public string P_20
        {
            get { return _pozycjeSzczegolowe.P_20; }
            set { _pozycjeSzczegolowe.P_20 = value; }
        }

        
        
        public string P_21
        {
            get { return _pozycjeSzczegolowe.P_21; }
            set { _pozycjeSzczegolowe.P_21 = value; }
        }

        
        
        public string P_22
        {
            get { return _pozycjeSzczegolowe.P_22; }
            set { _pozycjeSzczegolowe.P_22 = value; }
        }

        
        
        public string P_23
        {
            get { return _pozycjeSzczegolowe.P_23; }
            set { _pozycjeSzczegolowe.P_23 = value; }
        }

        
        
        public string P_24
        {
            get { return  _pozycjeSzczegolowe.P_24; }
            set {  _pozycjeSzczegolowe.P_24 = value; }
        }

        
        
        public string P_25
        {
            get { return  _pozycjeSzczegolowe.P_25; }
            set {  _pozycjeSzczegolowe.P_25 = value; }
        }

        
        
        public string P_26
        {
            get { return  _pozycjeSzczegolowe.P_26; }
            set {  _pozycjeSzczegolowe.P_26 = value; }
        }

        
        
        public string P_27
        {
            get { return  _pozycjeSzczegolowe.P_27; }
            set {  _pozycjeSzczegolowe.P_27 = value; }
        }

        
        
        public string P_28
        {
            get { return  _pozycjeSzczegolowe.P_28; }
            set {  _pozycjeSzczegolowe.P_28 = value; }
        }

        
        
        public string P_29
        {
            get { return  _pozycjeSzczegolowe.P_29; }
            set {  _pozycjeSzczegolowe.P_29 = value; }
        }

        
        
        public string P_30
        {
            get { return  _pozycjeSzczegolowe.P_30; }
            set {  _pozycjeSzczegolowe.P_30 = value; }
        }

        
        
        public string P_31
        {
            get { return  _pozycjeSzczegolowe.P_31; }
            set {  _pozycjeSzczegolowe.P_31 = value; }
        }

        
        
        public string P_32
        {
            get { return  _pozycjeSzczegolowe.P_32; }
            set {  _pozycjeSzczegolowe.P_32 = value; }
        }

        
        
        public string P_33
        {
            get { return  _pozycjeSzczegolowe.P_33; }
            set {  _pozycjeSzczegolowe.P_33 = value; }
        }

        
        
        public string P_34
        {
            get { return  _pozycjeSzczegolowe.P_34; }
            set {  _pozycjeSzczegolowe.P_34 = value; }
        }

        
        
        public string P_35
        {
            get { return  _pozycjeSzczegolowe.P_35; }
            set {  _pozycjeSzczegolowe.P_35 = value; }
        }

        
        
        public string P_36
        {
            get { return  _pozycjeSzczegolowe.P_36; }
            set {  _pozycjeSzczegolowe.P_36 = value; }
        }

        
        
        public string P_37
        {
            get { return  _pozycjeSzczegolowe.P_37; }
            set {  _pozycjeSzczegolowe.P_37 = value; }
        }

        
        
        public string P_38
        {
            get { return  _pozycjeSzczegolowe.P_38; }
            set {  _pozycjeSzczegolowe.P_38 = value; }
        }

        
        
        public string P_39
        {
            get { return  _pozycjeSzczegolowe.P_39; }
            set {  _pozycjeSzczegolowe.P_39 = value; }
        }

        
        
        public string P_40
        {
            get { return  _pozycjeSzczegolowe.P_40; }
            set {  _pozycjeSzczegolowe.P_40 = value; }
        }

        
        
        public string P_41
        {
            get { return  _pozycjeSzczegolowe.P_41; }
            set {  _pozycjeSzczegolowe.P_41 = value; }
        }

        
        
        public string P_42
        {
            get { return  _pozycjeSzczegolowe.P_42; }
            set {  _pozycjeSzczegolowe.P_42 = value; }
        }

        
        
        public string P_43
        {
            get { return  _pozycjeSzczegolowe.P_43; }
            set {  _pozycjeSzczegolowe.P_43 = value; }
        }

        
        
        public string P_44
        {
            get { return  _pozycjeSzczegolowe.P_44; }
            set {  _pozycjeSzczegolowe.P_44 = value; }
        }

        
        
        public string P_45
        {
            get { return  _pozycjeSzczegolowe.P_45; }
            set {  _pozycjeSzczegolowe.P_45 = value; }
        }

        
        
        public string P_46
        {
            get { return  _pozycjeSzczegolowe.P_46; }
            set {  _pozycjeSzczegolowe.P_46 = value; }
        }

        
        
        public string P_47
        {
            get { return  _pozycjeSzczegolowe.P_47; }
            set {  _pozycjeSzczegolowe.P_47 = value; }
        }

        
        
        public string P_48
        {
            get { return  _pozycjeSzczegolowe.P_48; }
            set {  _pozycjeSzczegolowe.P_48 = value; }
        }

        
        
        public string P_49
        {
            get { return  _pozycjeSzczegolowe.P_49; }
            set {  _pozycjeSzczegolowe.P_49 = value; }
        }

        
        
        public string P_50
        {
            get { return  _pozycjeSzczegolowe.P_50; }
            set {  _pozycjeSzczegolowe.P_50 = value; }
        }

        
        
        public string P_51
        {
            get { return  _pozycjeSzczegolowe.P_51; }
            set {  _pozycjeSzczegolowe.P_51 = value; }
        }

        
        
        public string P_52
        {
            get { return  _pozycjeSzczegolowe.P_52; }
            set {  _pozycjeSzczegolowe.P_52 = value; }
        }

        
        
        public string P_53
        {
            get { return  _pozycjeSzczegolowe.P_53; }
            set {  _pozycjeSzczegolowe.P_53 = value; }
        }

        
        
        public string P_54
        {
            get { return  _pozycjeSzczegolowe.P_54; }
            set {  _pozycjeSzczegolowe.P_54 = value; }
        }

       

        public sbyte Item
        {
            get { return _pozycjeSzczegolowe.Item; }
            set
            {
                _pozycjeSzczegolowe.Item = value;
                _pozycjeSzczegolowe.ItemSpecified = value != 0;

                _pozycjeSzczegolowe.ItemElementNameSpecified = value != 0;
            }
        }

        public ItemChoiceType ItemElementName
        {
            get { return _pozycjeSzczegolowe.ItemElementName; }
            set
            {
                _pozycjeSzczegolowe.ItemElementName = value;
            }
        }

        public sbyte P_59
        {
            get { return  _pozycjeSzczegolowe.P_59; }
            set
            {
                _pozycjeSzczegolowe.P_59 = value;
                _pozycjeSzczegolowe.P_59Specified = value != 0;
            }
        }
        
        public string P_60
        {
            get { return  _pozycjeSzczegolowe.P_60; }
            set {  _pozycjeSzczegolowe.P_60 = value; }
        }

        public string P_61
        {
            get { return  _pozycjeSzczegolowe.P_61; }
            set {  _pozycjeSzczegolowe.P_61 = value; }
        }
        
        public string P_62
        {
            get { return  _pozycjeSzczegolowe.P_62; }
            set {  _pozycjeSzczegolowe.P_62 = value; }
        }

        
        public sbyte P_63
        {
            get { return  _pozycjeSzczegolowe.P_63; }
            set
            {
                _pozycjeSzczegolowe.P_63 = value;
                _pozycjeSzczegolowe.P_63Specified = value == 1;
            }
        }

        public sbyte P_64
        {
            get { return  _pozycjeSzczegolowe.P_64; }
            set
            {
                _pozycjeSzczegolowe.P_64 = value;
                _pozycjeSzczegolowe.P_64Specified = value == 1;
            }
        }


        public sbyte P_65
        {
            get { return  _pozycjeSzczegolowe.P_65; }
            set
            {
                _pozycjeSzczegolowe.P_65 = value;
                _pozycjeSzczegolowe.P_65Specified = value == 1;
            }
        }

        
        public sbyte P_66
        {
            get { return  _pozycjeSzczegolowe.P_66; }
            set
            {
                _pozycjeSzczegolowe.P_66 = value;
                _pozycjeSzczegolowe.P_66Specified = value == 1;
            }
        }

        public sbyte P_660
        {
            get { return  _pozycjeSzczegolowe.P_660; }
            set
            {
                _pozycjeSzczegolowe.P_660 = value;
                _pozycjeSzczegolowe.P_660Specified = value == 1;
            }
        }

        public sbyte P_67
        {
            get { return  _pozycjeSzczegolowe.P_67; }
            set
            {
                _pozycjeSzczegolowe.P_67 = value;
                _pozycjeSzczegolowe.P_67Specified = value == 1;
            }
        }
        
        public string P_68
        {
            get { return  _pozycjeSzczegolowe.P_68; }
            set {  _pozycjeSzczegolowe.P_68 = value; }
        }
        
        public string P_69
        {
            get { return  _pozycjeSzczegolowe.P_69; }
            set {  _pozycjeSzczegolowe.P_69 = value; }
        }

        public string P_ORDZU
        {
            get { return  _pozycjeSzczegolowe.P_ORDZU; }
            set {  _pozycjeSzczegolowe.P_ORDZU = value; }
        }
    }
}