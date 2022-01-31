using JPK.Interfaces;

namespace JPK_WysylkaXML.UI.Commands.RequestView
{
    public class DownloadUpoParams
    {
        public bool IsUpo { get; private set; }

        public string ReferenceNo { get; private set; }

        public ServerType ServerType { get; private set; }

        public DownloadUpoParams(bool isUpo, string referenceNo, ServerType serverType)
        {
            IsUpo = isUpo;
            ReferenceNo = referenceNo;
            ServerType = serverType;
        }
    }
}