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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MachineIT
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();


            TreeViewItem machine = new TreeViewItem();
            machine.Header = "Machine";
            tvMachine.Items.Add(machine);
            machine.IsExpanded = true;


            EnsembleTreeViewItem Ensemble = new EnsembleTreeViewItem();
            Ensemble.Text = "Ensemble 1";
            machine.Items.Add(Ensemble);

            EnsembleTreeViewItem Ens = new EnsembleTreeViewItem();
            Ens.Text = "Test d'ensemble";
            machine.Items.Add(Ens);

        }
    }
}
