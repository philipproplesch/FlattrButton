using System;
using System.Windows.Forms;

namespace PhilipProplesch.WLW.FlattrButton
{
    public partial class Configuration : Form
    {
        private Settings _settings;
        public Configuration(Settings settings)
        {
            InitializeComponent();
            _settings = settings;

            Id.Text = _settings.FlattrId;
            DisplayMode.Text = _settings.CompactMode ? "Compact" : "Normal";
        }

        private void Save_Click(object sender, EventArgs e)
        {
            _settings.FlattrId = Id.Text;
            _settings.CompactMode = DisplayMode.Text == "Compact";
            
            Close();
        }
    }
}
