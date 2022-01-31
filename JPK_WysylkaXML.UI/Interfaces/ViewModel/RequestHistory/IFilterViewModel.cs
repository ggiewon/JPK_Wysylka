using System;
using System.Collections.Generic;
using JPK.Interfaces;

namespace JPK_WysylkaXML.UI.Interfaces.ViewModel.RequestHistory
{
    public interface IFilterViewModel
    {
        DateTime? StartDate { get; set; }

        DateTime? EndDate { get; set; }

        ServerType SelectedServerType { get; set; }

        IList<ServerType> ServerTypeList { get; }

        event EventHandler OnFilterChange;
    }
}