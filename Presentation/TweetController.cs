using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentation
{
  public class TweetController
  {
    private TweetModel _model;
    private TweetView _view;

    public TweetController()
    {
      _model = new TweetModel(this);
      _view = new TweetView(this);
    }
    public void SetTweet(string user, string text, string img, string name)
    {
      _model.TweetUser = user;
      _model.TweetName = name;
      _model.TweetText = text;
      _model.TweetPic = img;
      _view.UpdateView();
    }
    public void SetTweet2(string user, string text, string img, string name)
        {
            _model.TweetUser2 = user;
            _model.TweetName2 = name;
            _model.TweetText2 = text;
            _model.TweetPic2 = img;
            _view.UpdateView();
        }
   public void SetTweet3(string user, string text, string img, string name)
        {
            _model.TweetUser3 = user;
            _model.TweetName3 = name;
            _model.TweetText3 = text;
            _model.TweetPic3 = img;
            _view.UpdateView();
        }
   public void SetTweet4(string user, string text, string img, string name)
        {
            _model.TweetUser4 = user;
            _model.TweetName4 = name;
            _model.TweetText4 = text;
            _model.TweetPic4 = img;
            _view.UpdateView();
        }
  public void SetTweet5(string user, string text, string img, string name)
        {
            _model.TweetUser5 = user;
            _model.TweetName5 = name;
            _model.TweetText5 = text;
            _model.TweetPic5 = img;
            _view.UpdateView();
        }
        public TweetModel GetModel()
    {
      return _model;
    }
    public TweetView GetView()
    {
      return _view;
    }



  }
}
