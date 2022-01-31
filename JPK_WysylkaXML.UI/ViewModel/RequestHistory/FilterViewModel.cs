using System;
using System.Collections.Generic;
using System.Linq;
using JPK.Interfaces;
using JPK_WysylkaXML.UI.Interfaces.ViewModel.RequestHistory;
using UnitSoftware.Common.Implementation.ExtensionMethods;
using UnitSoftware.Common.Implementation.ViewModels;


namespace JPK_WysylkaXML.UI.ViewModel.RequestHistory
{
    public class FilterViewModel : BaseViewModel, IFilterViewModel
    {        
        private ServerType _selectedServerType;

        private DateTime? _startDate;
        
        private DateTime? _endDate;

        public DateTime? StartDate
        {
            get { return _startDate; }
            set
            {
                if (_startDate != value)
                {
                    _startDate = value;

                    this.RaisePropertyChanged(p => p.StartDate);

                    if (OnFilterChange != null)
                        OnFilterChange(this, EventArgs.Empty);
                }
            }
        }

        public DateTime? EndDate
        {
            get { return _endDate; }
            set
            {
                if (_endDate != value)
                {
                    _endDate = value;

                    this.RaisePropertyChanged(p => p.EndDate);

                    if (OnFilterChange != null)
                        OnFilterChange(this, EventArgs.Empty);
                }
            }
        }

        public ServerType SelectedServerType
        {
            get { return _selectedServerType; }
            set
            {
                if (_selectedServerType != value)
                {
                    _selectedServerType = value;
                    this.RaisePropertyChanged(p=>p.SelectedServerType);

                    if (OnFilterChange != null)
                        OnFilterChange(this, EventArgs.Empty);
                }
            }
        }

        public IList<ServerType> ServerTypeList { get; private set; }

        public event EventHandler OnFilterChange;

        public FilterViewModel( ServerType selectedServerType)
        {
            ServerTypeList = Enum.GetValues(typeof (ServerType)).Cast<ServerType>().ToList();

            SelectedServerType = selectedServerType;
        }
    }
}