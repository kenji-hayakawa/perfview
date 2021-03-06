﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace PerfView.Dialogs
{
    /// <summary>
    /// Dialog poped when the symbol path is empty.  This gives the user control over whether PerfView will perform network operations
    /// 
    /// It is intended that this be a modal dialog (ShowDialog)
    /// </summary>
    public partial class EmptySymbolPathDialog : Window
    {
        /// <summary>
        /// The action is given a 'true' value if MSSymbols should be used.  
        /// </summary>
        public EmptySymbolPathDialog()
        {
            InitializeComponent();
        }

        public bool UseMSSymbols;

        #region private 
        private void UseEmptyPathClicked(object sender, RoutedEventArgs e)
        {
            UseMSSymbols = false;
            Close();
        }

        private void UseMSSymbolsClicked(object sender, RoutedEventArgs e)
        {
            UseMSSymbols = true;
            Close();
        }
        #endregion 
    }
}
