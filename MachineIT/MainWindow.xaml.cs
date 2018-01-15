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
            Machine Ma1 = new Machine("9999_01", "Machine 1");
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

            //Affichage

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
    }
}
