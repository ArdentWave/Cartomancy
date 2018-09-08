using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            var mapTemplate = new MapTemplate() { SizeHorizontal = horz, SizeVertical = vert };
            JsonRichTextBox.Text = mapTemplate.ToJsonString();
        }
    }
}
