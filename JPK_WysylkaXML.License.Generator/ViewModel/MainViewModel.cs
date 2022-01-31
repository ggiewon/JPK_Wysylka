using System;
using System.Windows;
using System.Windows.Input;
using GalaSoft.MvvmLight;
using JPK_WysylkaXML.License.Generator.Interfaces.Generators;
using JPK_WysylkaXML.License.Interfaces;
using UnitSoftware.Common.Implementation.Commands;

namespace JPK_WysylkaXML.License.Generator.ViewModel
{
    public class MainViewModel : ViewModelBase
    {
        private readonly ILicenseBuilder _licenseGenerator;

        private readonly ILicenseSaver _licenseSaver;

        public ICommand GenerateCommand { get; private set; }

        public ICommand ExitCommand { get; private set; }

        public ApplicationType ApplicationType { get; set; }

        public string Nip { get; set; }

        /// <summary>
        /// Initializes a new instance of the MainViewModel class.
        /// </summary>
        public MainViewModel(ILicenseBuilder licenseGenerator, ILicenseSaver licenseSaver)
        {
            if (licenseGenerator == null) throw new ArgumentNullException("licenseGenerator");
            if (licenseSaver == null) throw new ArgumentNullException("licenseSaver");

            _licenseGenerator = licenseGenerator;
            _licenseSaver = licenseSaver;

            GenerateCommand = new DelegateCommand(GenerateCommandExecute, GenerateCommandCanExecute);
            ExitCommand = new DelegateCommand(ExitCommandExecute);
        }

        private static void ExitCommandExecute(object obj)
        {
            Application.Current.Shutdown();
        }

        private bool GenerateCommandCanExecute(object obj)
        {
            return !string.IsNullOrEmpty(Nip);
        }

        private void GenerateCommandExecute(object obj)
        {
            var app = ApplicationType == ApplicationType.Wysylka ? LicenseConsts.JPK_WysylkaXMLType : LicenseConsts.JPK_GeneratorXMLType;

            var license = _licenseGenerator.BuildLicense(Nip, app);

            if (license != null)
            {
                var dlg = new Microsoft.Win32.SaveFileDialog
                {
                    DefaultExt = LicenseConsts.LicenseExtension,
                    Filter = LicenseConsts.LicenseFilter,
                };

                var result = dlg.ShowDialog();

                if (result == true)
                {
                    _licenseSaver.SaveToFile(license, dlg.FileName);

                    MessageBox.Show(string.Format("Licencja została wygenerowana. Licencja zapisana w pliku {0}", dlg.FileName), "Wygenerowano licencję", MessageBoxButton.OK, MessageBoxImage.Information);
                }
            }
        }

        public void OnPropertyChanged(string propertyName)
        {
            // ReSharper disable once ExplicitCallerInfoArgument
            RaisePropertyChanged(propertyName);
        }
    }

    public enum ApplicationType
    {
        Wysylka,
        Generator
    }
}