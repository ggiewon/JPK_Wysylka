using JPK.Interfaces.Settings;
using UnitSoftware.Common.Interfaces.Views;

namespace JPK_WysylkaXML.EditXML.Interfaces
{
    public interface IJpkEditFileViewModelsFactory
    {
        object Create(JpkType jpkType, string filePath, IBaseView view);
    }
}