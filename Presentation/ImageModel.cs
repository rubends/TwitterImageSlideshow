using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentation
{
  public class ImageModel
  {
    private ImageController _controller;
    private string _imagePath;
    public ImageModel(ImageController controller)
    {
      _controller = controller;
    }

    public string ImagePath
    {
      get
      {
        return _imagePath;
      }
      set
      {
        _imagePath = value;
      }
    }
  }
}
