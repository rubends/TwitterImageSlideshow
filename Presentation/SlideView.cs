using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentation
{
  public partial class SlideView : UserControl
  {
    private SlideController _controller;
    public SlideView(SlideController controller)
    {
      _controller = controller;
      InitializeComponent();
    }

    public void UpdateView()
    {
      if(_controller.GetModel().SlideType == GlobalVar.SLIDE_TYPE_TWEET)
            {
                TweetView tweet = _controller.GetModel().Tweet.GetView();
                tweet.Dock = DockStyle.Fill;
                //tweet.Location = new Point(Screen.PrimaryScreen.Bounds.Width / 2, Screen.PrimaryScreen.Bounds.Height / 2);
                Controls.Add(tweet);
      }
      else if (_controller.GetModel().SlideType == GlobalVar.SLIDE_TYPE_IMAGE)
      {
            ImageView image = _controller.GetModel().Image.GetView();
            image.Dock = DockStyle.Fill;
            Controls.Add(image);
      }
            
    }
    private void SlideView_Load(object sender, EventArgs e)
    {
    }
  }
}
