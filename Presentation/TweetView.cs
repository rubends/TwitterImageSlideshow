using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LinqToTwitter;

namespace Presentation
{
  public partial class TweetView : UserControl
  {
    private TweetController _controller;
    public TweetView(TweetController controller)
    {
      _controller = controller;
      InitializeComponent();
    }

    private void TweetView_Load(object sender, EventArgs e)
    {

    }

    public void UpdateView()
    {
      lblText.Text =  _controller.GetModel().TweetText;
      lblUser.Text = "@" + _controller.GetModel().TweetUser;
      lblName.Text = _controller.GetModel().TweetName;
      profoBox.ImageLocation = _controller.GetModel().TweetPic;

            lblText2.Text = _controller.GetModel().TweetText2;
            lblUser2.Text = "@" + _controller.GetModel().TweetUser2;
            lblName2.Text = _controller.GetModel().TweetName2;
            profoBox2.ImageLocation = _controller.GetModel().TweetPic2;

            lblText3.Text = _controller.GetModel().TweetText3;
            lblUser3.Text = "@" + _controller.GetModel().TweetUser3;
            lblName3.Text = _controller.GetModel().TweetName3;
            profoBox3.ImageLocation = _controller.GetModel().TweetPic3;

            lblText4.Text = _controller.GetModel().TweetText4;
            lblUser4.Text = "@" + _controller.GetModel().TweetUser4;
            lblName4.Text = _controller.GetModel().TweetName4;
            profoBox4.ImageLocation = _controller.GetModel().TweetPic4;

            lblText5.Text = _controller.GetModel().TweetText5;
            lblUser5.Text = "@" + _controller.GetModel().TweetUser5;
            lblName5.Text = _controller.GetModel().TweetName5;
            profoBox5.ImageLocation = _controller.GetModel().TweetPic5;

        }

        private void lblText_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
