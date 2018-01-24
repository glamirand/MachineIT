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

            //Création de données
            #region Génération
            List<Machine> Machines = new List<Machine>();
            Machine Ma1 = new Machine("9999_01", "Machine 1");
            Machines.Add(Ma1);
            for (int i = 0; i < 2; i++)
            {
                Ensemble Ens = new Ensemble("Ensemble " + i);
                Ma1.Ensembles.Add(Ens);
                for (int j = 0; j < 3; j++)
                {
                    SousEnsemble SEns = new SousEnsemble("Sous-ensemble " + i + "/" + j);
                    for (int k = 0; k < 4; k++)
                    {
                        Piece Piece = new Piece("Pièce " + i + "/" + j + "/" + k);
                        SEns.Composants.Add(Piece);
                    }
                    Ens.Composants.Add(SEns);

                }
            }
            Machine Ma2 = new Machine("1234_00", "Machine 2");
            Ma2 = Ma1 ;
            Machines.Add(Ma2);
            Ma2.Numero = "1122_00";
            #endregion

            //Affichage
            #region Affichage

            if (false)
            {
            MachineTreeViewItem machine = new MachineTreeViewItem("Machine");
            tvMachine.Items.Add(machine);

            foreach (Ensemble ensembl in Ma1.Ensembles)
            {
                EnsembleTreeViewItem Ensemble = new EnsembleTreeViewItem(ensembl.Reference);
                machine.Items.Add(Ensemble);
                foreach (SousEnsemble Sens in ensembl.Composants)
                {
                    EnsembleTreeViewItem SEnsemble = new EnsembleTreeViewItem(Sens.Numero);
                    Ensemble.Items.Add(SEnsemble);
                    foreach (Piece piece in Sens.Composants)
                    {
                        PieceTreeViewItem pIece = new PieceTreeViewItem(piece.Reference);
                        SEnsemble.Items.Add(pIece);
                    }
                }
            }
            }

            #endregion

            // TVTest.ItemsSource = Machines;
            tvMachine.DataContext = Machines;
            
        }

        private void TVTest_SelectedItemChanged(object sender, RoutedPropertyChangedEventArgs<object> e)
        {
            object selectedObject = ((TreeView)sender).SelectedItem;

            if (selectedObject is Machine)
            {
                Machine machine = (Machine)selectedObject;
                frameContent.Content = new PageMachine(machine);
                frameContent.DataContext = machine;
               // MessageBox.Show("Machine n° : " + machine.Numero);
            }
            else if(selectedObject is Ensemble)
            {
                Ensemble ensemble = (Ensemble)selectedObject;
                frameContent.Content = new PageEnsemble();
               // MessageBox.Show("Ensemble : " + ensemble.Nom);
            }
            else if (selectedObject is SousEnsemble)
            {
                SousEnsemble sousensemble = (SousEnsemble)selectedObject;
                MessageBox.Show("SousEnsemble : " + sousensemble.Numero);
            }
            else if (selectedObject is Piece)
            {
                Piece piece = (Piece)selectedObject;
                MessageBox.Show("Pièce : " + piece.Reference);
            }
            else if (selectedObject is Composant)
            {
                Composant composant = (Composant)selectedObject;
                MessageBox.Show("Composant");
            }
            else
            {
                MessageBox.Show("Autre!");
            }
            
        }
    }
}
