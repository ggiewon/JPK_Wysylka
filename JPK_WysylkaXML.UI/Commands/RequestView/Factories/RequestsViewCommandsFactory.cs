using System;
using System.Windows.Input;
using System.Windows.Threading;
using JPK.Interfaces.Configuration;
using JPK.Interfaces.Factories;
using JPK_Wysylka.DB.Implementation.Services;
using JPK_Wysylka.DB.Interfaces.Services;
using JPK_WysylkaXML.License.Interfaces;
using JPK_WysylkaXML.UI.Interfaces.Commands.RequestView.Factories;
using JPK_WysylkaXML.UI.Interfaces.Views;
using UnitSoftware.Common.Interfaces.Commands;
using UnitSoftware.Common.Interfaces.Generator;
using UnitSoftware.Common.Interfaces.Wrappers.IO;
using UnitSoftware.Common.Interfaces.Wrappers.System.Diagnostics;
using UnitSoftware.Common.Wpf.Interfaces.Components.WpfMessageBox;
using UnitSoftware.XmlTypes.Interfaces.Upo;

namespace JPK_WysylkaXML.UI.Commands.RequestView.Factories
{
    public class RequestsViewCommandsFactory : IRequestsViewCommandsFactory
    {
        private readonly IJpkSenderFactory _jpkSenderFactory;

        private readonly IFileWrapper _fileWrapper;

        private readonly IProcessWrapper _processWrapper;

        private readonly IPathWrapper _pathWrapper;
        
        private readonly IWpfMessageBoxManager _wpfMessageBoxManager;
        
        private readonly IUpoFactory _upoFactory;
        
        private readonly IUpoGenerator _upoGenerator;
        
        public RequestsViewCommandsFactory(IJpkSenderFactory jpkSenderFactory, IFileWrapper fileWrapper, IProcessWrapper processWrapper, 
            IPathWrapper pathWrapper, IWpfMessageBoxManager wpfMessageBoxManager,
            IUpoFactory upoFactory, IUpoGenerator upoGenerator)
        {
            if (jpkSenderFactory == null) throw new ArgumentNullException("jpkSenderFactory");
            if (fileWrapper == null) throw new ArgumentNullException("fileWrapper");
            if (processWrapper == null) throw new ArgumentNullException("processWrapper");
            if (pathWrapper == null) throw new ArgumentNullException("pathWrapper");
            if (wpfMessageBoxManager == null) throw new ArgumentNullException("wpfMessageBoxManager");

            _jpkSenderFactory = jpkSenderFactory;
            _fileWrapper = fileWrapper;
            _processWrapper = processWrapper;
            _pathWrapper = pathWrapper;
            _wpfMessageBoxManager = wpfMessageBoxManager;
            _upoFactory = upoFactory;
            _upoGenerator = upoGenerator;
        }

        public IGenericCommand<RefreshParams> CreateRefreshAllCommand(IRequestService requestService, Dispatcher dispatcher, Action onStatucCheckFinish, IConfiguration configuration, ILicenseManager licenseManager)
        {
            var jpkSender = _jpkSenderFactory.Create(string.Empty, configuration, licenseManager);

            return new RefreshAllCommand(requestService, jpkSender, dispatcher, onStatucCheckFinish, configuration);
        }

        public ICommand CreateCloseCommand(IRequestsView ownerView)
        {
            return new CloseRequestViewCommand(ownerView);
        }

        public IGenericCommand<DownloadUpoParams> CreateDownloadCommand(IRequestService requestService)
        {
            return new DownloadUpoCommand(requestService, _fileWrapper);
        }

        public IGenericCommand<DownloadUpoParams> CreateGenerateUpoCommand(string applicationPath, IRequestsView view, IRequestService requestService)
        {
            if (view == null) throw new ArgumentNullException("view");
            
            return new GenerateUpoCommand(_fileWrapper, _processWrapper, _pathWrapper, applicationPath, view, _wpfMessageBoxManager, _upoFactory, _upoGenerator, requestService);
        }
    }
}