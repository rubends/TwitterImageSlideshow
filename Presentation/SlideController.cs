using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentation
{
    public class SlideController
    {
        private SlideModel _model;
        private SlideView _view;

        public SlideController()
        {
            _model = new SlideModel(this);
            _view = new SlideView(this);
        }

        public int SlideType {
            get
            {
                return _model.SlideType;
            }
        }

        public void SetSlide(TweetController tweet)
        {
            _model.Tweet = tweet;
            _model.SlideType = GlobalVar.SLIDE_TYPE_TWEET;
            _view.UpdateView();

        }

        public void ResizeContent()
        {
            if(_model.Image is ImageController) _model.Image.GetView().ResizeImage();
        }

        public void SetSlide(ImageController img)
        {
            _model.Image = img;
            _model.SlideType = GlobalVar.SLIDE_TYPE_IMAGE;
            _view.UpdateView();

        }
        public SlideModel GetModel()
        {
            return _model;
        }
        public SlideView GetView()
        {
            return _view;
        }
        
    }
}
