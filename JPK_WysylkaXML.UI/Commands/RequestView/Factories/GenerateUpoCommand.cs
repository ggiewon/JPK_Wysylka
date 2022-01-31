using System;
using System.Diagnostics;
using JPK_Wysylka.DB.Interfaces.Services;
using JPK_WysylkaXML.UI.Interfaces.Views;
using Microsoft.Win32;
using UnitSoftware.Common.Interfaces.Commands;
using UnitSoftware.Common.Interfaces.Generator;
using UnitSoftware.Common.Interfaces.Wrappers.IO;
using UnitSoftware.Common.Interfaces.Wrappers.System.Diagnostics;
using UnitSoftware.Common.Wpf.Interfaces.Components.WpfMessageBox;
using UnitSoftware.XmlTypes.Interfaces.Upo;

namespace JPK_WysylkaXML.UI.Commands.RequestView.Factories
{
    public class GenerateUpoCommand : IGenericCommand<DownloadUpoParams>
    {
        private readonly IFileWrapper _fileWrapper;

        private readonly IProcessWrapper _processWrapper;

        private readonly IPathWrapper _pathWrapper;

        private readonly string _applicataionPath;

        private readonly IRequestsView _view;

        private readonly IWpfMessageBoxManager _wpfMessageBoxManager;

        private readonly IUpoFactory _upoFactory;

        private readonly IUpoGenerator _upoGenerator;

        private readonly IRequestService _requestService;

        public GenerateUpoCommand(IFileWrapper fileWrapper, IProcessWrapper processWrapper, IPathWrapper pathWrapper, string applicataionPath, IRequestsView view, 
            IWpfMessageBoxManager wpfMessageBoxManager, IUpoFactory upoFactory, IUpoGenerator upoGenerator, IRequestService requestService)
        {
            if (fileWrapper == null) throw new ArgumentNullException("fileWrapper");
            if (processWrapper == null) throw new ArgumentNullException("processWrapper");
            if (pathWrapper == null) throw new ArgumentNullException("pathWrapper");
            if (view == null) throw new ArgumentNullException("view");
            if (wpfMessageBoxManager == null) throw new ArgumentNullException("wpfMessageBoxManager");
            if (upoFactory == null) throw new ArgumentNullException("upoFactory");
            if (upoGenerator == null) throw new ArgumentNullException("upoGenerator");
            if (requestService == null) throw new ArgumentNullException("requestService");
            if (string.IsNullOrEmpty(applicataionPath)) throw new ArgumentNullException("applicataionPath");

            _fileWrapper = fileWrapper;
            _processWrapper = processWrapper;
            _pathWrapper = pathWrapper;
            _applicataionPath = applicataionPath;
            _view = view;
            _wpfMessageBoxManager = wpfMessageBoxManager;
            _upoFactory = upoFactory;
            _upoGenerator = upoGenerator;
            _requestService = requestService;
        }

        public async void Execute(DownloadUpoParams parameter)
        {
            var saveFileDialog = new SaveFileDialog { DefaultExt = ".pdf", Filter = "Pliki PDF (*.pdf)|*.pdf|Wszystkie pliki (*.*)|*.*", FileName = parameter.ReferenceNo };

            if (saveFileDialog.ShowDialog() == true)
            {
                var entity = await _requestService.GetByReferenceNoAsync(parameter.ReferenceNo, parameter.ServerType);

                if (entity == null)
                    throw new Exception();

                var potwierdzenie = _upoFactory.Create(entity.Upo);

                if (potwierdzenie != null)
                {
                    _upoGenerator.GeneratePdfFile(potwierdzenie, saveFileDialog.FileName);
                }
            }

            if (_fileWrapper.Exists(saveFileDialog.FileName))
            {
                Process.Start(new ProcessStartInfo(saveFileDialog.FileName) {UseShellExecute = true});
            }
        }

        public bool CanExecute(DownloadUpoParams parameter)
        {
            return parameter != null && parameter.IsUpo;
        }
    }
}