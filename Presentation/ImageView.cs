using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Presentation
{
    public partial class ImageView : UserControl
    {
        private ImageController _controller;
        public ImageView(ImageController controller)
        {
            _controller = controller;
            InitializeComponent();
        }

        private void ImageView_Load(object sender, EventArgs e)
        {
        }
        public void UpdateView()
        {
            //FileStream fs = new System.IO.FileStream(_controller.GetModel().ImagePath, FileMode.Open, FileAccess.Read);
            //pictureBox1.Image = Image.FromStream(fs);
            //fs.Close();
            pictureBox1.Image = Image.FromFile(_controller.GetModel().ImagePath);
            ResizeImage();
        }

        public void ResizeImage()
        {
            pictureBox1.Width = _controller.GetPresentation().getView().ClientSize.Width;
            pictureBox1.Height = _controller.GetPresentation().getView().ClientSize.Height;
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
