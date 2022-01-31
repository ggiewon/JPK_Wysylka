using System;
using System.Text;
using JPK_Wysylka.DB.Interfaces.Services;
using Microsoft.Win32;
using UnitSoftware.Common.Interfaces.Commands;
using UnitSoftware.Common.Interfaces.Wrappers.IO;
using UnitSoftware.Common.Wpf.Implementation.Components.WpfMessageBox;

namespace JPK_WysylkaXML.UI.Commands.RequestView
{
    public class DownloadUpoCommand : IGenericCommand<DownloadUpoParams>
    {
        private readonly IRequestService _requestService;

        private readonly IFileWrapper _fileWrapper;

        public DownloadUpoCommand(IRequestService requestService, IFileWrapper fileWrapper)
        {
            _requestService = requestService ?? throw new ArgumentNullException("requestService");
            _fileWrapper = fileWrapper ?? throw new ArgumentNullException("fileWrapper");
        }

        public async void Execute(DownloadUpoParams parameter)
        {
            var entity = await _requestService.GetByReferenceNoAsync(parameter.ReferenceNo, parameter.ServerType);

            if (entity == null)
                throw new Exception();

            var saveFileDialog = new SaveFileDialog {DefaultExt = ".xml", Filter = "Pliki XML (*.xml)|*.xml|Wszystkie pliki (*.*)|*.*", FileName = parameter.ReferenceNo};

            if (saveFileDialog.ShowDialog() == true)
            {
                _fileWrapper.WriteAllText(saveFileDialog.FileName, entity.Upo, Encoding.UTF8);


                if (_fileWrapper.Exists(saveFileDialog.FileName))
                    WpfMessageBox.Show("Zapis Upo", "Upo zapisane do pliku.", string.Format("Dokument UPO zapisany do pliku {0}", saveFileDialog.FileName), WpfMessageBoxImage.OK);
            }
        }

        public bool CanExecute(DownloadUpoParams parameter)
        {
            return parameter != null && parameter.IsUpo;
        }
    }
}