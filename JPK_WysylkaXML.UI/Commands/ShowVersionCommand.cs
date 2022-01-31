using System;
using System.Linq;
using System.Reflection;
using System.Text;
using JPK_WysylkaXML.UI.Components;
using JPK_WysylkaXML.UI.Components.Resources;
using NLog;
using UnitSoftware.Common.Implementation.Commands;
using UnitSoftware.Common.Implementation.Exceptions;
using UnitSoftware.Common.Interfaces.Views;
using UnitSoftware.Common.Interfaces.Wrappers.System.Windows;
using UnitSoftware.Common.Wpf.Implementation.Components.WpfMessageBox;
using UnitSoftware.Common.Wpf.Interfaces.Components.WpfMessageBox;

namespace JPK_WysylkaXML.UI.Commands
{
    public class ShowVersionCommand : BaseRefreshableCommand
    {
        private readonly AppDomain _appDomain;

        private readonly Assembly _executingAssembly;

        private readonly IBaseView _ownerView;
        
        private readonly IWpfMessageBoxManager _wpfMessageBoxManager;

        private readonly IClipboardWrapper _clipboardWrapper;

        private readonly ILogger _logger = LogManager.GetCurrentClassLogger();

        public ShowVersionCommand(AppDomain appDomain, Assembly executingAssembly, IBaseView ownerView, IWpfMessageBoxManager wpfMessageBoxManager, IClipboardWrapper clipboardWrapper)
        {
            if (executingAssembly == null) throw new ArgumentNullException(nameof(executingAssembly));

            _appDomain = appDomain ?? throw new ArgumentNullException(nameof(appDomain));
            _executingAssembly = executingAssembly;
            _ownerView = ownerView ?? throw new ArgumentNullException(nameof(ownerView));            
            _wpfMessageBoxManager = wpfMessageBoxManager ?? throw new ArgumentNullException(nameof(wpfMessageBoxManager));
            _clipboardWrapper = clipboardWrapper ?? throw new ArgumentNullException(nameof(clipboardWrapper));
        }

        public override void Execute(object parameter)
        {
            var assemblies = _appDomain.GetAssemblies().Where(a => a.FullName.ToUpper().Contains("UNITSOFTWARE") || a.FullName.ToUpper().Contains("JPK")).OrderBy(a => a.FullName).ToList();
            //var assemblies = _appDomain.GetAssemblies().OrderBy(a => a.FullName).ToList();

            var mainVersion = _executingAssembly.GetName().Version.ToString(4);

            var modules = new StringBuilder();

            foreach (var assembly in assemblies)
            {
                modules.AppendLine(string.Format("{0} - {1}", assembly.GetName().Name, assembly.GetName().Version.ToString(4)));
            }

            var versionList = modules.ToString();
            
            try
            {
                _clipboardWrapper.SetText(versionList, 5, 500);
            }
            catch (ClipbordOperationException ex)
            {
                _logger.Error(ex);
            }

            _wpfMessageBoxManager.ShowDialog(ResourceTranslator.GetString("ApplicationVersionPopup_Title"), 
                string.Format(ResourceTranslator.GetString("ApplicationVersionPopup_MainModuleVersionLabel"), mainVersion), 
                string.Format(ResourceTranslator.GetString("ApplicationVersionPopup_LoadedModulesLabel"), modules), WpfMessageBoxImage.Information, _ownerView);
        }
    }
}