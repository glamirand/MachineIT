﻿using System;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MachineIT
{
    /// <summary>
    /// Logique d'interaction pour PageMachine.xaml
    /// </summary>
    public partial class PageMachine : Page
    {
        public Machine ma;
        
        public PageMachine(Machine _machine)
        {
            InitializeComponent();
            ma = _machine;
            // num.Text = NomMachin;
            DataContext = ma;
        }
    }
}
