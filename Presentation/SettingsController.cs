using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentation
{
    public class SettingsController
    {
        private SettingsView _view;
        private SettingsModel _model;
        private MainController _mainController;

        public SettingsController(MainController mainController)
        {
            _view = new SettingsView(this);
            _model = new SettingsModel();
            _mainController = mainController;

            _model.TwitterSearch = "ilovesintjob";
            _model.MaxTweets = 10;
            _model.ImageGroupSize = 2;
            _model.SecondsBetweenSlides = 5;
            _view.UpdateView();
        }

        public SettingsView getView()
        {
            return _view;
        }

        public SettingsModel getModel()
        {
            return _model;
        }

        public void changeImageFolder(string folderPath)
        {
            _model.ImagesFolderPath = folderPath;
            _mainController.getPresentationController().loadImages();
        }

        public MainController getMainController()
        {
            return _mainController;
        }

        public string getImagesFolderPath()
        {
            return _model.ImagesFolderPath;
        }
    }
}
