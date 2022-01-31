using System.Windows;
using JPK_WysylkaXML.EditXML.Interfaces.Views;

namespace JPK_WysylkaXML.EditXML.Interfaces.Factories
{
    public interface IEditJpkFileViewsFactory
    {
        IViewWithSetEvents Create(JpkType type, Window getOwnerWindow);
    }
}