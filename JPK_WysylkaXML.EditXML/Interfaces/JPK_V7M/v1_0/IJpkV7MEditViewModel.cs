using UnitSoftware.Common.Interfaces.Commands;

namespace JPK_WysylkaXML.EditXML.Interfaces.JPK_V7M.v1_0
{
    public interface IJpkV7MEditViewModel
    {
        IRefreshableCommand SaleDoubleClickCommand { get; }

        IRefreshableCommand PurchaseDoubleClickCommand { get; }
    }
}