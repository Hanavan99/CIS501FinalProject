using CIS501FinalProject.File;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CIS501FinalProject.Event
{
    public class LoadEventHandler : IEventHandler
    {
        public void HandleEvent(object[] args)
        {
            TextBox uxLocalFilePath = (TextBox)args[0];
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                uxLocalFilePath.Text = openFileDialog.FileName;
                FileLoader ksisFileLoader = new FileLoader();
                ScheduleMemory.LocalSemester = ksisFileLoader.LoadFile(uxLocalFilePath.Text);
            }
        }
    }
}
