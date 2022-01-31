using System;
using System.Collections.Generic;
using System.Linq;
using JPK_WysylkaXML.EditXML.XmlTypes.Version3_v7m.v1_2E;
using UnitSoftware.Common.Implementation.Commands;
using UnitSoftware.Common.Interfaces.Commands;
using UnitSoftware.Common.Interfaces.Views;
using UnitSoftware.Common.Wpf.Implementation.ViewModels;

namespace JPK_WysylkaXML.EditXML.ViewModels.JPK_V7M.v1_2E
{
    public class JpkV7MEditSaleDetailsViewModel : ViewModelBase
    {
        private readonly JPKEwidencjaSprzedazWiersz _saleEntry;

        public JpkV7MEditSaleDetailsViewModel(JPKEwidencjaSprzedazWiersz saleEntry)
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

        public IRefreshableCommand SaveCommand { get; }

        public IRefreshableCommand CancelCommand { get; }

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
            get => _saleEntry.DowodSprzedazy;
            set => _saleEntry.DowodSprzedazy = value;
        }

        public DateTime DataWystawienia
        {
            get => _saleEntry.DataWystawienia;
            set => _saleEntry.DataWystawienia = value;
        }

        public DateTime DataSprzedazy
        {
            get => _saleEntry.DataSprzedazy;
            set => _saleEntry.DataSprzedazy = value;
        }

        public bool DataSprzedazySpecified
        {
            get => _saleEntry.DataSprzedazySpecified;
            set => _saleEntry.DataSprzedazySpecified = value;
        }

        public TDowoduSprzedazy TypDokumentu
        {
            get => _saleEntry.TypDokumentu;
            set => _saleEntry.TypDokumentu = value;
        }

        public IList<TDowoduSprzedazy> TypDokumentuList => Enum.GetValues(typeof(TDowoduSprzedazy)).OfType<TDowoduSprzedazy>().ToList();

        public bool TypDokumentuSpecified
        {
            get => _saleEntry.TypDokumentuSpecified;
            set => _saleEntry.TypDokumentuSpecified = value;
        }

        public sbyte GTU_01
        {
            get => _saleEntry.GTU_01;
            set
            {
                _saleEntry.GTU_01 = value;
                _saleEntry.GTU_01Specified = value == 1;
            }
        }

        public sbyte GTU_02
        {
            get => _saleEntry.GTU_02;
            set
            {
                _saleEntry.GTU_02 = value;
                _saleEntry.GTU_02Specified = value == 1;
            }
        }

        public sbyte GTU_03
        {
            get => _saleEntry.GTU_03;
            set
            {
                _saleEntry.GTU_03 = value;
                _saleEntry.GTU_03Specified = value == 1;
            }
        }

        public sbyte GTU_04
        {
            get => _saleEntry.GTU_04;
            set
            {
                _saleEntry.GTU_04 = value;
                _saleEntry.GTU_04Specified = value == 1;
            }
        }

        public sbyte GTU_05
        {
            get => _saleEntry.GTU_05;
            set
            {
                _saleEntry.GTU_05 = value;
                _saleEntry.GTU_05Specified = value == 1;
            }
        }

        public sbyte GTU_06
        {
            get => _saleEntry.GTU_06;
            set
            {
                _saleEntry.GTU_06 = value;
                _saleEntry.GTU_06Specified = value == 1;
            }
        }

        public sbyte GTU_07
        {
            get => _saleEntry.GTU_07;
            set
            {
                _saleEntry.GTU_07 = value;
                _saleEntry.GTU_07Specified = value == 1;
            }
        }

        public sbyte GTU_08 { get => _saleEntry.GTU_08;
            set { _saleEntry.GTU_08 = value; _saleEntry.GTU_08Specified = value == 1; } }
        public sbyte GTU_09 { get => _saleEntry.GTU_09;
            set { _saleEntry.GTU_09 = value; _saleEntry.GTU_09Specified = value == 1; } }
        public sbyte GTU_10 { get => _saleEntry.GTU_10;
            set { _saleEntry.GTU_10 = value; _saleEntry.GTU_10Specified = value == 1; } }
        public sbyte GTU_11 { get => _saleEntry.GTU_11;
            set { _saleEntry.GTU_11 = value; _saleEntry.GTU_11Specified = value == 1; } }
        public sbyte GTU_12 { get => _saleEntry.GTU_12;
            set { _saleEntry.GTU_12 = value; _saleEntry.GTU_12Specified = value == 1; } }
        public sbyte GTU_13 { get => _saleEntry.GTU_13;
            set { _saleEntry.GTU_13 = value; _saleEntry.GTU_13Specified = value == 1; } }

        public sbyte SW { get => _saleEntry.SW;
            set { _saleEntry.SW = value; _saleEntry.SWSpecified = value == 1; } }
        public sbyte EE { get => _saleEntry.EE;
            set { _saleEntry.EE = value; _saleEntry.EESpecified = value == 1; } }
        public sbyte TP { get => _saleEntry.TP;
            set { _saleEntry.TP = value; _saleEntry.TPSpecified = value == 1; } }

        public sbyte TT_WNT { get => _saleEntry.TT_WNT;
            set { _saleEntry.TT_WNT = value; _saleEntry.TT_WNTSpecified = value == 1; } }

        public sbyte TT_D { get => _saleEntry.TT_D;
            set { _saleEntry.TT_D = value; _saleEntry.TT_DSpecified = value == 1; } }

        public sbyte MR_T { get => _saleEntry.MR_T;
            set { _saleEntry.MR_T = value; _saleEntry.MR_TSpecified = value == 1; } }

        public sbyte MR_UZ { get => _saleEntry.MR_UZ;
            set { _saleEntry.MR_UZ = value; _saleEntry.MR_UZSpecified = value == 1; } }


        public sbyte I_42 { get => _saleEntry.I_42;
            set { _saleEntry.I_42 = value; _saleEntry.I_42Specified = value == 1; } }

        public sbyte I_63 { get => _saleEntry.I_63;
            set { _saleEntry.I_63 = value; _saleEntry.I_63Specified = value == 1; } }

        public sbyte B_SPV { get => _saleEntry.B_SPV;
            set { _saleEntry.B_SPV = value; _saleEntry.B_SPVSpecified = value == 1; } }

        public sbyte B_SPV_DOSTAWA { get => _saleEntry.B_SPV_DOSTAWA;
            set { _saleEntry.B_SPV_DOSTAWA = value; _saleEntry.B_SPV_DOSTAWASpecified = value == 1; } }

        public sbyte B_MPV_PROWIZJA { get => _saleEntry.B_MPV_PROWIZJA;
            set { _saleEntry.B_MPV_PROWIZJA = value; _saleEntry.B_MPV_PROWIZJASpecified = value == 1; } }

        public sbyte MPP { get => _saleEntry.MPP;
            set { _saleEntry.MPP = value; _saleEntry.MPPSpecified = value == 1; } }

        public sbyte KorektaPodstawyOpodt { get => _saleEntry.KorektaPodstawyOpodt;
            set { _saleEntry.KorektaPodstawyOpodt = value; _saleEntry.KorektaPodstawyOpodtSpecified = value == 1; } }

        public decimal K_10 { get => _saleEntry.K_10;
            set { _saleEntry.K_10 = value; _saleEntry.K_10Specified = value != 0; } }
        public decimal K_11 { get => _saleEntry.K_11;
            set { _saleEntry.K_11 = value; _saleEntry.K_11Specified = value != 0; } }
        public decimal K_12 { get => _saleEntry.K_12;
            set { _saleEntry.K_12 = value; _saleEntry.K_12Specified = value != 0; } }
        public decimal K_13 { get => _saleEntry.K_13;
            set { _saleEntry.K_13 = value; _saleEntry.K_13Specified = value != 0; } }
        public decimal K_14 { get => _saleEntry.K_14;
            set { _saleEntry.K_14 = value; _saleEntry.K_14Specified = value != 0; } }
        public decimal K_15 { get => _saleEntry.K_15;
            set => _saleEntry.K_15 = value;
        }
        public decimal K_16 { get => _saleEntry.K_16;
            set => _saleEntry.K_16 = value;
        }
        public decimal K_17 { get => _saleEntry.K_17;
            set => _saleEntry.K_17 = value;
        }
        public decimal K_18 { get => _saleEntry.K_18;
            set => _saleEntry.K_18 = value;
        }
        public decimal K_19 { get => _saleEntry.K_19;
            set => _saleEntry.K_19 = value;
        }

        public decimal K_20 { get => _saleEntry.K_20;
            set => _saleEntry.K_20 = value;
        }
        public decimal K_21 { get => _saleEntry.K_21;
            set { _saleEntry.K_21 = value; _saleEntry.K_21Specified = value != 0; } }
        public decimal K_22 { get => _saleEntry.K_22;
            set { _saleEntry.K_22 = value; _saleEntry.K_22Specified = value != 0; } }

        public decimal K_23 { get => _saleEntry.K_23;
            set => _saleEntry.K_23 = value;
        }
        public decimal K_24 { get => _saleEntry.K_24;
            set => _saleEntry.K_24 = value;
        }
        public decimal K_25 { get => _saleEntry.K_25;
            set => _saleEntry.K_25 = value;
        }

        public decimal K_26 { get => _saleEntry.K_26;
            set => _saleEntry.K_26 = value;
        }
        public decimal K_27 { get => _saleEntry.K_27;
            set => _saleEntry.K_27 = value;
        }
        public decimal K_28 { get => _saleEntry.K_28;
            set => _saleEntry.K_28 = value;
        }
        public decimal K_29 { get => _saleEntry.K_29;
            set => _saleEntry.K_29 = value;
        }
        public decimal K_30 { get => _saleEntry.K_30;
            set => _saleEntry.K_30 = value;
        }
        public decimal K_31 { get => _saleEntry.K_31;
            set => _saleEntry.K_31 = value;
        }
        public decimal K_32 { get => _saleEntry.K_32;
            set => _saleEntry.K_32 = value;
        }
        public decimal K_33 { get => _saleEntry.K_33;
            set { _saleEntry.K_33 = value; _saleEntry.K_33Specified = value != 0; } }
        public decimal K_34 { get => _saleEntry.K_34;
            set { _saleEntry.K_34 = value; _saleEntry.K_34Specified = value != 0; } }
        public decimal K_35 { get => _saleEntry.K_35;
            set { _saleEntry.K_35 = value; _saleEntry.K_35Specified = value != 0; } }
        public decimal K_36 { get => _saleEntry.K_36;
            set { _saleEntry.K_36 = value; _saleEntry.K_36Specified = value != 0; } }

        public decimal SprzedazVAT_Marza { get => _saleEntry.SprzedazVAT_Marza;
            set { _saleEntry.SprzedazVAT_Marza = value; _saleEntry.SprzedazVAT_MarzaSpecified = value != 0; } }
        
       
        #endregion
    }
}