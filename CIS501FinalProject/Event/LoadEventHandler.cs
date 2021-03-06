﻿using CIS501FinalProject.File;
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

        private FileLoader localFileLoader = new FileLoader();

        public void HandleEvent(object[] args)
        {
            TextBox uxLocalFilePath = (TextBox)args[0];
            OpenFileDialog openFileDialog = new OpenFileDialog();
            bool showDialog = (bool)args[1];
            if (!showDialog || (showDialog && openFileDialog.ShowDialog() == DialogResult.OK))
            {
                if (showDialog)
                {
                    uxLocalFilePath.Text = openFileDialog.FileName;
                }
                ScheduleMemory.LocalSemester = localFileLoader.LoadFile(uxLocalFilePath.Text);
            }
        }
    }
}
