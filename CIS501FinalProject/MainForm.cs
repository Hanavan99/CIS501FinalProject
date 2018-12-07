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

            InitializeComponent();
        }

        private void uxReload_Click(object sender, EventArgs e)
        {
            EventDispatcher.DispatchEvent("reload", new string[] { uxLocalFilePath.Text, uxKSISFilePath.Text });
        }

        private void uxViewAbout_Click(object sender, EventArgs e)
        {
            EventDispatcher.DispatchEvent("about", null);
        }

        private void uxVerify_Click(object sender, EventArgs e)
        {
            EventDispatcher.DispatchEvent("verify", new object[] { uxKSISFilePath, uxResults });
        }

        private void uxLoad_Click(object sender, EventArgs e)
        {
            EventDispatcher.DispatchEvent("load", new object[] { uxLocalFilePath });
        }
    }
}
