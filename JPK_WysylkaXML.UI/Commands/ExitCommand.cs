using System;
using UnitSoftware.Common.Implementation.Commands;
using UnitSoftware.Common.Interfaces.Wrappers.System;

namespace JPK_WysylkaXML.UI.Commands
{
    public class ExitCommand : BaseRefreshableCommand
    {
        private readonly IEnvironmentWrapper _environmentWrapper;

        public ExitCommand(IEnvironmentWrapper environmentWrapper)
        {
            if (environmentWrapper == null) throw new ArgumentNullException("environmentWrapper");

            _environmentWrapper = environmentWrapper;
        }

        public override void Execute(object parameter)
        {
            _environmentWrapper.Exit(0);
        }
    }
}