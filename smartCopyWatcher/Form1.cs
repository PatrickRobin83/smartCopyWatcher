
using System;
using System.Drawing;
using System.Windows.Forms;

namespace smartCopyWatcher
{
    public partial class Form1 : Form
    {
        Watcher watcher = new Watcher();

        public Form1()
        {
            this.Opacity = 0;
            InitializeComponent();
        }

        private void btn_minimize_Click(object sender, EventArgs e)
        {
            this.Opacity = 0;
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Opacity = 255;
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
        private string FormatText()
        {
            return String.Format("Der Ordner {0} wird derzeit überwacht", watcher.path); ;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            watcher.watch();
            txt_InfoText.Text = FormatText();
            txt_InfoText.Font = new Font(txt_InfoText.Font.FontFamily, 15);
            txt_InfoText.BorderStyle = BorderStyle.None;
            this.WindowState = FormWindowState.Normal;
        }
    }
}
