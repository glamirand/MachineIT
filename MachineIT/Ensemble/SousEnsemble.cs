using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MachineIT
{
    public class SousEnsemble : Composant
    {
        string numero;
        List<Composant> composants;

        public SousEnsemble(string _numero) : base()
        {
            numero = _numero;
            composants = new List<Composant>();
        }

        public string Numero { get => numero; set => numero = value; }
        public List<Composant> Composants { get => composants; set => composants = value; }
    }
}
