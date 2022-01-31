using System;
using System.Collections.Generic;
using System.Linq;
using JPK_WysylkaXML.EditXML.XmlTypes.Version3_v7m.v1_0;
using UnitSoftware.Common.Implementation.Commands;
using UnitSoftware.Common.Interfaces.Commands;
using UnitSoftware.Common.Interfaces.Views;
using UnitSoftware.Common.Wpf.Implementation.ViewModels;

namespace JPK_WysylkaXML.EditXML.ViewModels.JPK_V7M.v1_0
{
    public class JpkV7MEditSaleDetailsViewModel : ViewModelBase
    {
        private readonly JPKSprzedazWiersz _saleEntry;

        public JpkV7MEditSaleDetailsViewModel(JPKSprzedazWiersz saleEntry)
        {
            _saleEntry = saleEntry;

            CancelCommand = new DelegateCommand(CancelCommandExecute);
            SaveCommand = new DelegateCommand(SaveCommandExecute, SaveCommandCanExecute);
        }

        private void CancelCommandExecute(object obj)
        {
            View.Close();
        }

        private void SaveCommandExecute(object obj)
        {
            View.DialogResult = true;
            View.Close();
        }

        private bool SaveCommandCanExecute(object obj)
        {
            return true;
        }

        public IRefreshableCommand SaveCommand { get; private set; }

        public IRefreshableCommand CancelCommand { get; private set; }

        public IBaseView View { get; set; }

        #region Fields

        public string LpSprzedazy
        {
            get => _saleEntry.LpSprzedazy;
            set => _saleEntry.LpSprzedazy = value;
        }

        public string NrKontrahenta
        {
            get => _saleEntry.NrKontrahenta;
            set => _saleEntry.NrKontrahenta = value;
        }
        public string NazwaKontrahenta
        {
            get => _saleEntry.NazwaKontrahenta;
            set => _saleEntry.NazwaKontrahenta = value;
        }

        /// <remarks/>
        public string KodKrajuNadaniaTIN
        {
            get => _saleEntry.KodKrajuNadaniaTIN; 
            set => _saleEntry.KodKrajuNadaniaTIN = value;
        }

        public string DowodSprzedazy
        {
            get { return _saleEntry.DowodSprzedazy; }
            set { _saleEntry.DowodSprzedazy = value; }
        }

        public DateTime DataWystawienia
        {
            get { return _saleEntry.DataWystawienia; }
            set { _saleEntry.DataWystawienia = value; }
        }

        public DateTime DataSprzedazy
        {
            get { return _saleEntry.DataSprzedazy; }
            set { _saleEntry.DataSprzedazy = value; }
        }

        public bool DataSprzedazySpecified
        {
            get { return _saleEntry.DataSprzedazySpecified; }
            set { _saleEntry.DataSprzedazySpecified = value; }
        }

        public TDowoduSprzedazy TypDokumentu
        {
            get { return _saleEntry.TypDokumentu; }
            set { _saleEntry.TypDokumentu = value; }
        }

        public IList<TDowoduSprzedazy> TypDokumentuList => Enum.GetValues(typeof(TDowoduSprzedazy)).OfType<TDowoduSprzedazy>().ToList();

        public bool TypDokumentuSpecified
        {
            get { return _saleEntry.TypDokumentuSpecified; }
            set { _saleEntry.TypDokumentuSpecified = value; }
        }

        public sbyte GTU_01
        {
            get { return _saleEntry.GTU_01; }
            set
            {
                _saleEntry.GTU_01 = value;
                _saleEntry.GTU_01Specified = value == 1;
            }
        }

        public sbyte GTU_02
        {
            get { return _saleEntry.GTU_02; }
            set
            {
                _saleEntry.GTU_02 = value;
                _saleEntry.GTU_02Specified = value == 1;
            }
        }

        public sbyte GTU_03
        {
            get { return _saleEntry.GTU_03; }
            set
            {
                _saleEntry.GTU_03 = value;
                _saleEntry.GTU_03Specified = value == 1;
            }
        }

        public sbyte GTU_04
        {
            get { return _saleEntry.GTU_04; }
            set
            {
                _saleEntry.GTU_04 = value;
                _saleEntry.GTU_04Specified = value == 1;
            }
        }

        public sbyte GTU_05
        {
            get { return _saleEntry.GTU_05; }
            set
            {
                _saleEntry.GTU_05 = value;
                _saleEntry.GTU_05Specified = value == 1;
            }
        }

        public sbyte GTU_06
        {
            get { return _saleEntry.GTU_06; }
            set
            {
                _saleEntry.GTU_06 = value;
                _saleEntry.GTU_06Specified = value == 1;
            }
        }

        public sbyte GTU_07
        {
            get { return _saleEntry.GTU_07; }
            set
            {
                _saleEntry.GTU_07 = value;
                _saleEntry.GTU_07Specified = value == 1;
            }
        }

        public sbyte GTU_08 { get { return _saleEntry.GTU_08; }  set { _saleEntry.GTU_08 = value; _saleEntry.GTU_08Specified = value == 1; } }
        public sbyte GTU_09 { get { return _saleEntry.GTU_09; } set { _saleEntry.GTU_09 = value; _saleEntry.GTU_09Specified = value == 1; } }
        public sbyte GTU_10 { get { return _saleEntry.GTU_10; } set { _saleEntry.GTU_10 = value; _saleEntry.GTU_10Specified = value == 1; } }
        public sbyte GTU_11 { get { return _saleEntry.GTU_11; } set { _saleEntry.GTU_11 = value; _saleEntry.GTU_11Specified = value == 1; } }
        public sbyte GTU_12 { get { return _saleEntry.GTU_12; } set { _saleEntry.GTU_12 = value; _saleEntry.GTU_12Specified = value == 1; } }
        public sbyte GTU_13 { get { return _saleEntry.GTU_13; } set { _saleEntry.GTU_13 = value; _saleEntry.GTU_13Specified = value == 1; } }

        public sbyte SW { get { return _saleEntry.SW; } set { _saleEntry.SW = value; _saleEntry.SWSpecified = value == 1; } }
        public sbyte EE { get { return _saleEntry.EE; } set { _saleEntry.EE = value; _saleEntry.EESpecified = value == 1; } }
        public sbyte TP { get { return _saleEntry.TP; } set { _saleEntry.TP = value; _saleEntry.TPSpecified = value == 1; } }

        public sbyte TT_WNT { get { return _saleEntry.TT_WNT; } set { _saleEntry.TT_WNT = value; _saleEntry.TT_WNTSpecified = value == 1; } }

        public sbyte TT_D { get { return _saleEntry.TT_D; } set { _saleEntry.TT_D = value; _saleEntry.TT_DSpecified = value == 1; } }

        public sbyte MR_T { get { return _saleEntry.MR_T; } set { _saleEntry.MR_T = value; _saleEntry.MR_TSpecified = value == 1; } }

        public sbyte MR_UZ { get { return _saleEntry.MR_UZ; } set { _saleEntry.MR_UZ = value; _saleEntry.MR_UZSpecified = value == 1; } }


        public sbyte I_42 { get { return _saleEntry.I_42; } set { _saleEntry.I_42 = value; _saleEntry.I_42Specified = value == 1; } }

        public sbyte I_63 { get { return _saleEntry.I_63; } set { _saleEntry.I_63 = value; _saleEntry.I_63Specified = value == 1; } }

        public sbyte B_SPV { get { return _saleEntry.B_SPV; } set { _saleEntry.B_SPV = value; _saleEntry.B_SPVSpecified = value == 1; } }

        public sbyte B_SPV_DOSTAWA { get { return _saleEntry.B_SPV_DOSTAWA; } set { _saleEntry.B_SPV_DOSTAWA = value; _saleEntry.B_SPV_DOSTAWASpecified = value == 1; } }

        public sbyte B_MPV_PROWIZJA { get { return _saleEntry.B_MPV_PROWIZJA; } set { _saleEntry.B_MPV_PROWIZJA = value; _saleEntry.B_MPV_PROWIZJASpecified = value == 1; } }

        public sbyte MPP { get { return _saleEntry.MPP; } set { _saleEntry.MPP = value; _saleEntry.MPPSpecified = value == 1; } }

        public sbyte KorektaPodstawyOpodt { get { return _saleEntry.KorektaPodstawyOpodt; } set { _saleEntry.KorektaPodstawyOpodt = value; _saleEntry.KorektaPodstawyOpodtSpecified = value == 1; } }

        public decimal K_10 { get { return _saleEntry.K_10; } set { _saleEntry.K_10 = value; _saleEntry.K_10Specified = value == 1; } }
        public decimal K_11 { get { return _saleEntry.K_11; } set { _saleEntry.K_11 = value; _saleEntry.K_11Specified = value == 1; } }
        public decimal K_12 { get { return _saleEntry.K_12; } set { _saleEntry.K_12 = value; _saleEntry.K_12Specified = value == 1; } }
        public decimal K_13 { get { return _saleEntry.K_13; } set { _saleEntry.K_13 = value; _saleEntry.K_13Specified = value == 1; } }
        public decimal K_14 { get { return _saleEntry.K_14; } set { _saleEntry.K_14 = value; _saleEntry.K_14Specified = value == 1; } }
        public decimal K_15 { get { return _saleEntry.K_15; } set { _saleEntry.K_15 = value; } }
        public decimal K_16 { get { return _saleEntry.K_16; } set { _saleEntry.K_16 = value; } }
        public decimal K_17 { get { return _saleEntry.K_17; } set { _saleEntry.K_17 = value; } }
        public decimal K_18 { get { return _saleEntry.K_18; } set { _saleEntry.K_18 = value; } }
        public decimal K_19 { get { return _saleEntry.K_19; } set { _saleEntry.K_19 = value; } }

        public decimal K_20 { get { return _saleEntry.K_20; } set { _saleEntry.K_20 = value; } }
        public decimal K_21 { get { return _saleEntry.K_21; } set { _saleEntry.K_21 = value; _saleEntry.K_21Specified = value == 1; } }
        public decimal K_22 { get { return _saleEntry.K_22; } set { _saleEntry.K_22 = value; _saleEntry.K_22Specified = value == 1; } }

        public decimal K_23 { get { return _saleEntry.K_23; } set { _saleEntry.K_23 = value; } }
        public decimal K_24 { get { return _saleEntry.K_24; } set { _saleEntry.K_24 = value; } }
        public decimal K_25 { get { return _saleEntry.K_25; } set { _saleEntry.K_25 = value; } }

        public decimal K_26 { get { return _saleEntry.K_26; } set { _saleEntry.K_26 = value; } }
        public decimal K_27 { get { return _saleEntry.K_27; } set { _saleEntry.K_27 = value; } }
        public decimal K_28 { get { return _saleEntry.K_28; } set { _saleEntry.K_28 = value; } }
        public decimal K_29 { get { return _saleEntry.K_29; } set { _saleEntry.K_29 = value; } }
        public decimal K_30 { get { return _saleEntry.K_30; } set { _saleEntry.K_30 = value; } }
        public decimal K_31 { get { return _saleEntry.K_31; } set { _saleEntry.K_31 = value; } }
        public decimal K_32 { get { return _saleEntry.K_32; } set { _saleEntry.K_32 = value; } }
        public decimal K_33 { get { return _saleEntry.K_33; } set { _saleEntry.K_33 = value; _saleEntry.K_33Specified = value == 1; } }
        public decimal K_34 { get { return _saleEntry.K_34; } set { _saleEntry.K_34 = value; _saleEntry.K_34Specified = value == 1; } }
        public decimal K_35 { get { return _saleEntry.K_35; } set { _saleEntry.K_35 = value; _saleEntry.K_35Specified = value == 1; } }
        public decimal K_36 { get { return _saleEntry.K_36; } set { _saleEntry.K_36 = value; _saleEntry.K_36Specified = value == 1; } }

        public decimal SprzedazVAT_Marza { get { return _saleEntry.SprzedazVAT_Marza; } set { _saleEntry.SprzedazVAT_Marza = value; _saleEntry.SprzedazVAT_MarzaSpecified = value == 1; } }
        
       
        #endregion
    }
}