using CIS501FinalProject.Event;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CIS501FinalProject
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            EventDispatcher.RegisterHandler("about", new ViewAboutEventHandler());
            EventDispatcher.RegisterHandler("load", new LoadEventHandler());
            EventDispatcher.RegisterHandler("verify", new VerifyEventHandler());
            EventDispatcher.RegisterHandler("reload", new ReloadEventHandler());
            EventDispatcher.RegisterHandler("clear", new ClearEventHandler());

            InitializeComponent();
        }

        private void uxReload_Click(object sender, EventArgs e)
        {
            EventDispatcher.DispatchEvent("reload", new object[] { uxLocalFilePath, uxKSISFilePath, uxResults });
        }

        private void uxViewAbout_Click(object sender, EventArgs e)
        {
            EventDispatcher.DispatchEvent("about", null);
        }

        private void uxVerify_Click(object sender, EventArgs e)
        {
            EventDispatcher.DispatchEvent("verify", new object[] { uxKSISFilePath, uxResults, true });
        }

        private void uxLoad_Click(object sender, EventArgs e)
        {
            EventDispatcher.DispatchEvent("load", new object[] { uxLocalFilePath, true });
        }

        private void uxClear_Click(object sender, EventArgs e)
        {
            EventDispatcher.DispatchEvent("clear", new object[] { uxLocalFilePath, uxKSISFilePath, uxResults });
        }
    }
}
