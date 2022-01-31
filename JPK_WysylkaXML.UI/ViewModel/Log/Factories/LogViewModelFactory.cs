using System;
using JPK_WysylkaXML.UI.Interfaces.ViewModel;
using JPK_WysylkaXML.UI.Interfaces.ViewModel.Factories;
using UnitSoftware.Common.Interfaces.Wrappers.IO;
using UnitSoftware.Common.Interfaces.Wrappers.System;

namespace JPK_WysylkaXML.UI.ViewModel.Log.Factories
{
    public class LogViewModelFactory : ILogViewModelFactory
    {
        private readonly ISystemDateTime _systemDateTime;

        private readonly IFileWrapper _fileWrapper;

        public LogViewModelFactory(ISystemDateTime systemDateTime, IFileWrapper fileWrapper)
        {
            if (systemDateTime == null) throw new ArgumentNullException("systemDateTime");
            if (fileWrapper == null) throw new ArgumentNullException("fileWrapper");

            _systemDateTime = systemDateTime;
            _fileWrapper = fileWrapper;
        }

        public ILogViewModel Create()
        {
            return new LogViewModel(_systemDateTime, _fileWrapper);
        }
    }
}