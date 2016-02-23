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
    public partial class SettingsView : UserControl
    {
        private SettingsController _controller;

        public SettingsView(SettingsController controller)
        {
            _controller = controller;
            InitializeComponent();
        }

        private void SettingsView_Load(object sender, EventArgs e)
        {

        }

        public void UpdateView()
        {
            txtTwitterSearch.Text = _controller.getModel().TwitterSearch;
            numericImageGroupSize.Value = _controller.getModel().ImageGroupSize;
            numericMaxTweets.Value = _controller.getModel().MaxTweets;
            numericSlideTime.Value = _controller.getModel().SecondsBetweenSlides;

        }

        private void btnToggleFullscreen_Click(object sender, EventArgs e)
        {
            _controller.getModel().Fullscreen = !_controller.getModel().Fullscreen;

            FullScreen fullScreen = new FullScreen();
            
            if(_controller.getModel().Fullscreen)
            {
                fullScreen.EnterFullScreenMode(_controller.getMainController().getPresentationController().getView());
            }
            else
            {
                fullScreen.LeaveFullScreenMode(_controller.getMainController().getPresentationController().getView());
            }
        }

        private void btnOpenFolderBrowser_Click(object sender, EventArgs e)
        {
            DialogResult result = folderBrowserDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                _controller.changeImageFolder(folderBrowserDialog1.SelectedPath);
            }
        }

        private void btnReloadImages_Click(object sender, EventArgs e)
        {
            _controller.getMainController().getPresentationController().loadImages();
        }

        private void btnPrevSlide_Click(object sender, EventArgs e)
        {
            _controller.getMainController().getPresentationController().PrevSlide();
        }

        private void btnNextSlide_Click(object sender, EventArgs e)
        {
            _controller.getMainController().getPresentationController().NextSlide();
        }

        private void numericSlideTime_ValueChanged(object sender, EventArgs e)
        {
            _controller.getModel().SecondsBetweenSlides = (int) numericSlideTime.Value;
        }

        private void btnSetSearch_Click(object sender, EventArgs e)
        {
            _controller.getModel().TwitterSearch = txtTwitterSearch.Text;
            _controller.getMainController().getPresentationController().loadTweets();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://dev.twitter.com/rest/public/search");
        }

        private void numericImageGroupSize_ValueChanged(object sender, EventArgs e)
        {
            _controller.getModel().ImageGroupSize = (int) numericImageGroupSize.Value;
        }

        private void numericMaxTweets_ValueChanged(object sender, EventArgs e)
        {
            _controller.getModel().MaxTweets = (int)numericMaxTweets.Value;
        }
    }
}
