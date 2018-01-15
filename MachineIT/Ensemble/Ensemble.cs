using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MachineIT
{
    public class Ensemble
    {
        string reference;
        string nom;
        List<Composant> composants;

        public Ensemble(string _reference)
        {
            reference = _reference;
            composants = new List<Composant>();
        }

        public List<Composant> Composants { get => composants; set => composants = value; }
        public string Nom { get => nom; set => nom = value; }
        public string Reference { get => reference; set => reference = value; }
    }
}
