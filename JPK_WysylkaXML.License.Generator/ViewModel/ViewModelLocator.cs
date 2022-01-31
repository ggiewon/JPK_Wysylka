using GalaSoft.MvvmLight.Ioc;
using JPK_WysylkaXML.License.Generator.Interfaces.Generators;
using JPK_WysylkaXML.License.Helpers;
using JPK_WysylkaXML.License.Interfaces;
using JPK_WysylkaXML.License.Interfaces.Helpers;
using Microsoft.Practices.ServiceLocation;
using UnitSoftware.Common.Implementation.Wrappers.IO;
using UnitSoftware.Common.Interfaces.Wrappers.IO;

namespace JPK_WysylkaXML.License.Generator.ViewModel
{
    public class ViewModelLocator
    {
        static ViewModelLocator()
        {
            ServiceLocator.SetLocatorProvider(() => SimpleIoc.Default);

            SimpleIoc.Default.Register<ILicenseBuilder, LicenseBuilder>();
            SimpleIoc.Default.Register<ILicenseHashCalculator, LicenseHashCalculator>();
            SimpleIoc.Default.Register<ILicenseSaver, LicenseSaver>();
            SimpleIoc.Default.Register<IFileWrapper, FileWrapper>();

            SimpleIoc.Default.Register<MainViewModel>();
        }

        /// <summary>
        /// Gets the Main property.
        /// </summary>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1822:MarkMembersAsStatic", Justification = "This non-static member is needed for data binding purposes.")]
        public MainViewModel Main
        {
            get
            {
                return ServiceLocator.Current.GetInstance<MainViewModel>();
            }
        }

        /// <summary>
        /// Cleans up all the resources.
        /// </summary>
        public static void Cleanup()
        {
        }
    }
}