using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MachineIT
{ 
    public class Machine
    {
        string numero;
        string libele;
        List<Ensemble> ensembles;

        public Machine(string _numero, string _libele)
        {
            numero = _numero;
            libele = _libele;
            ensembles = new List<Ensemble>();
        }

        public List<Ensemble> Ensembles { get => ensembles; set => ensembles = value; }
        public string Numero { get => numero; set => numero = value; }
    }
}
