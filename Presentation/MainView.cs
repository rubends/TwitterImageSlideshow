using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentation
{
    public partial class MainView : Form
    {
        private MainController _controller;
        public MainView(MainController controller)
        {
            _controller = controller;

            InitializeComponent();
        }

        private void MainView_Load(object sender, EventArgs e)
        {
            Controls.Add(_controller.getSettingsController().getView());
        }
    }
}
