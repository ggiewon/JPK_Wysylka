using System;
using System.Windows;
using JPK_WysylkaXML.EditXML.Interfaces;
using JPK_WysylkaXML.EditXML.Interfaces.Factories;
using JPK_WysylkaXML.EditXML.Interfaces.Views;

namespace JPK_WysylkaXML.EditXML.Views.Factories
{
    public class EditJpkFileViewsFactory : IEditJpkFileViewsFactory
    {
        public IViewWithSetEvents Create(JpkType type, Window ownerWindow)
        {
            switch (type)
            {
                case JpkType.JPK_V7M_1_0:
                    return new JPK_V7M.v1_0.EditJpkFileView { Owner = ownerWindow };
                case JpkType.JPK_V7M_1_1:
                    return new JPK_V7M.v1_1.EditJpkFileView { Owner = ownerWindow };
                case JpkType.JPK_V7M_1_2E:
                    return new JPK_V7M.v1_2E.EditJpkFileView { Owner = ownerWindow };
                case JpkType.JPK_V7M_2_1E:
                    return new JPK_V7M.v2_1E.EditJpkFileView { Owner = ownerWindow };
                default:
                    throw new ArgumentOutOfRangeException(nameof(type), type, null);
            }
        }

    }
}