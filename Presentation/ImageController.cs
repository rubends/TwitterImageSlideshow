using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentation
{
    public class ImageController
    {
        private ImageModel _model;
        private ImageView _view;
        private PresentationController _presentation;

        public PresentationController GetPresentation()
        {
            return _presentation;
        }

        public ImageController(PresentationController presentation)
        {
            _model = new ImageModel(this);
            _view = new ImageView(this);
            _presentation = presentation;
        }
        public void SetImage(string imagepath)
        {
            _model.ImagePath = imagepath;
            _view.UpdateView();
        }
        public ImageModel GetModel()
        {
            return _model;
        }
        public ImageView GetView()
        {
            return _view;
        }
    }
}
