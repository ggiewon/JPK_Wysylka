using System;
using System.Collections.Generic;
using System.Linq;
using JPK_WysylkaXML.EditXML.Interfaces.ViewModels.JPK_V7M.v1_0;
using JPK_WysylkaXML.EditXML.XmlTypes.Version3_v7m.v1_0;
using UnitSoftware.Common.Implementation.Commands;
using UnitSoftware.Common.Interfaces.Commands;
using UnitSoftware.Common.Interfaces.Views;
using UnitSoftware.Common.Wpf.Implementation.ViewModels;

namespace JPK_WysylkaXML.EditXML.ViewModels.JPK_V7M.v1_0
{
    public class JpkV7MEditPurchaseDetailsViewModel : ViewModelBase, IJpkV7MEditPurchaseDetailsViewModel
    {
        private readonly JPKZakupWiersz _entry;

        public JpkV7MEditPurchaseDetailsViewModel(JPKZakupWiersz entry)
        {
            _entry = entry;

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

        #region Properties

        public string LpZakupu
        {
            get { return _entry.LpZakupu; }
            set { _entry.LpZakupu = value; }
        }

        public string KodKrajuNadaniaTIN
        {
            get { return _entry.KodKrajuNadaniaTIN; }
            set { _entry.KodKrajuNadaniaTIN = value; }
        }

        /// <remarks/>
        public string NrDostawcy
        {
            get { return _entry.NrDostawcy; }
            set { _entry.NrDostawcy = value; }
        }

        public string NazwaDostawcy
        {
            get { return _entry.NazwaDostawcy; }
            set { _entry.NazwaDostawcy = value; }
        }

        /// <remarks/>
        public string DowodZakupu
        {
            get { return _entry.DowodZakupu; }
            set { _entry.DowodZakupu = value; }
        }

        /// <remarks/>

        public DateTime DataZakupu
        {
            get { return _entry.DataZakupu; }
            set { _entry.DataZakupu = value; }
        }

        /// <remarks/>
        public DateTime DataWplywu
        {
            get { return _entry.DataWplywu; }
            set
            {
                _entry.DataWplywu = value;
            }
        }

        public bool DataWplywuSpecified
        {
            get { return _entry.DataWplywuSpecified; }
            set { _entry.DataWplywuSpecified = value; }
        }

        public IList<TDowoduZakupu> DokumentZakupuList => Enum.GetValues(typeof(TDowoduZakupu)).OfType<TDowoduZakupu>().ToList();

        public bool DokumentZakupuSpecified
        {
            get { return _entry.DokumentZakupuSpecified; }
            set { _entry.DokumentZakupuSpecified = value; }
        }

        /// <remarks/>
        public TDowoduZakupu DokumentZakupu
        {
            get { return _entry.DokumentZakupu; }
            set
            {
                _entry.DokumentZakupu = value;
            }
        }

        public sbyte MPP
        {
            get { return _entry.MPP; }
            set
            {
                _entry.MPP = value;
                _entry.MPPSpecified = value == 1;
            }
        }

        /// <remarks/>
        public sbyte IMP
        {
            get { return _entry.IMP; }
            set
            {
                _entry.IMP = value;
                _entry.IMPSpecified = value == 1;
            }
        }

        
        /// <remarks/>
        public decimal K_40
        {
            get { return _entry.K_40; }
            set { _entry.K_40 = value; }
        }

        /// <remarks/>
        public decimal K_41
        {
            get { return _entry.K_41; }
            set { _entry.K_41 = value; }
        }

        /// <remarks/>
        public decimal K_42
        {
            get { return _entry.K_42; }
            set { _entry.K_42 = value; }
        }

        /// <remarks/>
        public decimal K_43
        {
            get { return _entry.K_43; }
            set { _entry.K_43 = value; }
        }

        /// <remarks/>
        public decimal K_44
        {
            get { return _entry.K_44; }
            set { _entry.K_44 = value; }
        }

        /// <remarks/>
        
        public bool K_44Specified
        {
            get { return _entry.K_44Specified; }
            set { _entry.K_44Specified = value; }
        }

        /// <remarks/>
        public decimal K_45
        {
            get { return _entry.K_45; }
            set { _entry.K_45 = value; }
        }

        /// <remarks/>
        
        public bool K_45Specified
        {
            get { return _entry.K_45Specified; }
            set { _entry.K_45Specified = value; }
        }

        /// <remarks/>
        public decimal K_46
        {
            get { return _entry.K_46; }
            set { _entry.K_46 = value; }
        }

        /// <remarks/>
        
        public bool K_46Specified
        {
            get { return _entry.K_46Specified; }
            set { _entry.K_46Specified = value; }
        }

        /// <remarks/>
        public decimal K_47
        {
            get { return _entry.K_47; }
            set { _entry.K_47 = value; }
        }

        /// <remarks/>
        
        public bool K_47Specified
        {
            get { return _entry.K_47Specified; }
            set { _entry.K_47Specified = value; }
        }

        /// <remarks/>
        public decimal ZakupVAT_Marza
        {
            get { return _entry.ZakupVAT_Marza; }
            set { _entry.ZakupVAT_Marza = value; }
        }

        /// <remarks/>
        
        public bool ZakupVAT_MarzaSpecified
        {
            get { return _entry.ZakupVAT_MarzaSpecified; }
            set { _entry.ZakupVAT_MarzaSpecified = value; }
        }

        #endregion
    }
}