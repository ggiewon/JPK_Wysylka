using System.Collections.Generic;
using System.Linq;
using JPK_WysylkaXML.UI.Interfaces.Providers;

namespace JPK_WysylkaXML.UI.Providers
{
    public class StatusProvider : IStatusProvider
    {
        private readonly IList<int> _errorStatusList = new List<int> {150, 300, 401, 412};

        private readonly IList<int> _okStatusList = new List<int> {200};

        public IList<int> FinishStatusList()
        {
            return _errorStatusList.Concat(_okStatusList).ToList();
        }

        public IList<int> ErrorStatusList()
        {
            return _errorStatusList;
        }
    }
}