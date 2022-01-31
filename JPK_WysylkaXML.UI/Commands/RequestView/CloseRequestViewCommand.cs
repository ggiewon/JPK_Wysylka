using System;
using JPK_WysylkaXML.UI.Interfaces.Views;
using UnitSoftware.Common.Implementation.Commands;

namespace JPK_WysylkaXML.UI.Commands.RequestView
{
    public class CloseRequestViewCommand : BaseRefreshableCommand
    {
        private readonly IRequestsView _ownerView;

        public CloseRequestViewCommand(IRequestsView ownerView)
        {
            if (ownerView == null) throw new ArgumentNullException("ownerView");

            _ownerView = ownerView;
        }

        public override void Execute(object parameter)
        {
            _ownerView.Close();
        }
    }
}