using System;
using JPK.Interfaces;
using JPK_WysylkaXML.EditXML.Interfaces;
using UnitSoftware.Common.Interfaces.Views;

namespace JPK_WysylkaXML.UI.ViewModel
{
    public class JpkEditFileViewModelsFactory : IJpkEditFileViewModelsFactory
    {
        private readonly ISettingsManager _settingsManager;

        public JpkEditFileViewModelsFactory(ISettingsManager settingsManager)
        {
            _settingsManager = settingsManager ?? throw new ArgumentNullException(nameof(settingsManager));
        }

        public object Create(JpkType jpkType, string filePath, IBaseView view)
        {
            switch (jpkType)
            {
                case JpkType.JPK_V7M_1_0:
                    return new EditXML.ViewModels.JPK_V7M.v1_0.JpkV7MEditViewModel(filePath) { View = view };
                case JpkType.JPK_V7M_1_1:
                    return new EditXML.ViewModels.JPK_V7M.v1_1.JpkV7MEditViewModel(filePath) { View = view };
                case JpkType.JPK_V7M_1_2E:
                    return new EditXML.ViewModels.JPK_V7M.v1_2E.JpkV7MEditViewModel(filePath, _settingsManager) { View = view };
                case JpkType.JPK_V7M_2_1E:
                    return new EditXML.ViewModels.JPK_V7M.v2_1E.JpkV7MEditViewModel(filePath, _settingsManager) { View = view };
                default:
                    throw new ArgumentOutOfRangeException(nameof(jpkType), jpkType, null);
            }
        }
    }
}