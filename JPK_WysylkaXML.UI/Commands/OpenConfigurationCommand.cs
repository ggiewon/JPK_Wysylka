using System;
using JPK.Interfaces.Configuration;
using JPK_WysylkaXML.UI.ViewModel;
using JPK_WysylkaXML.UI.Views;
using UnitSoftware.Common.Implementation.Commands;
using UnitSoftware.Common.Interfaces.Views;

namespace JPK_WysylkaXML.UI.Commands
{
    public class OpenConfigurationCommand : BaseRefreshableCommand
    {
        private readonly IConfiguration _configuration;

        private readonly IBaseView _parentView;

        public OpenConfigurationCommand(IConfiguration configuration, IBaseView parentView)
        {
            if (configuration == null) throw new ArgumentNullException("configuration");
            if (parentView == null) throw new ArgumentNullException("parentView");

            _configuration = configuration;
            _parentView = parentView;
        }

        public override void Execute(object parameter)
        {
            var configurationView = new ConfigurationView {Owner = _parentView.GetOwnerWindow()};

            var viewModel = new ConfigurationViewModel(_configuration) { View = configurationView };

            configurationView.DataContext = viewModel;

            configurationView.ShowDialog();
        }
    }
}