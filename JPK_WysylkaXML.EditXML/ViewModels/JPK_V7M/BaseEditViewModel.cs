using System.IO;
using System.Xml.Serialization;
using UnitSoftware.Common.Wpf.Implementation.ViewModels;

namespace JPK_WysylkaXML.EditXML.ViewModels.JPK_V7M
{
    public class BaseEditViewModel<T> : ViewModelBase
    {
        private readonly string _filePath;

        protected readonly T _jpkFile;

        public BaseEditViewModel(string filePath)
        {
            _filePath = filePath;

            var serializer = new XmlSerializer(typeof(T));

            using (var fileStream = new FileStream(filePath, FileMode.Open))
            {
                _jpkFile = (T)serializer.Deserialize(fileStream);
            }
        }

        protected void SaveJpkFile()
        {
            var serializer = new XmlSerializer(typeof(T));

            using (var fileStream = new FileStream(_filePath, FileMode.Create))
            {
                serializer.Serialize(fileStream, _jpkFile);
            }
        }
    }
}