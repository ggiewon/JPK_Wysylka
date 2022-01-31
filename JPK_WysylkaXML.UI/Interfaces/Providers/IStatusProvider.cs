using System.Collections.Generic;

namespace JPK_WysylkaXML.UI.Interfaces.Providers
{
    public interface IStatusProvider
    {
        IList<int> FinishStatusList();

        IList<int> ErrorStatusList();
    }
}