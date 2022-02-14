using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindDow
{
    public partial class ShowcaseWindow : Form
    {
        IntPtr nextClipboardViewer;
        public ShowcaseWindow()
        {
            InitializeComponent();
            nextClipboardViewer = (IntPtr)SetClipboardViewer((int)this.Handle);
        }

        protected override void WndProc(ref System.Windows.Forms.Message m)
        {
            //  defined in winuser.h
            const int WM_DRAWCLIPBOARD = 0x308;
            const int WM_CHANGECBCHAIN = 0x030D;

            switch (m.Msg)
            {
                case WM_DRAWCLIPBOARD:
                    DisplayClipboardData();
                    SendMessage(nextClipboardViewer, m.Msg, m.WParam, m.LParam);
                    break;

                case WM_CHANGECBCHAIN:
                    if (m.WParam == nextClipboardViewer)
                        nextClipboardViewer = m.LParam;
                    else
                        SendMessage(nextClipboardViewer, m.Msg, m.WParam, m.LParam);
                    break;
                default:
                    base.WndProc(ref m);
                    break;
            }
        }

        private void 清空ClearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            pictureBox1.Image = null;
        }

        private void 绿幕背景BackgroundToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.BackColor = richTextBox1.BackColor == Color.Lime ? Color.White : Color.Lime;
        }

        private void ShowcaseWindow_Load(object sender, EventArgs e)
        {
            richTextBox1.MouseWheel += RichTextBox1_MouseWheel;
        }

        private void RichTextBox1_MouseWheel(object? sender, MouseEventArgs e)
        {
            //if (Regex.IsMatch(richTextBox1.SelectedRtf, "(?<=\\\\picw)[^goal].+?(?=\\\\)"))
            //{
            //    if (e.Delta > 0) richTextBox1.SelectedRtf = ResizeImage(richTextBox1.SelectedRtf, -0.05);
            //    else richTextBox1.SelectedRtf = ResizeImage(richTextBox1.SelectedRtf, 0.05);
            //}
        }

        private void 加粗选中BoldenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont.Name, richTextBox1.SelectionFont.Size,
                (richTextBox1.SelectionFont.Bold) ? FontStyle.Regular : FontStyle.Bold);
        }

        private void 黑白切换WhiteBlackToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionColor = richTextBox1.SelectionColor == Color.Black ? Color.White : Color.Black;
        }

        private void 高级字体设置FontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fontDialog1.Font = richTextBox1.SelectionFont;
            fontDialog1.ShowDialog();
            richTextBox1.SelectionFont = fontDialog1.Font;
        }

        private string ResizeImage(string rtfdata, double dscale)
        {
            string regex_width = "(?<=\\\\picw)[^goal].+?(?=\\\\)";
            string regex_widthtarget = "(?<=\\\\picwgoal).+?(?=\\\\)";
            string regex_height = "(?<=\\\\pich)[^goal].+?(?=\\\\)";
            string regex_heighttarget = "(?<=\\\\pichgoal).+?(?=\\\\)";

            int width = int.Parse(Regex.Match(rtfdata, regex_width).Value);
            int height = int.Parse(Regex.Match(rtfdata, regex_height).Value);
            int twidth = int.Parse(Regex.Match(rtfdata, regex_widthtarget).Value);

            double scale = twidth / width;
            scale += dscale;

            int target_width = (int)(width * scale);
            int target_height = (int)(height * scale);

            Regex.Replace(rtfdata, regex_widthtarget, target_width.ToString());
            Regex.Replace(rtfdata, regex_heighttarget, target_height.ToString());
            return rtfdata;
        }

        public void DisplayClipboardData()
        {
            try
            {
                IDataObject iData = new DataObject();
                iData = Clipboard.GetDataObject();

                if (iData.GetDataPresent(DataFormats.Bitmap))
                    pictureBox1.Image = (Bitmap)iData.GetData(DataFormats.Bitmap);
            }
            catch (Exception e)
            {
            }
        }


        private void 剪贴板视图模式ClipboardToolStripMenuItem_CheckedChanged(object sender, EventArgs e)
        {
            richTextBox1.Visible = !剪贴板视图模式ClipboardToolStripMenuItem.Checked;
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        [DllImport("User32.dll")]
        protected static extern int SetClipboardViewer(int hWndNewViewer);

        [DllImport("User32.dll", CharSet = CharSet.Auto)]
        public static extern bool ChangeClipboardChain(IntPtr hWndRemove, IntPtr hWndNewNext);

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        public static extern int SendMessage(IntPtr hwnd, int wMsg, IntPtr wParam, IntPtr lParam);

        private void ShowcaseWindow_FormClosed(object sender, FormClosedEventArgs e)
        {
            ChangeClipboardChain(this.Handle, nextClipboardViewer);
        }
    }
}
