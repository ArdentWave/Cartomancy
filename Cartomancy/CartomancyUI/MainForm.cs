using System;
using System.Windows.Forms;
using CartomancyCore;

namespace CartomancyUI
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void GenerateJsonButton_Click(object sender, EventArgs e)
        {
            var horz = Convert.ToInt32(MapHorzTextBox.Text);
            var vert = Convert.ToInt32(MapVertTextBox.Text);
            var mapTemplate = new MapTemplate("DevMap") { SizeHorizontal = horz, SizeVertical = vert };
            JsonRichTextBox.Text = mapTemplate.ToJsonString();
        }
    }
}
