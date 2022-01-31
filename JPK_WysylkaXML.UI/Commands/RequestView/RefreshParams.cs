using System;
using System.Collections.Generic;

namespace JPK_WysylkaXML.UI.Commands.RequestView
{
    public class RefreshParams
    {
        public IList<string> ReferenceNoList { get; private set; }

        public RefreshParams(IList<string> referenceNoList)
        {
            if (referenceNoList == null) throw new ArgumentNullException("referenceNoList");

            ReferenceNoList = referenceNoList;
        }
    }
}