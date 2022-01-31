using System.Windows;
using GalaSoft.MvvmLight.Threading;

namespace JPK_WysylkaXML.License.Generator
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        static App()
        {
            DispatcherHelper.Initialize();
        }
    }
}
