using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentation
{
  public class SlideModel
  {
    private SlideController _controller;
    private int _slideType;
    private TweetController _tweet;
    private ImageController _image;
    public SlideModel(SlideController controller)
    {
      _controller = controller;
    }
    public int SlideType
    {
      get
      {
        return _slideType;
      }
      set 
      {
        _slideType = value;
      }
    }

    
    public TweetController Tweet
    {
      get 
      {
        return _tweet;
      }
      set
      {
        _tweet = value;
      }
    }
    public ImageController Image
    {
      get
      {
        return _image;
      }
      set
      {
        _image = value;
      }
    }
  }
}
