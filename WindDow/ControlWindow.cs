using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindDow
{
    public partial class ControlWindow : Form
    {
        public ShowcaseWindow showwindow = new ShowcaseWindow();
        public ControlWindow()
        {
            InitializeComponent();
        }

        private void ControlWindow_Load(object sender, EventArgs e)
        {
            showwindow.Show();
        }

        private void previewbox_TextChanged(object sender, EventArgs e)
        {
        }

        private void push_Click(object sender, EventArgs e)
        {
        }
    }
}
